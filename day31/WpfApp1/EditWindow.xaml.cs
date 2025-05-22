using System.Data;
using System.Windows;

namespace WpfApp1;

/// <summary>
/// Interaction logic for EditWindow.xaml
/// </summary>
public partial class EditWindow : Window
{
    private readonly DataRow row;

    public EditWindow(DataRow row)
    {
        InitializeComponent();
        this.row = row;
        LoadData();
    }

    private void LoadData()
    {
        if (row.Table.Columns.Contains("Name"))
            txtName.Text = row["Name"]?.ToString();
        if (row.Table.Columns.Contains("Age"))
            txtAge.Text = row["Age"]?.ToString();
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Введите имя!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        if (!int.TryParse(txtAge.Text, out int age) || age < 0)
        {
            MessageBox.Show("Введите корректный возраст!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        if (row.Table.Columns.Contains("Name"))
            row["Name"] = txtName.Text;
        if (row.Table.Columns.Contains("Age"))
            row["Age"] = age;

        DialogResult = true;
        Close();
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }
} 