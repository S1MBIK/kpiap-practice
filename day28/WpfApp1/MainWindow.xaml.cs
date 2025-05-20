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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Content = new MyShapes();
        }
    }

    public class MyShapes : FrameworkElement
    {
        protected override void OnRender(DrawingContext dc)
        {
            // Треугольник
            Point p1 = new Point(40, 40);
            Point p2 = new Point(100, 150);
            Point p3 = new Point(10, 150);
            StreamGeometry triangle = new StreamGeometry();
            using (var ctx = triangle.Open())
            {
                ctx.BeginFigure(p1, false, true);
                ctx.LineTo(p2, true, false);
                ctx.LineTo(p3, true, false);
            }
            dc.DrawGeometry(null, new Pen(Brushes.Black, 2), triangle);

            // Эллипс
            dc.DrawEllipse(null, new Pen(Brushes.Blue, 2), new Point(180, 80), 50, 30);

            // Закрашенный круг
            dc.DrawEllipse(Brushes.Green, new Pen(Brushes.Green, 2), new Point(320, 80), 40, 40);

            // Закрашенный прямоугольник
            dc.DrawRectangle(Brushes.Red, new Pen(Brushes.Red, 2), new Rect(40, 200, 100, 80));

            // Сектор (дуга)
            Point center = new Point(250, 250);
            double radius = 60;
            double startAngle = 30;
            double endAngle = 150;
            Point start = new Point(
                center.X + radius * Math.Cos(startAngle * Math.PI / 180),
                center.Y - radius * Math.Sin(startAngle * Math.PI / 180));
            Point end = new Point(
                center.X + radius * Math.Cos(endAngle * Math.PI / 180),
                center.Y - radius * Math.Sin(endAngle * Math.PI / 180));
            StreamGeometry sector = new StreamGeometry();
            using (var ctx = sector.Open())
            {
                ctx.BeginFigure(center, true, true);
                ctx.LineTo(start, true, false);
                ctx.ArcTo(end, new Size(radius, radius), 0, false, SweepDirection.Counterclockwise, true, false);
                ctx.LineTo(center, true, false);
            }
            dc.DrawGeometry(Brushes.Purple, new Pen(Brushes.Purple, 2), sector);

            // три окружности
            Point ringsCenter = new Point(80, 350);
            double[] radii = { 40, 30, 20 };
            foreach (var r in radii)
            {
                dc.DrawEllipse(null, new Pen(Brushes.Black, 2), ringsCenter, r, r);
            }

            // 2. Четыре перекрывающихся квадрата по диагонали
            double squareSize = 40;
            for (int i = 0; i < 4; i++)
            {
                double offset = i * (squareSize / 2);
                dc.DrawRectangle(null, new Pen(Brushes.Black, 1), new Rect(180 + offset, 320 + offset, squareSize, squareSize));
            }

            // 3. Шахматная доска 8x8
            double boardX = 300;
            double boardY = 320;
            double cell = 30;
            int n = 8;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if ((row + col) % 2 == 0)
                        continue;
                    dc.DrawRectangle(Brushes.Black, null, new Rect(boardX + col * cell, boardY + row * cell, cell, cell));
                }
            }
            
            dc.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(boardX, boardY, n * cell, n * cell));
        }
    }
}