using System;

namespace ColorDelegateExample
{
    public delegate string ColorDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            ColorDelegate colorDelegate = GetRedColor;
            colorDelegate += GetGreenColor;
            colorDelegate += GetBlueColor;

            CallColorMethods(colorDelegate);
        }

        static void CallColorMethods(ColorDelegate colorDelegate)
        {
            try
            {
                foreach (var color in colorDelegate.GetInvocationList())
                {
                    Console.WriteLine(color.DynamicInvoke());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        static string GetRedColor()
        {
            return "Красный";
        }

        static string GetGreenColor()
        {
            return "Зеленый";
        }

        static string GetBlueColor()
        {
            return "Синий";
        }
    }
}