using System;

class Program
{
    static void Main()
    {
        try
        {
            MyInfo myInfo = new MyInfo();

            myInfo.NameChanged += (sender, newName) =>
            {
                Console.WriteLine($"Имя было изменено на: {newName}");
            };

            
            myInfo.Name = "Иван";

            myInfo.Name = "";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Обработка исключения: {ex.Message}");
        }
    }
}