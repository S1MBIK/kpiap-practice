using System;
using System.IO;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            // Устанавливаем путь к базе данных
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsersDB.mdf");
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(dbPath));
            
            // Логика создания базы данных теперь в MainWindow
        }
    }
}
