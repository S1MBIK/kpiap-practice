using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private const string DB_NAME = "WpfApp3DB";
        private const string DB_FILE = "WpfApp3DB.mdf";

        public MainWindow()
        {
            InitializeComponent();
            // Установка строки подключения по умолчанию
            string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_FILE);
            ConnectionStringTextBox.Text = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";
            
            // Отключаем кнопки при запуске
            LoadButton.IsEnabled = false;
            SaveButton.IsEnabled = false;
            AddButton.IsEnabled = false;
        }

        private void InitializeDatabase()
        {
            try
            {
                // Создаем подключение к master для создания базы данных
                using (SqlConnection masterConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True"))
                {
                    masterConnection.Open();

                    // Проверяем существование базы данных
                    string checkDbQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{DB_NAME}'";
                    using (SqlCommand checkDbCmd = new SqlCommand(checkDbQuery, masterConnection))
                    {
                        object result = checkDbCmd.ExecuteScalar();
                        if (result == null)
                        {
                            // Создаем базу данных
                            string createDbQuery = $@"CREATE DATABASE {DB_NAME} ON PRIMARY 
                                (NAME = {DB_NAME}_Data, 
                                FILENAME = '{System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_FILE)}',
                                SIZE = 2MB, 
                                MAXSIZE = 10MB, 
                                FILEGROWTH = 10%)";
                            using (SqlCommand createDbCmd = new SqlCommand(createDbQuery, masterConnection))
                            {
                                createDbCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                // Подключаемся к созданной базе данных
                connection = new SqlConnection(ConnectionStringTextBox.Text);
                connection.Open();

                // Проверяем существование таблицы
                string checkTableQuery = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Users'";
                using (SqlCommand checkTableCmd = new SqlCommand(checkTableQuery, connection))
                {
                    int tableCount = (int)checkTableCmd.ExecuteScalar();
                    if (tableCount == 0)
                    {
                        // Создаем таблицу
                        string createTableQuery = @"
                            CREATE TABLE Users (
                                Id INT IDENTITY(1,1) PRIMARY KEY,
                                Name NVARCHAR(100),
                                Email NVARCHAR(100)
                            )";
                        using (SqlCommand createTableCmd = new SqlCommand(createTableQuery, connection))
                        {
                            createTableCmd.ExecuteNonQuery();
                        }

                        // Добавляем тестовые данные
                        string insertDataQuery = @"
                            INSERT INTO Users (Name, Email) VALUES 
                            ('Иван Иванов', 'ivan@example.com'),
                            ('Петр Петров', 'petr@example.com')";
                        using (SqlCommand insertDataCmd = new SqlCommand(insertDataQuery, connection))
                        {
                            insertDataCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("База данных успешно инициализирована!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadButton.IsEnabled = true;
                SaveButton.IsEnabled = true;
                AddButton.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации базы данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Users";
                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataGrid.ItemsSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Изменения успешно сохранены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(EmailTextBox.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                string query = "INSERT INTO Users (Name, Email) VALUES (@Name, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", NameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    cmd.ExecuteNonQuery();
                }

                // Очищаем поля ввода
                NameTextBox.Clear();
                EmailTextBox.Clear();

                // Обновляем отображение данных
                LoadButton_Click(sender, e);

                MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}