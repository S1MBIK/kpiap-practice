using System;

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        // Добавляем компакт-диски
        catalog.AddCD("Greatest Hits");
        catalog.AddCD("Chill Vibes");

        // Добавляем песни
        var cd = catalog.GetCD("Greatest Hits");
        cd.AddSong("1", new Song { Title = "Song A", Artist = "Artist 1" });
        cd.AddSong("2", new Song { Title = "Song B", Artist = "Artist 2" });

        cd = catalog.GetCD("Chill Vibes");
        cd.AddSong("1", new Song { Title = "Song C", Artist = "Artist 3" });
        cd.AddSong("2", new Song { Title = "Song D", Artist = "Artist 4" });

        // Просмотр каталога
        catalog.DisplayCatalog();

        // Просмотр содержимого диска
        cd = catalog.GetCD("Greatest Hits");
        cd.DisplaySongs();

        // Удаляем песню
        cd.RemoveSong("1");
        Console.WriteLine("\nAfter removing a song:");
        cd.DisplaySongs();

        // Удаляем компакт-диск
        catalog.RemoveCD("Chill Vibes");
        Console.WriteLine("\nAfter removing 'Chill Vibes':");
        catalog.DisplayCatalog();
    }
}