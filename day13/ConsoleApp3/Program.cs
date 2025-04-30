using System;

class Program
{
    static void Main()
    {
        try
        {
            MyInfo myInfo = new MyInfo();

            // Подписываемся на событие
            myInfo.NameChanged += (sender, newName) =>
            {
                Console.WriteLine($"Имя было изменено на: {newName}");
            };

            // Устанавливаем имя
            myInfo.Name = "Иван";

            // Пробуем установить пустое имя (вызовет исключение)
            myInfo.Name = "";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Обработка исключения: {ex.Message}");
        }
    }
}