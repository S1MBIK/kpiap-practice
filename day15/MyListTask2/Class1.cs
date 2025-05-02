using System;

public class MyDictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public MyDictionary()
    {
        keys = new TKey[4];   
        values = new TValue[4]; 
        count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            Resize();
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }

    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<TKey>.Default.Equals(keys[i], key))
                {
                    return values[i];
                }
            }
            throw new KeyNotFoundException("Ключ не найден.");
        }
    }

    public int Count
    {
        get { return count; }
    }

    private void Resize()
    {
        TKey[] newKeys = new TKey[keys.Length * 2];
        TValue[] newValues = new TValue[values.Length * 2];
        Array.Copy(keys, newKeys, keys.Length);
        Array.Copy(values, newValues, values.Length);
        keys = newKeys;
        values = newValues;
    }
}