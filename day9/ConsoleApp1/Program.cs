using System;

struct NOTE
{
    public string LastName;
    public string FirstName;
    public string PhoneNumber;
    public int[] BirthDate; 

    public NOTE(string lastName, string firstName, string phoneNumber, int day, int month, int year)
    {
        LastName = lastName;
        FirstName = firstName;
        PhoneNumber = phoneNumber;
        BirthDate = new int[] { day, month, year };
    }
}

class Program
{
    static void Main()
    {
        NOTE[] notes = new NOTE[2];

        
        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine($"Введите данные для записи {i + 1}:");
            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine();
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Номер телефона: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Дата рождения (день, месяц, год): ");
            string[] dateParts = Console.ReadLine().Split(',');

            int day = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int year = int.Parse(dateParts[2]);

            notes[i] = new NOTE(lastName, firstName, phoneNumber, day, month, year);
        }

        Array.Sort(notes, (x, y) => x.PhoneNumber.Substring(0, 3).CompareTo(y.PhoneNumber.Substring(0, 3)));

        Console.Write("Введите фамилию для поиска: ");
        string searchLastName = Console.ReadLine();
        bool found = false;

        foreach (var note in notes)
        {
            if (note.LastName.Equals(searchLastName, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                Console.WriteLine($"Найдено: {note.FirstName} {note.LastName}, Телефон: {note.PhoneNumber}, Дата рождения: {note.BirthDate[0]}.{note.BirthDate[1]}.{note.BirthDate[2]}");
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Запись не найдена.");
        }
    }
}