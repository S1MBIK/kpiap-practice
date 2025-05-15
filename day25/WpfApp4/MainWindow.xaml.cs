using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateButton(50, 50); 
        }

        private void CreateButton(double left, double top)
        {
            Button btn = new Button();
            btn.Content = "Кнопка";
            btn.Width = 100;
            btn.Height = 40;
            Canvas.SetLeft(btn, left);
            Canvas.SetTop(btn, top);

            btn.MouseEnter += Btn_MouseEnter;
            btn.Click += Btn_Click;

            MainCanvas.Children.Add(btn);
        }

        private void Btn_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            
            Random rnd = new Random();
            double left = rnd.Next(0, (int)(MainCanvas.ActualWidth - 100));
            double top = rnd.Next(0, (int)(MainCanvas.ActualHeight - 40));
            CreateButton(left, top);
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MainCanvas.Children.Remove(btn);
        }
    }
}