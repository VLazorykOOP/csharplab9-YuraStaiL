using System.Collections;

namespace Lab9_10CharpT
{
    public class Lab9T4
    {
        public void Run()
        {
            Console.WriteLine("\tTask 4");
            MusicCatalog catalog = new MusicCatalog();

            MusicCD cd1 = new MusicCD("Хіти 2022");
            cd1.AddSong(new Song("Bad Habit", "Steve Lacy"));
            cd1.AddSong(new Song("Phonk", "Japan Li"));
            cd1.AddSong(new Song("Зима", "KLAVDIA PETRIVNA"));
            catalog.AddMusicCD(cd1);

            MusicCD cd2 = new MusicCD("Хіти 2023");
            cd2.AddSong(new Song("Я тобі брехала", "KLAVDIA PETRIVNA"));
            cd2.AddSong(new Song("Знайди мене", "KLAVDIA PETRIVNA"));
            catalog.AddMusicCD(cd2);

            catalog.DisplayCatalog();

            Console.WriteLine("Пошук пісень виконавця 'KLAVDIA PETRIVNA':");
            ArrayList songsByArtistC = catalog.FindSongsByArtist("KLAVDIA PETRIVNA");
            foreach (Song song in songsByArtistC)
            {
                Console.WriteLine($"{song.Title} - {song.Artist}");
            }
        }
    }
}
