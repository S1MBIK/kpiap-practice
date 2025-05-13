using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double start = (double)numericUpDownStart.Value;
            double end = (double)numericUpDownEnd.Value;
            double step = (double)numericUpDownStep.Value;

            chart1.Series[0].Points.Clear();

            for (double x = start; x <= end; x += step)
            {
                double y = Math.Exp(x);
                chart1.Series[0].Points.AddXY(x, y);
            }


            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].Color = Color.Blue;


            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;


            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].MarkerSize = 5;
        }

        private void numericUpDownStep_ValueChanged(object sender, EventArgs e)
        {
                
        }
    }
}
