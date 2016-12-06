using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SongForm : Form
    {
        private BindingList<Artist> bindingArtists;
        private Song song;
        public Song Song
        {
            get { return song; }
        }

        private bool new_song_form;

        private char[] whitespace = { ' ' };

        /// <summary>
        /// Initialize blank form
        /// </summary>
        private void Initialize()
        {
            InitializeComponent();
            CenterContent();
        }

        /// <summary>
        /// Constructor for adding a new song
        /// </summary>
        /// <param name="artists">The</param>
        public SongForm(BindingList<Artist> artists)
        {
            Initialize();

            bindingArtists = artists;
            new_song_form = true;
        }

        /// <summary>
        /// Constructor for editting existing song
        /// </summary>
        /// <param name="songs"></param>
        /// <param name="editSong"></param>
        public SongForm(BindingList<Artist> artists, Song editSong)
        {
            Initialize();

            bindingArtists = artists;
            song = editSong;

            titleTextBox.Text = song.Title;
            artistTextBox.Text = song.Artist;
            mp3PathTextBox.Text = song.Mp3Path;
            albumArtTextBox.Text = song.ArtworkPath;

            new_song_form = false;
        }

        /// <summary>
        /// Repositions controls to the center of the form
        /// </summary>
        private void CenterContent()
        {
            albumArtPicture.Left = (ClientSize.Width - albumArtPicture.Width) / 2;
            songInfoTable.Left = (ClientSize.Width - songInfoTable.Width) / 2;
        }

        /// <summary>
        /// Checks if the given name is already an artist
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True if the artist exists, false otherwise</returns>
        private bool ContainsArtist(string name)
        {
            foreach (Artist a in bindingArtists)
            {
                if (a.Name == name)
                    return true;
            }

            return false;
        }

        private bool ContainsSong(List<Song> songs, Song song)
        {
            foreach (Song s in songs)
            {
                if (s.Title == song.Title)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool IsInputValid()
        {
            return artistTextBox.Text.Trim(whitespace) != "" && titleTextBox.Text.Trim(whitespace) != "" && mp3PathTextBox.Text.Trim(whitespace) != "";
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillSong()
        {
            song = new Song();

            song.Title = titleTextBox.Text.Trim(whitespace);
            song.Artist = artistTextBox.Text.Trim(whitespace);
            song.Mp3Path = mp3PathTextBox.Text.Trim(whitespace);
            song.ArtworkPath = albumArtTextBox.Text.Trim(whitespace);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool AddSong()
        {
            string artist = artistTextBox.Text.Trim(whitespace);

            // This is a new artist
            if (!ContainsArtist(artist))
            {
                string message = "This is a new artist: " + artist + "\n\nAre you sure you want to add this artist?";
                string caption = "New Artist";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    FillSong();

                    Artist a = new Artist();
                    a.Name = artist;
                    a.AddSong(song);

                    bindingArtists.Add(a);
                    return true;
                }
            }

            // This artist already exists
            else
            {
                foreach (Artist a in bindingArtists)
                {
                    if (a.Name == artist)
                    {
                        FillSong();
                        if (ContainsSong(a.Songs, song))
                        {
                            string message = "The song \"" + song.Title + "\" by " + song.Artist + " already exists.";
                            string caption = "Duplicate Song";
                            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        a.AddSong(song);
                        return true;
                    }
                }
            }

            return false;
        }

        private void browseMp3Button_Click(object sender, EventArgs e)
        {
            if (openMp3FileDialog.ShowDialog() == DialogResult.OK)
            {
                mp3PathTextBox.Text = openMp3FileDialog.FileName;
            }
        }

        private void browseAlbumArtButton_Click(object sender, EventArgs e)
        {
            if (openAlbumArtFileDialog.ShowDialog() == DialogResult.OK)
            {
                albumArtTextBox.Text = openAlbumArtFileDialog.FileName;
                albumArtPicture.BackgroundImage = Image.FromFile(openAlbumArtFileDialog.FileName);
                albumArtPicture.Invalidate();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            // Input validation
            if (!IsInputValid())
            {
                string message = "Title, Artist, and MP3 File cannot be empty.";
                string caption = "Invalid Input";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!new_song_form)
            {
                foreach (Artist a in bindingArtists)
                {
                    if (a.Songs.Contains(song))
                    {
                        a.Songs.Remove(song);
                    }
                }
            }

            if (!AddSong())
                return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void albumArtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                albumArtPicture.BackgroundImage = Image.FromFile(albumArtTextBox.Text);
            }
            catch (Exception ex)
            {
                albumArtPicture.BackgroundImage = Properties.Resources.no_album_art;
            }
        }
    }
}
