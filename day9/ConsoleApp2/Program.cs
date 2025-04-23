using System;

enum Post
{
    JuniorDeveloper = 160,
    Developer = 180,
    SeniorDeveloper = 200,
    Manager = 220,
    Director = 240
}

class Accountant
{
    public bool AskForBonus(Post worker, int hours)
    {
        return hours > (int)worker;
    }
}

class Program
{
    static void Main()
    {
        Accountant accountant = new Accountant();

        Console.WriteLine("Выберите должность сотрудника:");
        foreach (var post in Enum.GetValues(typeof(Post)))
        {
            Console.WriteLine($"{(int)post}. {post}");
        }

        Console.Write("Введите номер должности: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (!Enum.IsDefined(typeof(Post), choice))
        {
            Console.WriteLine("Некорректный выбор. Программа завершена.");
            return;
        }

        Post worker = (Post)choice; 

        Console.WriteLine("Введите количество отработанных часов: ");
        int hoursWorked = Convert.ToInt32(Console.ReadLine());

        bool bonusEligible = accountant.AskForBonus(worker, hoursWorked);

        if (bonusEligible)
        {
            Console.WriteLine("Сотруднику положена премия.");
        }
        else
        {
            Console.WriteLine("Сотруднику премия не положена.");
        }
    }
}