using System;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using WpfApp1.Data;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductDataContext _context;
        private Product _selectedProduct;

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ProductsConnection"].ConnectionString;
                _context = new ProductDataContext(connectionString);
                
                // Попытка создать базу данных, если она не существует
                if (!_context.DatabaseExists())
                {
                    _context.CreateDatabase();
                }

                LoadData();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка SQL при инициализации: {sqlEx.Message}", "Ошибка базы данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ConfigurationErrorsException configEx)
            {
                MessageBox.Show($"Ошибка конфигурации: {configEx.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка при инициализации: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                if (_context != null && _context.DatabaseExists())
                {
                    dgProducts.ItemsSource = _context.Products.ToList();
                }
                else
                {
                    MessageBox.Show("База данных не инициализирована или не существует.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка SQL при загрузке данных: {sqlEx.Message}", "Ошибка базы данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (_context == null)
                {
                    MessageBox.Show("База данных не инициализирована.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var product = new Product
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text)
                };

                _context.Products.InsertOnSubmit(product);
                _context.SubmitChanges();
                LoadData();
                ClearInputs();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка SQL при добавлении данных: {sqlEx.Message}", "Ошибка базы данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_selectedProduct == null)
                {
                    MessageBox.Show("Пожалуйста, выберите товар для обновления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (_context == null)
                {
                    MessageBox.Show("База данных не инициализирована.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                _selectedProduct.Name = txtName.Text;
                _selectedProduct.Price = decimal.Parse(txtPrice.Text);
                _selectedProduct.Quantity = int.Parse(txtQuantity.Text);

                _context.SubmitChanges();
                LoadData();
                ClearInputs();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка SQL при обновлении данных: {sqlEx.Message}", "Ошибка базы данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_selectedProduct == null)
                {
                    MessageBox.Show("Пожалуйста, выберите товар для удаления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Проверяем, что _context инициализирован
                if (_context == null)
                {
                    MessageBox.Show("База данных не инициализирована.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                var result = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    _context.Products.DeleteOnSubmit(_selectedProduct);
                    _context.SubmitChanges();
                    LoadData();
                    ClearInputs();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка SQL при удалении данных: {sqlEx.Message}", "Ошибка базы данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgProducts_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
                _selectedProduct = dgProducts.SelectedItem as Product;
            if (_selectedProduct != null)
            {
                txtName.Text = _selectedProduct.Name;
                txtPrice.Text = _selectedProduct.Price.ToString();
                txtQuantity.Text = _selectedProduct.Quantity.ToString();
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            _selectedProduct = null;
        }
    }
}