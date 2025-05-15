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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void InputX_GotFocus(object sender, RoutedEventArgs e)
        {
            if (inputX.Text == "Введите x")
            {
                inputX.Text = string.Empty;
            }
        }

        private void InputX_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputX.Text))
            {
                inputX.Text = "Введите x";
            }
        }

        private void InputH_GotFocus(object sender, RoutedEventArgs e)
        {
            if (inputH.Text == "Введите h")
            {
                inputH.Text = string.Empty;
            }
        }

        private void InputH_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputH.Text))
            {
                inputH.Text = "Введите h";
            }
        }

        private void PlotGraphButton_Click(object sender, RoutedEventArgs e)
        {
            graphCanvas.Children.Clear();
            try
            {
                double h = double.Parse(inputH.Text);
                double x = double.Parse(inputX.Text);
                double y;
                Polyline polyline = new Polyline
                {
                    Stroke = Brushes.Blue,
                    StrokeThickness = 2
                };

                while (x <= 10) // Example range for x
                {
                    y = Math.Exp(x);
                    polyline.Points.Add(new Point(x * 30, 300 - y * 30)); // Scale and invert y for display
                    x += h;
                }

                graphCanvas.Children.Add(polyline);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение для h.");
            }
        }
    }
}