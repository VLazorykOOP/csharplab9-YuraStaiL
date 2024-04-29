using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class MusicCD
    {
        public string Title { get; set; }
        private Hashtable songs;

        public MusicCD(string title)
        {
            Title = title;
            songs = new Hashtable();
        }

        public void AddSong(Song song)
        {
            songs.Add(song.Title, song);
        }

        public void RemoveSong(string songTitle)
        {
            songs.Remove(songTitle);
        }

        public void DisplayContents()
        {
            Console.WriteLine($"Музичний диск \"{Title}\":");
            foreach (Song song in songs.Values)
            {
                Console.WriteLine($"{song.Title} - {song.Artist}");
            }
        }

        public ArrayList FindSongsByArtist(string artist)
        {
            ArrayList matchingSongs = new ArrayList();
            foreach (Song song in songs.Values)
            {
                if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                {
                    matchingSongs.Add(song);
                }
            }
            return matchingSongs;
        }
    }
}
