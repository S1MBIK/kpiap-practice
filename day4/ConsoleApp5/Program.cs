using System.ComponentModel;
using System.Security.AccessControl;

namespace ConsoleApp5
{
    internal class Program
    {

        public class product
        {
            private int count;
            private double price;
            private string name;

            public product()
            {
                count = 1;
                price = 2.40;
                name = "кукуруза";
            }
            public product(int count, double price, string name)
            {
                this.count = count;
                this.price = price;
                this.name = name;
            }
            public int Count
            { get { return count; } }
            public double Price
            { get { return price; } }
            public string Name
            {
                get { return name; }
            }

            public string DisplayInfo()
            {
                return $"Цена: {price} byn, количество: {count}, название товара: {name}";
            }
            static void Main(string[] args)
            {
                product product1 = new product();
                product product2 = new product(2,4.50,"береза");

                Console.WriteLine(product1.DisplayInfo());
                Console.WriteLine(product2.DisplayInfo());

                if (product1.count> product2.count)
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
