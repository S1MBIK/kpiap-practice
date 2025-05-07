using System;
using System.Collections.Generic;

public class Prototype<T> where T : class, new()
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    public List<T> Clone()
    {
        List<T> clones = new List<T>();
        foreach (var item in items)
        {
            if (item is ICloneable cloneable)
            {
                clones.Add((T)cloneable.Clone());
            }
        }
        return clones;
    }

    public void Display()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}