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

        
        Post worker = Post.Developer;
        Console.WriteLine("введите времмя сотрудника");
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