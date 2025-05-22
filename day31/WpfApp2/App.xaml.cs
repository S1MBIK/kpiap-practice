using System.Configuration;
using System.Data;
using System.Windows;
using System.IO;
using Microsoft.Data.SqlClient;

namespace WpfApp2;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        
        // Устанавливаем путь к базе данных
        string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TourDB.mdf");
        AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(dbPath));
        
        // Создаем базу данных, если она не существует
        if (!File.Exists(dbPath))
        {
            try
            {
                using var connection = new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");
                connection.Open();
                using var command = new SqlCommand(
                    $"CREATE DATABASE [TourDB] ON PRIMARY (NAME=[TourDB], FILENAME='{dbPath}')", connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания базы данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
