using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using WpfApp1.Models;

namespace WpfApp1.Data
{
    [Database]
    public class ProductDataContext : DataContext
    {
        public ProductDataContext(string connectionString) : base(connectionString)
        {
            if (!this.DatabaseExists())
            {
                CreateDatabase();
            }
        }

        public Table<Product> Products;

        public new bool DatabaseExists()
        {
            try
            {
                return base.DatabaseExists();
            }
            catch
            {
                return false;
            }
        }
    }
} 