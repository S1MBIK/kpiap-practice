namespace ConsoleApp5
{
    /// <summary>
    /// Основной класс программы для работы с файлами и числовыми последовательностями
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу. Создает два файла с четными и нечетными числами,
        /// затем объединяет их в третий файл с сортировкой по возрастанию
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main(string[] args)
        {
            string file1Path = "f1.txt";
            string file2Path = "f2.txt";
            string file3Path = "f3.txt";

            using (StreamWriter streamWriter = new StreamWriter(file1Path))
            {

                for (int i = 0; i < 10; i++)
                {
                    streamWriter.WriteLine(i * 2);
                }
            } 
            
            using (StreamWriter streamWriter = new StreamWriter(file2Path))
            {

                for (int i = 0; i < 10; i++)
                {
                    streamWriter.WriteLine(i * 2 + 1);
                }
            }
           
            var numbers1 = File.ReadAllLines(file1Path).Select(int.Parse).ToList();
            var numbers2 = File.ReadAllLines(file2Path).Select(int.Parse).ToList();

            var union = numbers1.Concat(numbers2).OrderBy(n => n).ToList();

            File.WriteAllLines(file3Path,union.Select(n => n.ToString()));

            Console.WriteLine($"Файлы '{file1Path}' и '{file2Path}' объединены в '{file3Path}' и отсортированы.");

        }
    }
}
