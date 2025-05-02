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

        int[] array = myList.GetArray();

        Console.WriteLine("Элементы массива:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}