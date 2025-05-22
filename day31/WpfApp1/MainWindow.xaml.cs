using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using System.Text;
using System.Windows.Controls;
using System.Linq;

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly string connectionString;
    private SqlDataAdapter? adapter;
    private DataTable dataTable;

    public MainWindow()
    {
        InitializeComponent();
        connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NewBD.mdf;Integrated Security=True"; // Строка подключения к нашей БД
        dataTable = new DataTable();
        InitializeDatabase();
        LoadData();
    }

    private void InitializeDatabase()
    {
        try
        {
            // Connect to the Master database to drop the existing database if it exists
            var masterConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
            using (var masterConnection = new SqlConnection(masterConnectionString))
            {
                masterConnection.Open();
                using (var cmdDrop = new SqlCommand("IF EXISTS (SELECT * FROM sys.databases WHERE name = 'UsersDB') DROP DATABASE UsersDB", masterConnection))
                {
                    cmdDrop.ExecuteNonQuery();
                }
            }

            // Now connect to the new database file (which will be created if it doesn't exist)
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var cmdCreate = new SqlCommand(
                    """
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
                    CREATE TABLE Users (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Name NVARCHAR(100) NOT NULL,
                        Age INT NOT NULL
                    );
                    """, connection))
                {
                    cmdCreate.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка инициализации базы данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void LoadData()
    {
        try
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            // Create a new adapter each time data is loaded to ensure commands are linked to the correct connection
            adapter = new SqlDataAdapter("SELECT * FROM Users", connection);
            dataTable.Clear();
            adapter.Fill(dataTable);
            // Find the DataGrid control by name
            var grid = (DataGrid)FindName("dataGrid");
            if (grid != null)
            {
                grid.ItemsSource = dataTable.DefaultView;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btnLoad_Click(object sender, RoutedEventArgs e)
    {
        LoadData();
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
        if (adapter == null)
        {
            MessageBox.Show("Сначала загрузите данные!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        try
        {
            using var connection = new SqlConnection(connectionString);
            // Ensure the adapter's commands are connected to the current connection
            adapter.InsertCommand = (new SqlCommandBuilder(adapter)).GetInsertCommand();
            adapter.UpdateCommand = (new SqlCommandBuilder(adapter)).GetUpdateCommand();
            adapter.DeleteCommand = (new SqlCommandBuilder(adapter)).GetDeleteCommand();

            adapter.InsertCommand.Connection = connection;
            adapter.UpdateCommand.Connection = connection;
            adapter.DeleteCommand.Connection = connection;

            connection.Open(); // Open connection for adapter updates
            adapter.Update(dataTable);
            MessageBox.Show("Изменения сохранены успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadData(); // Reload data after saving
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btnShowData_Click(object sender, RoutedEventArgs e)
    {
        // This button can also just reload data into the grid
        LoadData();
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            // Вставка новой записи, ID будет сгенерирован автоматически базой данных
            using var cmdInsert = new SqlCommand("INSERT INTO Users (Name, Age) VALUES (@Name, @Age); SELECT SCOPE_IDENTITY();", connection);
            cmdInsert.Parameters.AddWithValue("@Name", "Новый пользователь");
            cmdInsert.Parameters.AddWithValue("@Age", 0);

            var newId = cmdInsert.ExecuteScalar(); // Получаем сгенерированный ID
            LoadData(); // Перезагружаем данные, чтобы увидеть новую запись
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка добавления записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
        var grid = (DataGrid)FindName("dataGrid");
        if (grid == null || grid.SelectedItem == null)
        {
            MessageBox.Show("Выберите запись для удаления!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        var result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?",
                                   "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

        if (result == MessageBoxResult.Yes)
        {
            try
            {
                var rowView = (DataRowView)grid.SelectedItem;
                var row = rowView.Row;
                var idToDelete = (int)row["Id"];

                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var cmd = new SqlCommand("DELETE FROM Users WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Id", idToDelete);
                cmd.ExecuteNonQuery();
                LoadData(); // Reload data after deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    private void btnEdit_Click(object sender, RoutedEventArgs e)
    {
        var grid = (DataGrid)FindName("dataGrid");
        if (grid == null || grid.SelectedItem == null)
        {
            MessageBox.Show("Выберите запись для редактирования!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        var rowView = (DataRowView)grid.SelectedItem;
        var row = rowView.Row;
        
        // Create and show the EditWindow
        var editWindow = new EditWindow(row);
        if (editWindow.ShowDialog() == true)
        {
            // If EditWindow was closed with DialogResult = true, save changes
            try
            {
                 // The changes were made directly to the DataRow in EditWindow
                // We now need to update the database using SQL commands
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var cmdUpdate = new SqlCommand("UPDATE Users SET Name = @Name, Age = @Age WHERE Id = @Id", connection);
                cmdUpdate.Parameters.AddWithValue("@Id", row["Id"]);
                cmdUpdate.Parameters.AddWithValue("@Name", row["Name"]);
                cmdUpdate.Parameters.AddWithValue("@Age", row["Age"]);
                cmdUpdate.ExecuteNonQuery();

                LoadData(); // Reload data after editing
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}