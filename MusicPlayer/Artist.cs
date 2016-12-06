using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    /// <summary>
    /// Represents an artist with a name and list of songs
    /// </summary>
    [Serializable]
    public class Artist
    {
        public string Name { get; set; }
        private List<Song> songs = new List<Song>();
        public List<Song> Songs { get { return songs; } }

        public Artist()
        {
            Name = "Artist Name";
        }

        public void AddSong(Song newSong)
        {
            songs.Add(newSong);
        }
    }
}
