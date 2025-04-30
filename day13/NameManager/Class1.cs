using System;

public delegate void NameChangeHandler(string newName);

public class NameManager
{
    private string _name;

    public event NameChangeHandler NameChanged;

    public string Name
    {
        get => _name;
        set
        {
            try
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Имя не может быть пустым или содержать только пробелы");
                }

                if (_name != value)
                {
                    _name = value;
                    OnNameChanged(value);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                throw;
            }
        }
    }

    protected virtual void OnNameChanged(string newName)
    {
        NameChanged?.Invoke(newName);
    }
}

public class FirstObserver
{
    public void ReactToNameChange(string newName)
    {
        Console.WriteLine($"Первый наблюдатель: Имя изменено на {newName}");
    }

    public void ReactToNameChangeAlternative(string newName)
    {
        Console.WriteLine($"Первый наблюдатель (альтернативный метод): Новое имя - {newName}");
    }
}

public class SecondObserver
{
    public void ReactToNameChange(string newName)
    {
        Console.WriteLine($"Второй наблюдатель: Получено новое имя: {newName}");
    }
}