using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private string[] regions = {
            "Брестская",
            "Витебская",
            "Гомельская",
            "Гродненская",
            "Минская",
            "Могилевская"
        };
        public Form1()
        {
            InitializeComponent();

            int currentYear = DateTime.Now.Year;

            for (int i = 0; i <= 31; i++)
            {
                cbDay.Items.Add(i);
            }

            for (int i = 1950; i <= currentYear; i++)
            {
                cbYear.Items.Add(i);
            }

            string[] months =
            {
                "Январь", "Февраль", "Март", "Апрель",
                "Май", "Июнь", "Июль", "Август",
                "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };
            cbMonth.Items.AddRange(months);

            cbRegion.Items.AddRange(regions);

        }

        private void btSave_Click(object sender, EventArgs e)
        {

     
            string data = "=== Анкетные данные сотрудника ===\r\n";
            data += $"ФИО: {txtLastName.Text} {Label2.Text} {txtMiddleName.Text}\r\n";
           
            data += $"Пол: {(rbMale.Checked ? "Мужской" : "Женский")}\r\n";

            data += $"Дата рождения: {cbDay.Text} {cbMonth.Text} {cbYear.Text}\r\n";
            
            data += $"Email: {txtEmail.Text}\r\n";
            data += $"Телефон: {cbOperator.Text} {txtPhone.Text}\r\n";

            
            data += $"Область: {cbRegion.Text}\r\n";

            
            string experience = "";
            if (rbNoExp.Checked) experience = "Без опыта";
            else if (rbLess1.Checked) experience = "Менее 1 года";
            else if (rb1to5.Checked) experience = "1-5 лет";
            else if (rb5plus.Checked) experience = "Более 5 лет";
            data += $"Опыт работы: {experience}\r\n";

            data += $"Ожидаемая зарплата: от {nudSalaryFrom.Value} до {nudSalaryTo.Value}\r\n";

            data += $"\nКраткое резюме:\r\n{txtResume.Text}\r\n";

            string fileName = $"{txtLastName.Text}_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";

            File.WriteAllText(fileName, data, Encoding.UTF8);

            MessageBox.Show("Данные успешно сохранены в файл:\n" + fileName,
                           "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtResume.Clear();

            cbDay.SelectedIndex = -1;
            cbMonth.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            cbRegion.SelectedIndex = -1;
            cbOperator.SelectedIndex = -1;

            rbMale.Checked = true;
            rbWoman.Checked = false;

            rbNoExp.Checked = true;
            rbLess1.Checked = false;
            rb1to5.Checked = false;
            rb5plus.Checked = false;

            nudSalaryFrom.Value = nudSalaryFrom.Minimum;
            nudSalaryTo.Value = nudSalaryTo.Minimum;

            MessageBox.Show("Форма очищена!", "Очистка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
