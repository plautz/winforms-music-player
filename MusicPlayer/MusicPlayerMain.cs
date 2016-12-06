using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MusicPlayer
{
    public partial class MusicPlayerMain : Form
    {

        // Audio control members
        private AudioFileReader audioFile = null;
        private IWavePlayer player = new WaveOut();

        // To keep track of current song's information
        private struct CurrentSong
        {
            public string Title;
            public string Artist;
        }
        private CurrentSong currentSong = new CurrentSong();

        // Playback threading 
        private bool abortThread = false;
        private bool pauseThread = false;
        private object threadLock = new object();
        delegate void IncrementValueCallback();

        // Binded data
        List<Artist> artists = new List<Artist>();
        BindingList<Artist> bindingArtists;
        BindingList<Song> bindingSongs;

        private bool changes_not_saved = false;

        public MusicPlayerMain()
        {
            InitializeComponent();
            CenterContent();
            StartPosition = FormStartPosition.CenterScreen;

            bindingArtists = new BindingList<Artist>(artists);
            bindingArtists.RaiseListChangedEvents = true;
            bindingArtists.AllowNew = true;
            bindingArtists.AllowEdit = true;

            artistsListBox.DataSource = bindingArtists;
            artistsListBox.DisplayMember = "Name";

            welcomeLabel.Text = "Welcome!\n\n" + welcomeLabel.Text;

            ChangeVisibility(false);
        }
        
        #region Helper Methods

        /// <summary>
        /// changes whether the welcome screen or playback controls are visible
        /// </summary>
        /// <param name="playback_is_visible"></param>
        private void ChangeVisibility(bool playback_is_visible)
        {
            playbackPanel.Visible = playback_is_visible;
            titleLabel.Visible = playback_is_visible;
            artistLabel.Visible = playback_is_visible;
            albumArt.Visible = playback_is_visible;

            welcomeLabel.Visible = !playback_is_visible;
        }

        /// <summary>
        /// Repositions controls to the center of the form
        /// </summary>
        private void CenterContent()
        {
            albumArt.Left = (ClientSize.Width - albumArt.Width) / 2;
            titleLabel.Left = (ClientSize.Width - titleLabel.Width) / 2;
            artistLabel.Left = (ClientSize.Width - artistLabel.Width) / 2;
            playbackPanel.Left = (ClientSize.Width - playbackPanel.Width) / 2;
            playPause.Left = (playbackPanel.Width - playPause.Width) / 2;
            musicTrackBar.Left = (playbackPanel.Width - musicTrackBar.Width) / 2;
            welcomeLabel.Left = (ClientSize.Width - welcomeLabel.Width) / 2;
        }

        /// <summary>
        /// Resets all playback controls to default
        /// </summary>
        private void ResetPlaybackPanel()
        {
            TimeSpan songLength = audioFile.TotalTime;
            int songSeconds = songLength.Minutes * 60 + songLength.Seconds;

            musicTrackBar.Maximum = songSeconds;
            musicTrackBar.Value = 0;

            string seconds = songLength.Seconds.ToString();
            if (songLength.Seconds < 10)
                seconds = "0" + seconds;

            totalTime.Text = songLength.Minutes.ToString() + ":" + seconds;
            elapsedTime.Text = "0:00";
        }

        /// <summary>
        /// Used to update playback controls when the user clicks or drags the slider
        /// </summary>
        /// <param name="e"></param>
        private void PlaybackHandler(MouseEventArgs e)
        {
            // Jumps to arbitrary point on trackbar the user clicks
            if (e != null)
            {
                double dblValue = ((double)e.X / (double)musicTrackBar.Width) * (musicTrackBar.Maximum - musicTrackBar.Minimum);
                musicTrackBar.Value = Convert.ToInt32(dblValue);
            }

            audioFile.CurrentTime = TimeSpan.FromSeconds(musicTrackBar.Value);

            // Hacky fix for NAudio's IWavePlayer that would stop playback and dispose of the AudioFileReader
            if (musicTrackBar.Value == musicTrackBar.Maximum)
            {
                playPause.Text = "PLAY";
                PauseThread();
                player.Pause();
            }

            if (playPause.Text == "PAUSE")
            {
                player.Play();
                ResumeThread();
            }

            UpdateElapsedTime();
        }

        /// <summary>
        /// Updates the sliders position to the song's position and updates the elapsed time
        /// </summary>
        private void IncrementPlaybackValues()
        {
            musicTrackBar.Value = (int)audioFile.CurrentTime.TotalSeconds;

            UpdateElapsedTime();

            if (musicTrackBar.Value == musicTrackBar.Maximum)
                playPause.Text = "PLAY";
        }

        /// <summary>
        /// Updates playback control to display correct elapsed time in song
        /// </summary>
        private void UpdateElapsedTime()
        {
            TimeSpan songPosition = audioFile.CurrentTime;

            string seconds = songPosition.Seconds.ToString();
            if (songPosition.Seconds < 10)
                seconds = "0" + seconds;

            elapsedTime.Text = songPosition.Minutes.ToString() + ":" + seconds;
        }

        /// <summary>
        /// Playback threads run this in order to update playback controls
        /// </summary>
        private void ThreadUpdatePlayback()
        {
            while (!abortThread)
            {
                if (pauseThread)
                {
                    // If the thread is paused, wait to be resumed
                    lock (threadLock)
                    {
                        Monitor.Wait(threadLock);
                    }
                }

                Thread.Sleep(1000);

                try
                {
                    // Attempt to update playback controls
                    IncrementValueCallback d = new IncrementValueCallback(IncrementPlaybackValues);
                    Invoke(d, new object[] { });
                }
                catch (Exception e)
                {
                    break;
                }

            }
        }

        /// <summary>
        /// Starts a new thread that handles playback controls
        /// </summary>
        private void StartThread()
        {
            abortThread = false;
            lock (threadLock)
            {
                Thread thread = new Thread(new ThreadStart(ThreadUpdatePlayback));
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void PauseThread()
        {
            pauseThread = true;
        }

        private void ResumeThread()
        {
            pauseThread = false;
            lock (threadLock)
            {
                Monitor.PulseAll(threadLock);
            }
        }

        private void AbortThread()
        {
            abortThread = true;
        }

        #endregion Helper Methods


        #region Event Handlers

        private void musicTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            PlaybackHandler(e);
        }

        private void musicTrackBar_Scroll(object sender, EventArgs e)
        {
            PlaybackHandler(null);
        }

        private void playPause_Click(object sender, EventArgs e)
        {
            if (playPause.Text == "PLAY")
            {
                // Revert song to beginning if the end was reached and the user hit play
                if (musicTrackBar.Value == musicTrackBar.Maximum)
                {
                    audioFile.CurrentTime = TimeSpan.FromSeconds(0);
                    elapsedTime.Text = "0:00";
                    musicTrackBar.Value = 0;
                }

                player.Play();
                ResumeThread();
                playPause.Text = "PAUSE";
            }
            else
            {
                PauseThread();
                player.Pause();
                playPause.Text = "PLAY";
            }
        }

        private void editSongButton_Click(object sender, EventArgs e)
        {
            Song selected = (Song)songsListBox.SelectedItem;

            // Check if the song to be editted is the currently playing song
            bool updating_currently_playing = currentSong.Title != null && currentSong.Title == selected.Title && currentSong.Artist == selected.Artist;

            // Open an edit song form
            SongForm form = new SongForm(bindingArtists, selected);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Text = "Edit Song";

            if (form.ShowDialog() == DialogResult.OK)
            {
                // If this is true, we must update the currently playing display information with the new editted info
                if (updating_currently_playing)
                {
                    UpdateSongDisplayInfo(form.Song);
                    CenterContent();
                }

                // Fire this event to update the songs list with the editted song
                artistsListBox_SelectedIndexChanged(artistsListBox, null);
                changes_not_saved = true;
            }
        }

        private void newSongButton_Click(object sender, EventArgs e)
        {
            // Open a new song form
            SongForm form = new SongForm(bindingArtists);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Text = "New Song";

            if (form.ShowDialog() == DialogResult.OK)
            {
                // Enable the edit song button if not already, and fire event to update songs list with new song
                editSongButton.Enabled = true;
                artistsListBox_SelectedIndexChanged(artistsListBox, null);
                changes_not_saved = true;
            }
        }

        private void artistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artist selectedArtist = (Artist)artistsListBox.SelectedItem;

            if (selectedArtist != null)
            {
                if (selectedArtist.Songs.Count == 0)
                {
                    bindingArtists.Remove(selectedArtist);
                    return;
                }
                bindingSongs = new BindingList<Song>(selectedArtist.Songs);
                bindingSongs.RaiseListChangedEvents = true;
                bindingSongs.AllowEdit = true;
                bindingSongs.AllowNew = true;

                // Bind songs list box to new binding list of an artist's songs
                songsListBox.DataSource = bindingSongs;
                songsListBox.DisplayMember = "Title";

                songsListBox.Invalidate();
            }
        }

        private void songsListBox_DoubleClick(object sender, EventArgs e)
        {
            Song s = (Song)songsListBox.SelectedItem;
            if (s != null)
            {
                // Stop current song
                playPause.Text = "PLAY";
                player.Stop();

                // Try to update the MP3 source
                try
                {
                    audioFile = new AudioFileReader(s.Mp3Path);
                }
                catch (Exception ex)
                {
                    // If there's a problem with the MP3 file, display an error message
                    string message = "MP3 could not be played. Check file path:\n\n" + s.Mp3Path;
                    string caption = "Error";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the song's display information
                UpdateSongDisplayInfo(s);

                // Reset playback controls
                ResetPlaybackPanel();
                ChangeVisibility(true);
                CenterContent();

                // Stop any existing threads then start a new one
                AbortThread();
                StartThread();

                // Update player with new song and start playing
                currentSong.Title = s.Title;
                currentSong.Artist = s.Artist;
                playPause.Text = "PAUSE";
                player.Init(audioFile);
                player.Play();
            }
        }

        private void UpdateSongDisplayInfo(Song s)
        {
            try
            {
                albumArt.BackgroundImage = Image.FromFile(s.ArtworkPath);
            }
            catch (Exception e)
            {
                albumArt.BackgroundImage = Properties.Resources.no_album_art;
            }

            titleLabel.Text = s.Title;
            artistLabel.Text = s.Artist;
        }

        /// <summary>
        /// Saves the current application music library to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveMusicLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer s = new XmlSerializer(artists.GetType());
                using (TextWriter w = new StreamWriter(saveFileDialog.FileName))
                {
                    s.Serialize(w, artists);
                    changes_not_saved = true;
                }
            }
        }

        /// <summary>
        /// Loads a saved music library from storage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMusicLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer s = new XmlSerializer(artists.GetType());
                using (TextReader r = new StreamReader(openFileDialog.FileName))
                {
                    List<Artist> newArtists = (List<Artist>)s.Deserialize(r);
                    player.Stop();
                    bindingArtists.Clear();
                    foreach (Artist a in newArtists)
                        bindingArtists.Add(a);

                    if (bindingArtists.Count > 0)
                        editSongButton.Enabled = true;

                    artistsListBox.Invalidate();
                    songsListBox.Invalidate();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes_not_saved)
            {
                string message = "You have made changes without saving.\nWould you like to save your work and exit?";
                string caption = "Unsaved Work";
                DialogResult d = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (d == DialogResult.Yes)
                {
                    saveMusicLibraryToolStripMenuItem_Click(sender, null);
                }
                else if (d == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            if (e.Cancel == false)
                CleanUp();
        }

        /// <summary>
        /// Aborts any active threads, stops and disposes the audio file and player
        /// </summary>
        private void CleanUp()
        {
            AbortThread();
            player.Stop();

            try { audioFile.Dispose(); }
            catch (Exception e) { Console.WriteLine("Exception whiling disposing AudioFileReader: " + e.Message); }

            player.Dispose();
        }

        #endregion Event Handlers


    }
}
