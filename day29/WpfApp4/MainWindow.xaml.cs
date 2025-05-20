using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private double t = 0;
        private double a = 80; 
        private double centerX = 400;
        private double centerY = 225;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(30);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DrawCanvas.Children.Clear();

            // Декартов лист: x = 3a t / (1 + t^3), y = 3a t^2 / (1 + t^3)
            double x = 3 * a * t / (1 + t * t * t);
            double y = 3 * a * t * t / (1 + t * t * t);

           
            double cx = centerX + x;
            double cy = centerY - y;

            
            Ellipse ellipse = new Ellipse
            {
                Width = 60,
                Height = 60,
                Stroke = Brushes.Blue,
                StrokeThickness = 3,
                Fill = Brushes.LightBlue
            };
            Canvas.SetLeft(ellipse, cx - 20);
            Canvas.SetTop(ellipse, cy - 20);
            DrawCanvas.Children.Add(ellipse);

            
            t += 0.01;
            if (t > 2.5) t = 0; 
        }
    }
}