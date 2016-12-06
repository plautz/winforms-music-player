namespace MusicPlayer
{
    partial class SongForm
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
            this.songInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.albumArtTextBox = new System.Windows.Forms.TextBox();
            this.mp3PathTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.mp3PathLabel = new System.Windows.Forms.Label();
            this.albumArtPathLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.browseMp3Button = new System.Windows.Forms.Button();
            this.browseAlbumArtButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.albumArtPicture = new System.Windows.Forms.PictureBox();
            this.openMp3FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAlbumArtFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.songInfoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // songInfoTable
            // 
            this.songInfoTable.ColumnCount = 3;
            this.songInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.songInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.songInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.songInfoTable.Controls.Add(this.label1, 0, 4);
            this.songInfoTable.Controls.Add(this.albumArtTextBox, 1, 3);
            this.songInfoTable.Controls.Add(this.mp3PathTextBox, 1, 2);
            this.songInfoTable.Controls.Add(this.artistTextBox, 1, 1);
            this.songInfoTable.Controls.Add(this.titleLabel, 0, 0);
            this.songInfoTable.Controls.Add(this.artistLabel, 0, 1);
            this.songInfoTable.Controls.Add(this.mp3PathLabel, 0, 2);
            this.songInfoTable.Controls.Add(this.albumArtPathLabel, 0, 3);
            this.songInfoTable.Controls.Add(this.titleTextBox, 1, 0);
            this.songInfoTable.Controls.Add(this.browseMp3Button, 2, 2);
            this.songInfoTable.Controls.Add(this.browseAlbumArtButton, 2, 3);
            this.songInfoTable.Controls.Add(this.saveButton, 2, 4);
            this.songInfoTable.Controls.Add(this.cancelButton, 1, 4);
            this.songInfoTable.Location = new System.Drawing.Point(21, 212);
            this.songInfoTable.Name = "songInfoTable";
            this.songInfoTable.RowCount = 5;
            this.songInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.songInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.songInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.songInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.songInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.songInfoTable.Size = new System.Drawing.Size(444, 157);
            this.songInfoTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "(optional)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // albumArtTextBox
            // 
            this.albumArtTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumArtTextBox.Location = new System.Drawing.Point(73, 84);
            this.albumArtTextBox.Name = "albumArtTextBox";
            this.albumArtTextBox.Size = new System.Drawing.Size(287, 20);
            this.albumArtTextBox.TabIndex = 7;
            this.albumArtTextBox.WordWrap = false;
            this.albumArtTextBox.TextChanged += new System.EventHandler(this.albumArtTextBox_TextChanged);
            // 
            // mp3PathTextBox
            // 
            this.mp3PathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mp3PathTextBox.Location = new System.Drawing.Point(73, 55);
            this.mp3PathTextBox.Name = "mp3PathTextBox";
            this.mp3PathTextBox.Size = new System.Drawing.Size(287, 20);
            this.mp3PathTextBox.TabIndex = 6;
            this.mp3PathTextBox.WordWrap = false;
            // 
            // artistTextBox
            // 
            this.songInfoTable.SetColumnSpan(this.artistTextBox, 2);
            this.artistTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artistTextBox.Location = new System.Drawing.Point(73, 29);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(368, 20);
            this.artistTextBox.TabIndex = 5;
            this.artistTextBox.WordWrap = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(64, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.White;
            this.artistLabel.Location = new System.Drawing.Point(3, 26);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(64, 26);
            this.artistLabel.TabIndex = 1;
            this.artistLabel.Text = "Artist";
            this.artistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mp3PathLabel
            // 
            this.mp3PathLabel.AutoSize = true;
            this.mp3PathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mp3PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp3PathLabel.ForeColor = System.Drawing.Color.White;
            this.mp3PathLabel.Location = new System.Drawing.Point(3, 52);
            this.mp3PathLabel.Name = "mp3PathLabel";
            this.mp3PathLabel.Size = new System.Drawing.Size(64, 29);
            this.mp3PathLabel.TabIndex = 2;
            this.mp3PathLabel.Text = "Music File";
            this.mp3PathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // albumArtPathLabel
            // 
            this.albumArtPathLabel.AutoSize = true;
            this.albumArtPathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumArtPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtPathLabel.ForeColor = System.Drawing.Color.White;
            this.albumArtPathLabel.Location = new System.Drawing.Point(3, 81);
            this.albumArtPathLabel.Name = "albumArtPathLabel";
            this.albumArtPathLabel.Size = new System.Drawing.Size(64, 29);
            this.albumArtPathLabel.TabIndex = 3;
            this.albumArtPathLabel.Text = "Album Art";
            this.albumArtPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTextBox
            // 
            this.songInfoTable.SetColumnSpan(this.titleTextBox, 2);
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextBox.Location = new System.Drawing.Point(73, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(368, 20);
            this.titleTextBox.TabIndex = 4;
            this.titleTextBox.WordWrap = false;
            // 
            // browseMp3Button
            // 
            this.browseMp3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browseMp3Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.browseMp3Button.FlatAppearance.BorderSize = 0;
            this.browseMp3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseMp3Button.ForeColor = System.Drawing.Color.White;
            this.browseMp3Button.Location = new System.Drawing.Point(366, 55);
            this.browseMp3Button.Name = "browseMp3Button";
            this.browseMp3Button.Size = new System.Drawing.Size(75, 23);
            this.browseMp3Button.TabIndex = 8;
            this.browseMp3Button.Text = "Browse...";
            this.browseMp3Button.UseVisualStyleBackColor = false;
            this.browseMp3Button.Click += new System.EventHandler(this.browseMp3Button_Click);
            // 
            // browseAlbumArtButton
            // 
            this.browseAlbumArtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browseAlbumArtButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.browseAlbumArtButton.FlatAppearance.BorderSize = 0;
            this.browseAlbumArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAlbumArtButton.ForeColor = System.Drawing.Color.White;
            this.browseAlbumArtButton.Location = new System.Drawing.Point(366, 84);
            this.browseAlbumArtButton.Name = "browseAlbumArtButton";
            this.browseAlbumArtButton.Size = new System.Drawing.Size(75, 23);
            this.browseAlbumArtButton.TabIndex = 9;
            this.browseAlbumArtButton.Text = "Browse...";
            this.browseAlbumArtButton.UseVisualStyleBackColor = false;
            this.browseAlbumArtButton.Click += new System.EventHandler(this.browseAlbumArtButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(366, 131);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(285, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // albumArtPicture
            // 
            this.albumArtPicture.BackgroundImage = global::MusicPlayer.Properties.Resources.no_album_art;
            this.albumArtPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumArtPicture.ErrorImage = global::MusicPlayer.Properties.Resources.no_album_art;
            this.albumArtPicture.Location = new System.Drawing.Point(151, 19);
            this.albumArtPicture.Name = "albumArtPicture";
            this.albumArtPicture.Size = new System.Drawing.Size(175, 175);
            this.albumArtPicture.TabIndex = 0;
            this.albumArtPicture.TabStop = false;
            // 
            // openMp3FileDialog
            // 
            this.openMp3FileDialog.DefaultExt = "mp3";
            this.openMp3FileDialog.Filter = "MP3 or WAV Files|*.mp3;*.wav";
            // 
            // openAlbumArtFileDialog
            // 
            this.openAlbumArtFileDialog.Filter = "Image Files|*.jpg;*.png;*.gif;*.jpeg";
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(477, 389);
            this.ControlBox = false;
            this.Controls.Add(this.albumArtPicture);
            this.Controls.Add(this.songInfoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SongForm";
            this.Text = "SongForm";
            this.songInfoTable.ResumeLayout(false);
            this.songInfoTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox albumArtPicture;
        private System.Windows.Forms.TableLayoutPanel songInfoTable;
        private System.Windows.Forms.TextBox albumArtTextBox;
        private System.Windows.Forms.TextBox mp3PathTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label mp3PathLabel;
        private System.Windows.Forms.Label albumArtPathLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button browseMp3Button;
        private System.Windows.Forms.Button browseAlbumArtButton;
        private System.Windows.Forms.OpenFileDialog openMp3FileDialog;
        private System.Windows.Forms.OpenFileDialog openAlbumArtFileDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label label1;
    }
}