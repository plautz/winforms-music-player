namespace MusicPlayer
{
    partial class MusicPlayerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMusicLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMusicLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistsListBox = new System.Windows.Forms.ListBox();
            this.songsListBox = new System.Windows.Forms.ListBox();
            this.newSongButton = new System.Windows.Forms.Button();
            this.artistsLabel = new System.Windows.Forms.Label();
            this.songsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.playbackPanel = new System.Windows.Forms.Panel();
            this.playPause = new MusicPlayer.RoundButton();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.totalTime = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.editSongButton = new System.Windows.Forms.Button();
            this.albumArt = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.playbackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(572, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMusicLibraryToolStripMenuItem,
            this.saveMusicLibraryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fileToolStripMenuItem.Text = "Options...";
            // 
            // openMusicLibraryToolStripMenuItem
            // 
            this.openMusicLibraryToolStripMenuItem.Name = "openMusicLibraryToolStripMenuItem";
            this.openMusicLibraryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openMusicLibraryToolStripMenuItem.Text = "Open Music Library...";
            this.openMusicLibraryToolStripMenuItem.Click += new System.EventHandler(this.openMusicLibraryToolStripMenuItem_Click);
            // 
            // saveMusicLibraryToolStripMenuItem
            // 
            this.saveMusicLibraryToolStripMenuItem.Name = "saveMusicLibraryToolStripMenuItem";
            this.saveMusicLibraryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveMusicLibraryToolStripMenuItem.Text = "Save Music Library...";
            this.saveMusicLibraryToolStripMenuItem.Click += new System.EventHandler(this.saveMusicLibraryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // artistsListBox
            // 
            this.artistsListBox.BackColor = System.Drawing.Color.DimGray;
            this.artistsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistsListBox.ForeColor = System.Drawing.Color.White;
            this.artistsListBox.FormattingEnabled = true;
            this.artistsListBox.ItemHeight = 16;
            this.artistsListBox.Location = new System.Drawing.Point(29, 431);
            this.artistsListBox.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.artistsListBox.Name = "artistsListBox";
            this.artistsListBox.Size = new System.Drawing.Size(237, 96);
            this.artistsListBox.Sorted = true;
            this.artistsListBox.TabIndex = 1;
            this.artistsListBox.SelectedIndexChanged += new System.EventHandler(this.artistsListBox_SelectedIndexChanged);
            // 
            // songsListBox
            // 
            this.songsListBox.BackColor = System.Drawing.Color.DimGray;
            this.songsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsListBox.ForeColor = System.Drawing.Color.White;
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.ItemHeight = 16;
            this.songsListBox.Location = new System.Drawing.Point(306, 431);
            this.songsListBox.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(237, 96);
            this.songsListBox.Sorted = true;
            this.songsListBox.TabIndex = 2;
            this.songsListBox.DoubleClick += new System.EventHandler(this.songsListBox_DoubleClick);
            // 
            // newSongButton
            // 
            this.newSongButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.newSongButton.FlatAppearance.BorderSize = 0;
            this.newSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSongButton.ForeColor = System.Drawing.Color.White;
            this.newSongButton.Location = new System.Drawing.Point(434, 550);
            this.newSongButton.Name = "newSongButton";
            this.newSongButton.Size = new System.Drawing.Size(109, 31);
            this.newSongButton.TabIndex = 3;
            this.newSongButton.Text = "New Song...";
            this.newSongButton.UseVisualStyleBackColor = false;
            this.newSongButton.Click += new System.EventHandler(this.newSongButton_Click);
            // 
            // artistsLabel
            // 
            this.artistsLabel.AutoSize = true;
            this.artistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistsLabel.ForeColor = System.Drawing.Color.LightGray;
            this.artistsLabel.Location = new System.Drawing.Point(26, 408);
            this.artistsLabel.Name = "artistsLabel";
            this.artistsLabel.Size = new System.Drawing.Size(182, 17);
            this.artistsLabel.TabIndex = 4;
            this.artistsLabel.Text = "Artists (click to show songs)";
            // 
            // songsLabel
            // 
            this.songsLabel.AutoSize = true;
            this.songsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsLabel.ForeColor = System.Drawing.Color.LightGray;
            this.songsLabel.Location = new System.Drawing.Point(303, 408);
            this.songsLabel.Name = "songsLabel";
            this.songsLabel.Size = new System.Drawing.Size(237, 17);
            this.songsLabel.TabIndex = 5;
            this.songsLabel.Text = "Songs by Artist (double click to play)";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(258, 236);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(66, 29);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.UseMnemonic = false;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.LightGray;
            this.artistLabel.Location = new System.Drawing.Point(273, 268);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(40, 17);
            this.artistLabel.TabIndex = 8;
            this.artistLabel.Text = "Artist";
            this.artistLabel.UseMnemonic = false;
            // 
            // playbackPanel
            // 
            this.playbackPanel.BackColor = System.Drawing.Color.Transparent;
            this.playbackPanel.Controls.Add(this.playPause);
            this.playbackPanel.Controls.Add(this.musicTrackBar);
            this.playbackPanel.Controls.Add(this.totalTime);
            this.playbackPanel.Controls.Add(this.elapsedTime);
            this.playbackPanel.Location = new System.Drawing.Point(135, 288);
            this.playbackPanel.Name = "playbackPanel";
            this.playbackPanel.Size = new System.Drawing.Size(321, 117);
            this.playbackPanel.TabIndex = 11;
            // 
            // playPause
            // 
            this.playPause.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playPause.FlatAppearance.BorderSize = 0;
            this.playPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPause.ForeColor = System.Drawing.SystemColors.Control;
            this.playPause.Location = new System.Drawing.Point(133, 54);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(60, 40);
            this.playPause.TabIndex = 12;
            this.playPause.Text = "PAUSE";
            this.playPause.UseVisualStyleBackColor = false;
            this.playPause.Click += new System.EventHandler(this.playPause_Click);
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musicTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicTrackBar.Location = new System.Drawing.Point(37, 23);
            this.musicTrackBar.Maximum = 100;
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(240, 45);
            this.musicTrackBar.TabIndex = 2;
            this.musicTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicTrackBar.Scroll += new System.EventHandler(this.musicTrackBar_Scroll);
            this.musicTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicTrackBar_MouseDown);
            // 
            // totalTime
            // 
            this.totalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalTime.AutoSize = true;
            this.totalTime.ForeColor = System.Drawing.Color.LightGray;
            this.totalTime.Location = new System.Drawing.Point(290, 29);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(28, 13);
            this.totalTime.TabIndex = 1;
            this.totalTime.Text = "0:00";
            // 
            // elapsedTime
            // 
            this.elapsedTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.ForeColor = System.Drawing.Color.LightGray;
            this.elapsedTime.Location = new System.Drawing.Point(3, 29);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(28, 13);
            this.elapsedTime.TabIndex = 0;
            this.elapsedTime.Text = "0:00";
            // 
            // editSongButton
            // 
            this.editSongButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editSongButton.Enabled = false;
            this.editSongButton.FlatAppearance.BorderSize = 0;
            this.editSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSongButton.ForeColor = System.Drawing.Color.White;
            this.editSongButton.Location = new System.Drawing.Point(306, 550);
            this.editSongButton.Name = "editSongButton";
            this.editSongButton.Size = new System.Drawing.Size(109, 31);
            this.editSongButton.TabIndex = 12;
            this.editSongButton.Text = "Edit Song...";
            this.editSongButton.UseVisualStyleBackColor = false;
            this.editSongButton.Click += new System.EventHandler(this.editSongButton_Click);
            // 
            // albumArt
            // 
            this.albumArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.albumArt.BackgroundImage = global::MusicPlayer.Properties.Resources.no_album_art;
            this.albumArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumArt.ErrorImage = global::MusicPlayer.Properties.Resources.no_album_art;
            this.albumArt.InitialImage = global::MusicPlayer.Properties.Resources.no_album_art;
            this.albumArt.Location = new System.Drawing.Point(205, 49);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(175, 175);
            this.albumArt.TabIndex = 6;
            this.albumArt.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "aud";
            this.saveFileDialog.Filter = "Audio Files|*.audio";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "aud";
            this.openFileDialog.Filter = "Audio Files|*.audio";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(131, 164);
            this.welcomeLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(348, 96);
            this.welcomeLabel.TabIndex = 13;
            this.welcomeLabel.Text = "Load an audio library from the \"Options...\" menu item, add a new song, or choose " +
    "an existing song from below to begin.";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MusicPlayerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(572, 590);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.editSongButton);
            this.Controls.Add(this.playbackPanel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.albumArt);
            this.Controls.Add(this.songsLabel);
            this.Controls.Add(this.artistsLabel);
            this.Controls.Add(this.newSongButton);
            this.Controls.Add(this.songsListBox);
            this.Controls.Add(this.artistsListBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayerMain";
            this.Text = "Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicPlayer_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.playbackPanel.ResumeLayout(false);
            this.playbackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMusicLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMusicLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox artistsListBox;
        private System.Windows.Forms.ListBox songsListBox;
        private System.Windows.Forms.Button newSongButton;
        private System.Windows.Forms.Label artistsLabel;
        private System.Windows.Forms.Label songsLabel;
        private System.Windows.Forms.PictureBox albumArt;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Panel playbackPanel;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label elapsedTime;
        private RoundButton playPause;
        private System.Windows.Forms.Button editSongButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

