using System.ComponentModel;
using System.Security.AccessControl;

namespace ConsoleApp5
{
    /// <summary>
    /// Основной класс программы
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Класс для представления продукта
        /// </summary>
        public class product
        {
            /// <summary>
            /// Количество продукта
            /// </summary>
            private int count;
            
            /// <summary>
            /// Цена продукта
            /// </summary>
            private double price;
            
            /// <summary>
            /// Название продукта
            /// </summary>
            private string name;

            /// <summary>
            /// Создает новый экземпляр продукта с значениями по умолчанию
            /// </summary>
            public product()
            {
                count = 1;
                price = 2.40;
                name = "кукуруза";
            }
            
            /// <summary>
            /// Создает новый экземпляр продукта с указанными параметрами
            /// </summary>
            /// <param name="count">Количество продукта</param>
            /// <param name="price">Цена продукта</param>
            /// <param name="name">Название продукта</param>
            public product(int count, double price, string name)
            {
                this.count = count;
                this.price = price;
                this.name = name;
            }
            
            /// <summary>
            /// Получает количество продукта
            /// </summary>
            public int Count
            { get { return count; } }
            
            /// <summary>
            /// Получает цену продукта
            /// </summary>
            public double Price
            { get { return price; } }
            
            /// <summary>
            /// Получает название продукта
            /// </summary>
            public string Name
            {
                get { return name; }
            }

            /// <summary>
            /// Возвращает информацию о продукте в виде строки
            /// </summary>
            /// <returns>Строка с информацией о продукте</returns>
            public string DisplayInfo()
            {
                return $"Цена: {price} byn, количество: {count}, название товара: {name}";
            }
            
            /// <summary>
            /// Точка входа в программу
            /// </summary>
            /// <param name="args">Аргументы командной строки</param>
            static void Main(string[] args)
            {
                product product1 = new product();
                product product2 = new product(2, 4.50, "береза");

                Console.WriteLine(product1.DisplayInfo());
                Console.WriteLine(product2.DisplayInfo());

                if (product1.count > product2.count)
                {
                    Console.WriteLine($"продукта {product1.Name} больше чем {product2.Name}"); 
                }
                else if (product2.Count < product1.Count)
                {
                    Console.WriteLine($"продукта {product1.Name} меньше чем {product2.Name}");
                }
                else
                {
                    Console.WriteLine($" {product1.Name} и {product2.Name} одинаковове количество");
                }
            }
        }
    }
}
