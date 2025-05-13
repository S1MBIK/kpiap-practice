namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double z = double.Parse(txtZ.Text);


            double fx;
            if (rbSinh.Checked)
                fx = Math.Sinh(x);
            else if (rbSquare.Checked)
                fx = x * x;
            else
                fx = Math.Exp(x);


            double minValue = Math.Min(fx, y);
            double maxValue = Math.Max(y, z);
            double p = (minValue - maxValue) / 2;


            Result.Text = p.ToString("F5");
        }

       
    }
}
