using System;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private int[] numbers = new int[10]; // Изменено на 10 элементов
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++) // Изменено на 10 элементов
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

            // Поиск минимального элемента
            int minIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                    minIndex = i;
            }

            // Обмен с последним элементом
            int temp = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = numbers[minIndex];
            numbers[minIndex] = temp;

            // Обновление ListBox
            listBox1.Items.Clear();
            foreach (int number in numbers)
            {
                listBox1.Items.Add(number);
            }

            labelResult.Text = $"Минимальный элемент {numbers[numbers.Length - 1]} перемещен в конец";
        }
    }
}

