using System;

public class MyInfo
{
    private string _name;

    public event EventHandler<string> NameChanged;

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
        NameChanged?.Invoke(this, newName);
    }
}