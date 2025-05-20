using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Media;
using System;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            ClockCanvas.Loaded += (s, e) => DrawClock();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DrawClock();
        }

        private void DrawClock()
        {
            ClockCanvas.Children.Clear();

            double centerX = ClockCanvas.Width / 2;
            double centerY = ClockCanvas.Height / 2;
            double radius = 150;

            // Рисуем окружность часов
            var circle = new System.Windows.Shapes.Ellipse
            {
                Width = radius * 2,
                Height = radius * 2,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(circle, centerX - radius);
            Canvas.SetTop(circle, centerY - radius);
            ClockCanvas.Children.Add(circle);

            // Получаем текущее время
            DateTime now = DateTime.Now;
            double angle = now.Second * 6 - 90; // 6 градусов на секунду, -90 чтобы 0 был вверх

            double x2 = centerX + radius * 0.9 * Math.Cos(angle * Math.PI / 180);
            double y2 = centerY + radius * 0.9 * Math.Sin(angle * Math.PI / 180);

            // Рисуем секундную стрелку
            var secondHand = new System.Windows.Shapes.Line
            {
                X1 = centerX,
                Y1 = centerY,
                X2 = x2,
                Y2 = y2,
                Stroke = Brushes.Red,
                StrokeThickness = 2
            };
            ClockCanvas.Children.Add(secondHand);
        }
    }
}