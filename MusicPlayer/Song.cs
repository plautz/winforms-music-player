using System;

namespace MusicPlayer
{
    /// <summary>
    /// Represents a song
    /// </summary>
    [Serializable]
    public class Song
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Mp3Path { get; set; }
        public string ArtworkPath { get; set; }
    }
}
