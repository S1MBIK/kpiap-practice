using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.IO;
using System.Text;

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private SqlConnection connection;
    private SqlDataAdapter adapter;
    private DataTable dataTable;
    private const string DB_NAME = "WpfApp2DB";
    private const string DB_FILE = "WpfApp2DB.mdf";
    private bool isToursMode = true;

    public MainWindow()
    {
        InitializeComponent();
        // Установка строки подключения по умолчанию
        string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_FILE);
        ConnectionStringTextBox.Text = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";
        
        // Отключаем кнопки при запуске
        LoadToursButton.IsEnabled = false;
        LoadTouristsButton.IsEnabled = false;
        AddButton.IsEnabled = false;
        DeleteButton.IsEnabled = false;
        EditButton.IsEnabled = false;
        SaveButton.IsEnabled = false;
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
                            FILENAME = '{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_FILE)}',
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

            // Создаем таблицы, если они не существуют
            CreateTablesIfNotExist();

            MessageBox.Show("База данных успешно инициализирована!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadToursButton.IsEnabled = true;
            LoadTouristsButton.IsEnabled = true;
            AddButton.IsEnabled = true;
            DeleteButton.IsEnabled = true;
            EditButton.IsEnabled = true;
            SaveButton.IsEnabled = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка инициализации базы данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void CreateTablesIfNotExist()
    {
        // Создаем таблицу Tours
        string createToursTableQuery = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Tours')
            CREATE TABLE Tours (
                Id INT IDENTITY(1,1) PRIMARY KEY,
                Name NVARCHAR(100),
                Country NVARCHAR(100),
                Price DECIMAL(18,2)
            )";
        using (SqlCommand cmd = new SqlCommand(createToursTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }

        // Создаем таблицу Tourists
        string createTouristsTableQuery = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Tourists')
            CREATE TABLE Tourists (
                Id INT IDENTITY(1,1) PRIMARY KEY,
                FullName NVARCHAR(100),
                Passport NVARCHAR(20),
                Phone NVARCHAR(20)
            )";
        using (SqlCommand cmd = new SqlCommand(createTouristsTableQuery, connection))
        {
            cmd.ExecuteNonQuery();
        }

        // Добавляем тестовые данные, если таблицы пустые
        string checkToursQuery = "SELECT COUNT(*) FROM Tours";
        using (SqlCommand cmd = new SqlCommand(checkToursQuery, connection))
        {
            int toursCount = (int)cmd.ExecuteScalar();
            if (toursCount == 0)
            {
                string insertToursQuery = @"
                    INSERT INTO Tours (Name, Country, Price) VALUES 
                    ('Отдых в Турции', 'Турция', 50000),
                    ('Экскурсия по Парижу', 'Франция', 75000)";
                using (SqlCommand insertCmd = new SqlCommand(insertToursQuery, connection))
                {
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        string checkTouristsQuery = "SELECT COUNT(*) FROM Tourists";
        using (SqlCommand cmd = new SqlCommand(checkTouristsQuery, connection))
        {
            int touristsCount = (int)cmd.ExecuteScalar();
            if (touristsCount == 0)
            {
                string insertTouristsQuery = @"
                    INSERT INTO Tourists (FullName, Passport, Phone) VALUES 
                    ('Иван Иванов', '1234 567890', '+7(999)123-45-67'),
                    ('Петр Петров', '9876 543210', '+7(999)765-43-21')";
                using (SqlCommand insertCmd = new SqlCommand(insertTouristsQuery, connection))
                {
                    insertCmd.ExecuteNonQuery();
                }
            }
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

    private void LoadToursButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            string query = "SELECT * FROM Tours";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataGrid.ItemsSource = dataTable.DefaultView;
            isToursMode = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки туров: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void LoadTouristsButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            string query = "SELECT * FROM Tourists";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataGrid.ItemsSource = dataTable.DefaultView;
            isToursMode = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки туристов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (isToursMode)
            {
                var newRow = dataTable.NewRow();
                newRow["Name"] = "Новый тур";
                newRow["Country"] = "Страна";
                newRow["Price"] = 0.0m;
                dataTable.Rows.Add(newRow);
            }
            else
            {
                var newRow = dataTable.NewRow();
                newRow["FullName"] = "Новый турист";
                newRow["Passport"] = "Паспорт";
                newRow["Phone"] = "Телефон";
                dataTable.Rows.Add(newRow);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (DataGrid.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для удаления!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", 
                "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                
            if (result == MessageBoxResult.Yes)
            {
                var row = ((DataRowView)DataGrid.SelectedItem).Row;
                row.Delete();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void EditButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (DataGrid.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись для редактирования!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var row = ((DataRowView)DataGrid.SelectedItem).Row;
            // Здесь можно добавить диалог редактирования
            MessageBox.Show("Редактирование записи", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при редактировании записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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

    private void btnShowData_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            connection.Open();
            var sb = new StringBuilder();

            // Получаем данные о турах
            using (var cmd = new SqlCommand("SELECT * FROM Tours", connection))
            using (var reader = cmd.ExecuteReader())
            {
                sb.AppendLine("=== ТУРЫ ===");
                while (reader.Read())
                {
                    sb.AppendLine($"ID: {reader["Id"]}");
                    sb.AppendLine($"Название: {reader["Name"]}");
                    sb.AppendLine($"Страна: {reader["Country"]}");
                    sb.AppendLine($"Цена: {reader["Price"]}");
                    sb.AppendLine();
                }
            }

            // Получаем данные о туристах
            using (var cmd = new SqlCommand("SELECT * FROM Tourists", connection))
            using (var reader = cmd.ExecuteReader())
            {
                sb.AppendLine("=== ТУРИСТЫ ===");
                while (reader.Read())
                {
                    sb.AppendLine($"ID: {reader["Id"]}");
                    sb.AppendLine($"ФИО: {reader["FullName"]}");
                    sb.AppendLine($"Паспорт: {reader["Passport"]}");
                    sb.AppendLine($"Телефон: {reader["Phone"]}");
                    sb.AppendLine();
                }
            }

            MessageBox.Show(sb.ToString(), "Данные в базе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при чтении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}