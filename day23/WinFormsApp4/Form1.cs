namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем координаты
            if (!int.TryParse(textBoxX.Text, out int x) || !int.TryParse(textBoxY.Text, out int y))
            {
                MessageBox.Show("Введите корректные координаты!");
                return;
            }

            // Получаем букву и создаем соответствующий элемент
            string letter = textBoxLetter.Text.ToUpper();
            Control newControl = null;

            switch (letter)
            {
                case "К":
                    Button newButton = new Button();
                    newButton.Text = "Новая кнопка";
                    newButton.Size = new Size(100, 30);
                    newButton.BackColor = Color.LightBlue;
                    newControl = newButton;
                    break;

                case "П":
                    TextBox newTextBox = new TextBox();
                    newTextBox.Text = "Новое поле";
                    newTextBox.Size = new Size(100, 20);
                    newTextBox.BackColor = Color.LightGreen;
                    newControl = newTextBox;
                    break;

                case "М":
                    Label newLabel = new Label();
                    newLabel.Text = "Новая метка";
                    newLabel.AutoSize = true;
                    newLabel.BackColor = Color.LightPink;
                    newControl = newLabel;
                    break;

                default:
                    MessageBox.Show("Введите К, П или М!");
                    return;
            }

            if (newControl != null)
            {
                newControl.Location = new Point(x, y);
                newControl.MouseEnter += (s, ev) => Controls.Remove(s as Control);
                Controls.Add(newControl);
            }
        }
    }
}
