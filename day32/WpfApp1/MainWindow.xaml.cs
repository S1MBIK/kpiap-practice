using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.IO;
using System.Collections.Generic;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataSet dataSet;
        private const string DataFileName = "database.xml";

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            FillTableSelector();
        }

        private void LoadData()
        {
            if (File.Exists(DataFileName))
            {
                try
                {
                    dataSet = new DataSet();
                    dataSet.ReadXml(DataFileName);
                }
                catch
                {
                    CreateAndBindData();
                }
            }
            else
            {
                CreateAndBindData();
            }
            myDataGrid.ItemsSource = dataSet.Tables[0].DefaultView;
        }

        private void SaveData()
        {
            try
            {
                dataSet.WriteXml(DataFileName);
                MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CreateAndBindData()
        {
            dataSet = new DataSet("MyDatabase");

            DataTable customersTable = new DataTable("Customers");
            DataColumn custIdCol = new DataColumn("Id", typeof(int));
            custIdCol.AutoIncrement = true;
            custIdCol.AutoIncrementSeed = 1;
            custIdCol.AutoIncrementStep = 1;
            customersTable.Columns.Add(custIdCol);
            customersTable.Columns.Add("Name", typeof(string));
            customersTable.Columns.Add("Email", typeof(string));
            customersTable.Rows.Add(null, "Иван Иванов", "ivanov@mail.ru");
            customersTable.Rows.Add(null, "Петр Петров", "petrov@mail.ru");
            dataSet.Tables.Add(customersTable);

            DataTable ordersTable = new DataTable("Orders");
            DataColumn orderIdCol = new DataColumn("OrderId", typeof(int));
            orderIdCol.AutoIncrement = true;
            orderIdCol.AutoIncrementSeed = 1;
            orderIdCol.AutoIncrementStep = 1;
            ordersTable.Columns.Add(orderIdCol);
            ordersTable.Columns.Add("CustomerId", typeof(int));
            ordersTable.Columns.Add("OrderDate", typeof(DateTime));
            ordersTable.Rows.Add(null, 1, DateTime.Now.AddDays(-2));
            ordersTable.Rows.Add(null, 2, DateTime.Now.AddDays(-1));
            ordersTable.Rows.Add(null, 1, DateTime.Now);
            dataSet.Tables.Add(ordersTable);

            DataRelation relation = new DataRelation(
                "CustomerOrders",
                customersTable.Columns["Id"],
                ordersTable.Columns["CustomerId"]);
            dataSet.Relations.Add(relation);

            myDataGrid.ItemsSource = customersTable.DefaultView;
        }

        private void FillTableSelector()
        {
            tableSelector.Items.Clear();
            foreach (DataTable table in dataSet.Tables)
            {
                tableSelector.Items.Add(table.TableName);
            }
            tableSelector.SelectedIndex = 0;
        }

        private void tableSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tableSelector.SelectedItem != null)
            {
                string selectedTable = tableSelector.SelectedItem.ToString();
                myDataGrid.ItemsSource = dataSet.Tables[selectedTable].DefaultView;

                
                if (selectedTable == "Customers")
                {
                    customerFields.Visibility = Visibility.Visible;
                    orderFields.Visibility = Visibility.Collapsed;
                }
                else if (selectedTable == "Orders")
                {
                    customerFields.Visibility = Visibility.Collapsed;
                    orderFields.Visibility = Visibility.Visible;
                }
                else
                {
                    customerFields.Visibility = Visibility.Collapsed;
                    orderFields.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (tableSelector.SelectedItem != null)
            {
                string selectedTable = tableSelector.SelectedItem.ToString();
                DataTable table = dataSet.Tables[selectedTable];
                DataRow newRow = table.NewRow();

                if (selectedTable == "Customers")
                {
                    newRow["Name"] = nameBox.Text;
                    newRow["Email"] = emailBox.Text;
                }
                else if (selectedTable == "Orders")
                {
                    int custId = 0;
                    DateTime orderDate = DateTime.Now;
                    int.TryParse(customerIdBox.Text, out custId);
                    DateTime.TryParse(orderDateBox.Text, out orderDate);
                    newRow["CustomerId"] = custId;
                    newRow["OrderDate"] = orderDate;
                }
                table.Rows.Add(newRow);
                SaveData();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (myDataGrid.SelectedItem is DataRowView rowView)
            {
                rowView.Row.Delete();
                SaveData();
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (myDataGrid.SelectedItem is DataRowView rowView)
            {
                DataTable table = rowView.Row.Table;
                foreach (DataColumn col in table.Columns)
                {
                    if (col.DataType == typeof(string))
                    {
                        rowView.Row[col] = "Изменено";
                        break;
                    }
                }
                SaveData();
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (tableSelector.SelectedItem != null)
            {
                string selectedTable = tableSelector.SelectedItem.ToString();
                DataTable table = dataSet.Tables[selectedTable];
                var filters = new List<string>();
                string searchText = searchBox.Text.Trim();

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    if (selectedTable == "Customers")
                    {
                        filters.Add($"Name LIKE '%{searchText.Replace("'", "''")}%' OR Email LIKE '%{searchText.Replace("'", "''")}%'");
                    }
                    else if (selectedTable == "Orders")
                    {
                        if (int.TryParse(searchText, out int customerId))
                        {
                            filters.Add($"CustomerId = {customerId}");
                        }
                        else if (DateTime.TryParse(searchText, out DateTime orderDate))
                        {
                            filters.Add($"OrderDate = '{orderDate:yyyy-MM-dd}'");
                        }
                        else
                        {
                            filters.Add($"Convert(CustomerId, 'System.String') LIKE '%{searchText.Replace("'", "''")}%'");
                        }
                    }
                }

                if (myDataGrid.ItemsSource is DataView view)
                {
                    view.RowFilter = filters.Count > 0 ? string.Join(" AND ", filters) : "";
                }
            }
        }

        private void clearSearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (myDataGrid.ItemsSource is DataView view)
            {
                view.RowFilter = "";
            }
            searchBox.Text = "";
            nameBox.Text = "";
            emailBox.Text = "";
            customerIdBox.Text = "";
            orderDateBox.Text = "";
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveData();
        }
    }
}