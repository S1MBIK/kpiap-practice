using System;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private double[] numbers = new double[15];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 15; i++) 
            {
            
                numbers[i] = random.NextDouble() * 200 - 100;
                listBox1.Items.Add(numbers[i].ToString("F2")); 
            }
            labelResult.Text = "";
        }

        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Сначала заполните массив!");
                return;
            }

            
            int maxIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                    maxIndex = i;
            }

            
            double temp = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = numbers[maxIndex];
            numbers[maxIndex] = temp;

            
            listBox1.Items.Clear();
            foreach (double number in numbers)
            {
                listBox1.Items.Add(number.ToString("F2"));
            }

            labelResult.Text = $"Максимальный элемент {numbers[numbers.Length - 1]:F2} перемещен в конец";
        }
    }
}
