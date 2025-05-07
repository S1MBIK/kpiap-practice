using System.Collections;

public class MusicCD
{
    public string Title { get; set; }
    public Hashtable Songs { get; private set; }

    public MusicCD(string title)
    {
        Title = title;
        Songs = new Hashtable();
    }

    public void AddSong(string key, Song song)
    {
        Songs[key] = song; 
    }

    public void RemoveSong(string key)
    {
         Songs.Remove(key); 
    }

    public void DisplaySongs()
    {
        System.Console.WriteLine($"Songs in '{Title}':");
        foreach (DictionaryEntry entry in Songs)
        {
            System.Console.WriteLine(entry.Value);
        }
    }
}