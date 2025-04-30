using System;

class Program
{
    static void Main()
    {
        try
        {
            NameManager nameManager = new NameManager();
            FirstObserver firstObserver = new FirstObserver();
            SecondObserver secondObserver = new SecondObserver();

            Console.WriteLine("Добавляем обработчики событий:");
            nameManager.NameChanged += firstObserver.ReactToNameChange;
            nameManager.NameChanged += firstObserver.ReactToNameChangeAlternative;
            nameManager.NameChanged += secondObserver.ReactToNameChange;

            Console.WriteLine("\nИзменяем имя на 'Иван':");
            nameManager.Name = "Иван";

            Console.WriteLine("\nУдаляем один обработчик из первого наблюдателя:");
            nameManager.NameChanged -= firstObserver.ReactToNameChange;

            Console.WriteLine("\nИзменяем имя на 'Петр':");
            nameManager.Name = "Петр";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Обработка исключения: {ex.Message}");
        }
    }
}