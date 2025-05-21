using Microsoft.Data.Sqlite;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string connectionString = "Data Source=database.db";

        public MainWindow()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();

                // Создаем только нужные таблицы
                cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Туристы (
                    [Код туриста] INTEGER PRIMARY KEY AUTOINCREMENT,
                    [Фамилия] TEXT,
                    [Имя] TEXT,
                    [Отчество] TEXT
                );
                CREATE TABLE IF NOT EXISTS Туры (
                    [Код тура] INTEGER PRIMARY KEY AUTOINCREMENT,
                    [Название] TEXT,
                    [Цена] REAL,
                    [Информация] TEXT
                );";
                cmd.ExecuteNonQuery();

                // Проверка наличия тестовых данных
                cmd.CommandText = "SELECT COUNT(*) FROM Туры";
                long count = (long)cmd.ExecuteScalar();

                if (count == 0)
                {
                    cmd.CommandText = @"
                    INSERT INTO Туры ([Название], [Цена], [Информация]) VALUES 
                    ('Тур в Египет', 15000, 'Отдых на море'),
                    ('Тур в Турцию', 12000, 'Все включено');";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadData()
        {
            ToursDataGrid.ItemsSource = GetTours();
            TouristsDataGrid.ItemsSource = GetTourists();
        }

        private List<Tourist> GetTourists()
        {
            var tourists = new List<Tourist>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Туристы";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tourists.Add(new Tourist
                        {
                            Код_туриста = reader.GetInt32(0),
                            Фамилия = reader.GetString(1),
                            Имя = reader.GetString(2),
                            Отчество = reader.GetString(3)
                        });
                    }
                }
            }
            return tourists;
        }

        private List<Tour> GetTours()
        {
            var tours = new List<Tour>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Туры";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tours.Add(new Tour
                        {
                            Код_тура = reader.GetInt32(0),
                            Название = reader.GetString(1),
                            Цена = reader.GetDouble(2),
                            Информация = reader.GetString(3)
                        });
                    }
                }
            }
            return tours;
        }

        private void DeleteTour_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DeleteTourIdBox.Text))
            {
                MessageBox.Show("Введите код тура для удаления");
                return;
            }

            if (!int.TryParse(DeleteTourIdBox.Text, out int id))
            {
                MessageBox.Show("Введите корректный код тура");
                return;
            }

            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    
                    // Проверяем существование тура
                    var checkCmd = connection.CreateCommand();
                    checkCmd.CommandText = "SELECT COUNT(*) FROM Туры WHERE [Код тура] = @id";
                    checkCmd.Parameters.AddWithValue("@id", id);
                    long count = (long)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Тур с указанным кодом не найден");
                        return;
                    }

                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM Туры WHERE [Код тура] = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("Тур успешно удален");
                DeleteTourIdBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при удалении тура: {ex.Message}");
            }
        }

        private void AddTourist_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddSurnameBox.Text) || 
                string.IsNullOrWhiteSpace(AddNameBox.Text) || 
                string.IsNullOrWhiteSpace(AddPatronymicBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Туристы ([Фамилия], [Имя], [Отчество]) VALUES (@surname, @name, @patronymic)";
                cmd.Parameters.AddWithValue("@surname", AddSurnameBox.Text);
                cmd.Parameters.AddWithValue("@name", AddNameBox.Text);
                cmd.Parameters.AddWithValue("@patronymic", AddPatronymicBox.Text);
                cmd.ExecuteNonQuery();
            }
            LoadData();
            MessageBox.Show("Турист успешно добавлен");
        }

        private void EditTourist_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(EditTouristIdBox.Text, out int id))
            {
                MessageBox.Show("Введите корректный код туриста");
                return;
            }

            if (string.IsNullOrWhiteSpace(EditSurnameBox.Text) || 
                string.IsNullOrWhiteSpace(EditNameBox.Text) || 
                string.IsNullOrWhiteSpace(EditPatronymicBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE Туристы SET [Фамилия]=@surname, [Имя]=@name, [Отчество]=@patronymic WHERE [Код туриста]=@id";
                cmd.Parameters.AddWithValue("@surname", EditSurnameBox.Text);
                cmd.Parameters.AddWithValue("@name", EditNameBox.Text);
                cmd.Parameters.AddWithValue("@patronymic", EditPatronymicBox.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadData();
            MessageBox.Show("Данные туриста успешно обновлены");
        }
    }

    public class Tourist
    {
        public int Код_туриста { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
    }

    public class Tour
    {
        public int Код_тура { get; set; }
        public string Название { get; set; }
        public double Цена { get; set; }
        public string Информация { get; set; }
    }
}



