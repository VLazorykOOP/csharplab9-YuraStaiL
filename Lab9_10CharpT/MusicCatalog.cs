using System.Collections;

namespace Lab9_10CharpT
{
    public class MusicCatalog
    {
        private Hashtable discs;

        public MusicCatalog()
        {
            discs = new Hashtable();
        }

        public void AddMusicCD(MusicCD cd)
        {
            discs.Add(cd.Title, cd);
        }

        public void RemoveMusicCD(string cdTitle)
        {
            discs.Remove(cdTitle);
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("Каталог музичних дисків:");
            foreach (MusicCD cd in discs.Values)
            {
                cd.DisplayContents();
                Console.WriteLine();
            }
        }

        public ArrayList FindSongsByArtist(string artist)
        {
            ArrayList matchingSongs = new ArrayList();
            foreach (MusicCD cd in discs.Values)
            {
                ArrayList songs = cd.FindSongsByArtist(artist);
                matchingSongs.AddRange(songs);
            }
            return matchingSongs;
        }
    }
}
