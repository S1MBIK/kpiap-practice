using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private double rocketY;
        private double rocketStartY = 320;
        private double rocketX = 380;
        private bool isLaunched = false;

        public MainWindow()
        {
            InitializeComponent();
            StartButton.Click += StartButton_Click;
            DrawRocket(rocketX, rocketStartY);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (isLaunched) return;
            isLaunched = true;
            rocketY = rocketStartY;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            rocketY -= 2;
            DrawRocket(rocketX, rocketY);

            if (rocketY < -60)
            {
                timer.Stop();
                isLaunched = false;
            }
        }

        private void DrawRocket(double x, double y)
        {
            RocketCanvas.Children.Clear();

            // Тело ракеты
            var body = new Rectangle
            {
                Width = 40,
                Height = 80,
                Fill = Brushes.Gray,
                Stroke = Brushes.White,
                StrokeThickness = 2
            };
            Canvas.SetLeft(body, x);
            Canvas.SetTop(body, y);
            RocketCanvas.Children.Add(body);

            // Нос ракеты (треугольник)
            var nose = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(x, y),
                    new Point(x + 20, y - 40),
                    new Point(x + 40, y)
                },
                Fill = Brushes.Red
            };
            RocketCanvas.Children.Add(nose);

            // Пламя (если ракета взлетает)
            if (isLaunched && rocketY > -40)
            {
                var flame = new Polygon
                {
                    Points = new PointCollection
                    {
                        new Point(x + 10, y + 80),
                        new Point(x + 20, y + 110 + (rocketY % 10)),
                        new Point(x + 30, y + 80)
                    },
                    Fill = Brushes.Orange
                };
                RocketCanvas.Children.Add(flame);
            }
        }
    }
}