
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                string result = selectedText.Replace('А', '*');
                lbResult.Text = "Результат: " + result;
            }
            else
            {
                lbResult.Text = "Пожалуйста, выберите строку из списка";
            }
        }
    }
}
