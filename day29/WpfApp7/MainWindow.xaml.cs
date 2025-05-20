using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private double t = 0;
        private double amplitude = 100; 
        private double centerY = 225;   
        private double speed = 5;       

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SineCanvas.Children.Clear();

            // Рисуем синусоиду линией
            Polyline sineLine = new Polyline
            {
                Stroke = Brushes.DarkGreen,
                StrokeThickness = 2
            };
            for (int i = 0; i < SineCanvas.Width; i++)
            {
                double y = centerY + amplitude * Math.Sin(i * 0.02);
                sineLine.Points.Add(new Point(i, y));
            }
            SineCanvas.Children.Add(sineLine);

            double x = t;
            double yCircle = centerY + amplitude * Math.Sin(t * 0.02);

            Ellipse circle = new Ellipse
            {
                Width = 40,
                Height = 40,
                Fill = Brushes.DeepSkyBlue,
                Stroke = Brushes.Blue,
                StrokeThickness = 2
            };
            Canvas.SetLeft(circle, x);
            Canvas.SetTop(circle, yCircle);
            SineCanvas.Children.Add(circle);

            t += speed;
            if (x > SineCanvas.Width)
            {
                t = 0;
            }
        }
    }
}