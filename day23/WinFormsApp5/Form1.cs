using System;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private int[] numbers = new int[20];
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = random.Next(-100, 101);
                listBox1.Items.Add(numbers[i]);
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
                maxIndex = maxIndex = i;
        }

        
        int temp = numbers[0];
        numbers[0] = numbers[maxIndex];
        numbers[maxIndex] = temp;

       
        listBox1.Items.Clear();
        foreach (int number in numbers)
        {
            listBox1.Items.Add(number);
        }

        labelResult.Text = $"Максимальный элемент {numbers[0]} перемещен в начало";
    }
    }
}
