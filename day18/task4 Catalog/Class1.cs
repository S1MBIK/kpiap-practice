using System;
using System.Collections;

public class Catalog
{
    private Hashtable cds;

    public Catalog()
    {
        cds = new Hashtable();
    }

    public void AddCD(string title)
    {
        if (!cds.ContainsKey(title))
        {
            cds[title] = new MusicCD(title);
            Console.WriteLine($"CD '{title}' added.");
        }
        else
        {
            Console.WriteLine($"CD '{title}' already exists.");
        }
    }

    public void RemoveCD(string title)
    {
         cds.Remove(title);
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("Music CD Catalog:");
        foreach (DictionaryEntry entry in cds)
        {
            Console.WriteLine($"- {entry.Key}");
        }
    }

    public MusicCD GetCD(string title)
    {
        return cds[title] as MusicCD; 
    }
}