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
            
               
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double z = double.Parse(textBox3.Text);
                double f = double.Parse(textBox4.Text);

                double part1 = Math.Pow(y, x + 1) / (Math.Pow(Math.Abs(y - 2), 1.0 / 3.0) + 3);

                double part2 = ((x + y) / 2) / Math.Abs(2 * x + y) * Math.Pow(x + 1, -1 / Math.Sin(z));

                double g = part1 + part2;

                
                textBox5.Text = g.ToString("F2");
           
          
        }
    }
}
