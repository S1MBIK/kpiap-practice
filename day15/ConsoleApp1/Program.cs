using System;

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);

        Console.WriteLine($"Количество элементов: {myList.Count}");

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine($"Элемент по индексу {i}: {myList[i]}");
        }
    }
}