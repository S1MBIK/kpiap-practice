using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Controls;

namespace WpfApp6
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            DrawClock();
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
            var circle = new Ellipse
            {
                Width = radius * 2,
                Height = radius * 2,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(circle, centerX - radius);
            Canvas.SetTop(circle, centerY - radius);
            ClockCanvas.Children.Add(circle);

            // Рисуем деления
            for (int i = 0; i < 60; i++)
            {
                double angle = i * 6 * Math.PI / 180;
                double x1 = centerX + (radius - 10) * Math.Cos(angle - Math.PI / 2);
                double y1 = centerY + (radius - 10) * Math.Sin(angle - Math.PI / 2);
                double x2 = centerX + radius * Math.Cos(angle - Math.PI / 2);
                double y2 = centerY + radius * Math.Sin(angle - Math.PI / 2);

                var tick = new Line
                {
                    X1 = x1,
                    Y1 = y1,
                    X2 = x2,
                    Y2 = y2,
                    Stroke = Brushes.Black,
                    StrokeThickness = (i % 5 == 0) ? 3 : 1
                };
                ClockCanvas.Children.Add(tick);
            }

            // Получаем текущее время
            DateTime now = DateTime.Now;
            double secAngle = now.Second * 6 - 90; // 6 градусов на секунду, -90 чтобы 0 был вверх

            double secX = centerX + (radius - 20) * Math.Cos(secAngle * Math.PI / 180);
            double secY = centerY + (radius - 20) * Math.Sin(secAngle * Math.PI / 180);

            // Рисуем секундную стрелку
            var secondHand = new Line
            {
                X1 = centerX,
                Y1 = centerY,
                X2 = secX,
                Y2 = secY,
                Stroke = Brushes.Red,
                StrokeThickness = 2
            };
            ClockCanvas.Children.Add(secondHand);

            // Центр
            var centerDot = new Ellipse
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Black
            };
            Canvas.SetLeft(centerDot, centerX - 5);
            Canvas.SetTop(centerDot, centerY - 5);
            ClockCanvas.Children.Add(centerDot);
        }
    }
}