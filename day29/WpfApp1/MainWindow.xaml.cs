using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
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

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Анимация движения облаков по горизонтали
            var cloudsAnimation = new DoubleAnimation
            {
                From = 0,
                To = 500, // смещение вправо
                Duration = new Duration(TimeSpan.FromSeconds(3)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            CloudsImage.BeginAnimation(Canvas.LeftProperty, cloudsAnimation);

            // Анимация движения по горизонтали для самолёта
            var animation = new DoubleAnimation
            {
                From = 0,
                To = 700,
                Duration = new Duration(TimeSpan.FromSeconds(3)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            PlaneImage.BeginAnimation(Canvas.LeftProperty, animation);

            // Анимация появления/исчезновения текста баннера
            var textAnimation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            BannerText.BeginAnimation(TextBlock.OpacityProperty, textAnimation);
        }
    }
}