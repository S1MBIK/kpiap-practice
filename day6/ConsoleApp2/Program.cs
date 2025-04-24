namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст");
            string text = Console.ReadLine();

            Console.WriteLine("введите длинну n слов");
            int n = int.Parse(Console.ReadLine());
            
            PrintWord(text, n);
        }

        static void PrintWord(string text, int n)
        {
            string[] words = text.Split(' ');
            Array.Sort(words);

            Console.WriteLine($"слова длинной {n} в алфавитном порядке");
            foreach( string word in words )
            {
                if (word.Length == n)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
