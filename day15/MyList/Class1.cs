using System;

public class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4]; 
        count = 0;
    }

    
    public void Add(T item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count] = item;
        count++;
    }

    
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Индекс вне диапазона.");
            }
            return items[index];
        }
    }

   
    public int Count
    {
        get { return count; }
    }

    
    private void Resize()
    {
        T[] newArray = new T[items.Length * 2];
        Array.Copy(items, newArray, items.Length);
        items = newArray;
    }
}