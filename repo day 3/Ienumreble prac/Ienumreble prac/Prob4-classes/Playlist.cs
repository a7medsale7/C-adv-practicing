using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumreble_prac 
{
    class Playlist : IEnumerable
    {
        private List<Song> songs;
        public void Add(Song song)
        {
            if (songs == null)
            {
                songs = new List<Song>();
            }
            songs.Add(song);
        }
        public IEnumerator GetEnumerator()
        {
            return songs.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void display()
        {
            foreach (var song in songs)
            {
                Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}");
            }
        }


    }
}
