namespace flac_player_form
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.durationNow = new System.Windows.Forms.Label();
            this.durationTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.repeatButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.nextTrack = new System.Windows.Forms.Button();
            this.previousTrack = new System.Windows.Forms.Button();
            this.nowPlaying = new System.Windows.Forms.Label();
            this.trackName = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.openSongs = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundCredits = new System.Windows.Forms.LinkLabel();
            this.trackInfo = new System.Windows.Forms.Panel();
            this.toggleAlbumCover = new System.Windows.Forms.Button();
            this.bitrateValue = new System.Windows.Forms.Label();
            this.bitrateLabel = new System.Windows.Forms.Label();
            this.lengthValue = new System.Windows.Forms.Label();
            this.yearValue = new System.Windows.Forms.Label();
            this.albumValue = new System.Windows.Forms.Label();
            this.titleValue = new System.Windows.Forms.Label();
            this.artistValue = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.albumCover = new System.Windows.Forms.PictureBox();
            this.trackInfoMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.volumeIcon = new System.Windows.Forms.PictureBox();
            this.volumeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.controlsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.playlistMenu = new System.Windows.Forms.Button();
            this.playlistPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.playlistList = new System.Windows.Forms.ListBox();
            this.durationSlider = new ColorSlider.ColorSlider();
            this.volumeSlider = new ColorSlider.ColorSlider();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.trackInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumCover)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeIcon)).BeginInit();
            this.playlistPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.playlistToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "mainMenuStrip";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem2.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openToolStripMenuItem.Text = "Open song(s)...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playbackSettingsToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // playbackSettingsToolStripMenuItem
            // 
            this.playbackSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playbackSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playbackSettingsToolStripMenuItem.Name = "playbackSettingsToolStripMenuItem";
            this.playbackSettingsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.playbackSettingsToolStripMenuItem.Text = "Playback settings...";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.themeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.themeToolStripMenuItem.Text = "Theme...";
            this.themeToolStripMenuItem.Click += new System.EventHandler(this.themeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(35, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(28, 28);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // durationNow
            // 
            this.durationNow.AutoSize = true;
            this.durationNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.durationNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationNow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationNow.Location = new System.Drawing.Point(3, 0);
            this.durationNow.Name = "durationNow";
            this.durationNow.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.durationNow.Size = new System.Drawing.Size(34, 37);
            this.durationNow.TabIndex = 10;
            this.durationNow.Text = "00:00";
            // 
            // durationTotal
            // 
            this.durationTotal.AutoSize = true;
            this.durationTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTotal.Location = new System.Drawing.Point(1161, 0);
            this.durationTotal.Name = "durationTotal";
            this.durationTotal.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.durationTotal.Size = new System.Drawing.Size(34, 37);
            this.durationTotal.TabIndex = 11;
            this.durationTotal.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.repeatButton);
            this.panel1.Controls.Add(this.shuffleButton);
            this.panel1.Controls.Add(this.nextTrack);
            this.panel1.Controls.Add(this.previousTrack);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 34);
            this.panel1.TabIndex = 0;
            // 
            // repeatButton
            // 
            this.repeatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.repeatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("repeatButton.BackgroundImage")));
            this.repeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.repeatButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.repeatButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.repeatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.repeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatButton.ForeColor = System.Drawing.Color.White;
            this.repeatButton.Location = new System.Drawing.Point(142, 3);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(28, 28);
            this.repeatButton.TabIndex = 6;
            this.repeatButton.UseVisualStyleBackColor = false;
            this.repeatButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.shuffleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shuffleButton.BackgroundImage")));
            this.shuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.shuffleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.shuffleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.shuffleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.shuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffleButton.ForeColor = System.Drawing.Color.White;
            this.shuffleButton.Location = new System.Drawing.Point(110, 3);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(28, 28);
            this.shuffleButton.TabIndex = 5;
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // nextTrack
            // 
            this.nextTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.nextTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextTrack.BackgroundImage")));
            this.nextTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nextTrack.Enabled = false;
            this.nextTrack.FlatAppearance.BorderSize = 0;
            this.nextTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nextTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTrack.ForeColor = System.Drawing.Color.White;
            this.nextTrack.Location = new System.Drawing.Point(67, 3);
            this.nextTrack.Name = "nextTrack";
            this.nextTrack.Size = new System.Drawing.Size(28, 28);
            this.nextTrack.TabIndex = 4;
            this.nextTrack.UseVisualStyleBackColor = false;
            this.nextTrack.Click += new System.EventHandler(this.nextTrack_Click);
            // 
            // previousTrack
            // 
            this.previousTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.previousTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousTrack.BackgroundImage")));
            this.previousTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previousTrack.Enabled = false;
            this.previousTrack.FlatAppearance.BorderSize = 0;
            this.previousTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.previousTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousTrack.ForeColor = System.Drawing.Color.White;
            this.previousTrack.Location = new System.Drawing.Point(3, 3);
            this.previousTrack.Name = "previousTrack";
            this.previousTrack.Size = new System.Drawing.Size(28, 28);
            this.previousTrack.TabIndex = 3;
            this.previousTrack.UseVisualStyleBackColor = false;
            this.previousTrack.Click += new System.EventHandler(this.previousTrack_Click);
            // 
            // nowPlaying
            // 
            this.nowPlaying.AutoSize = true;
            this.nowPlaying.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlaying.Location = new System.Drawing.Point(219, 37);
            this.nowPlaying.Name = "nowPlaying";
            this.nowPlaying.Padding = new System.Windows.Forms.Padding(10, 7, 5, 0);
            this.nowPlaying.Size = new System.Drawing.Size(125, 26);
            this.nowPlaying.TabIndex = 0;
            this.nowPlaying.Text = "Now playing:";
            // 
            // trackName
            // 
            this.trackName.AutoSize = true;
            this.trackName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackName.Location = new System.Drawing.Point(350, 37);
            this.trackName.Name = "trackName";
            this.trackName.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.trackName.Size = new System.Drawing.Size(23, 25);
            this.trackName.TabIndex = 12;
            this.trackName.Text = "---";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // openSongs
            // 
            this.openSongs.Multiselect = true;
            this.openSongs.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(155)))), ((int)(((byte)(179)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.pictureBox1.Size = new System.Drawing.Size(1198, 599);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundCredits
            // 
            this.backgroundCredits.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(147)))), ((int)(((byte)(173)))));
            this.backgroundCredits.AutoSize = true;
            this.backgroundCredits.BackColor = System.Drawing.Color.Transparent;
            this.backgroundCredits.Font = new System.Drawing.Font("Arial", 7.5F);
            this.backgroundCredits.LinkColor = System.Drawing.Color.White;
            this.backgroundCredits.Location = new System.Drawing.Point(1078, 606);
            this.backgroundCredits.Name = "backgroundCredits";
            this.backgroundCredits.Size = new System.Drawing.Size(123, 13);
            this.backgroundCredits.TabIndex = 11;
            this.backgroundCredits.TabStop = true;
            this.backgroundCredits.Text = "munroevan: “ late vibes ”";
            this.backgroundCredits.VisitedLinkColor = System.Drawing.Color.White;
            this.backgroundCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backgroundCredits_LinkClicked);
            // 
            // trackInfo
            // 
            this.trackInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.trackInfo.Controls.Add(this.toggleAlbumCover);
            this.trackInfo.Controls.Add(this.bitrateValue);
            this.trackInfo.Controls.Add(this.bitrateLabel);
            this.trackInfo.Controls.Add(this.lengthValue);
            this.trackInfo.Controls.Add(this.yearValue);
            this.trackInfo.Controls.Add(this.albumValue);
            this.trackInfo.Controls.Add(this.titleValue);
            this.trackInfo.Controls.Add(this.artistValue);
            this.trackInfo.Controls.Add(this.lengthLabel);
            this.trackInfo.Controls.Add(this.yearLabel);
            this.trackInfo.Controls.Add(this.albumLabel);
            this.trackInfo.Controls.Add(this.titleLabel);
            this.trackInfo.Controls.Add(this.artistLabel);
            this.trackInfo.Location = new System.Drawing.Point(36, 463);
            this.trackInfo.Name = "trackInfo";
            this.trackInfo.Padding = new System.Windows.Forms.Padding(3);
            this.trackInfo.Size = new System.Drawing.Size(300, 157);
            this.trackInfo.TabIndex = 12;
            // 
            // toggleAlbumCover
            // 
            this.toggleAlbumCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.toggleAlbumCover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleAlbumCover.BackgroundImage")));
            this.toggleAlbumCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggleAlbumCover.FlatAppearance.BorderSize = 0;
            this.toggleAlbumCover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.toggleAlbumCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleAlbumCover.ForeColor = System.Drawing.Color.White;
            this.toggleAlbumCover.Location = new System.Drawing.Point(280, 6);
            this.toggleAlbumCover.Name = "toggleAlbumCover";
            this.toggleAlbumCover.Size = new System.Drawing.Size(14, 14);
            this.toggleAlbumCover.TabIndex = 12;
            this.toggleAlbumCover.UseVisualStyleBackColor = false;
            this.toggleAlbumCover.Click += new System.EventHandler(this.toggleAlbumCover_Click_1);
            // 
            // bitrateValue
            // 
            this.bitrateValue.AutoSize = true;
            this.bitrateValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitrateValue.Location = new System.Drawing.Point(79, 127);
            this.bitrateValue.Name = "bitrateValue";
            this.bitrateValue.Size = new System.Drawing.Size(15, 15);
            this.bitrateValue.TabIndex = 11;
            this.bitrateValue.Text = "--";
            // 
            // bitrateLabel
            // 
            this.bitrateLabel.AutoSize = true;
            this.bitrateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitrateLabel.Location = new System.Drawing.Point(10, 128);
            this.bitrateLabel.Name = "bitrateLabel";
            this.bitrateLabel.Size = new System.Drawing.Size(45, 15);
            this.bitrateLabel.TabIndex = 10;
            this.bitrateLabel.Text = "Bitrate";
            // 
            // lengthValue
            // 
            this.lengthValue.AutoSize = true;
            this.lengthValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthValue.Location = new System.Drawing.Point(75, 101);
            this.lengthValue.Name = "lengthValue";
            this.lengthValue.Padding = new System.Windows.Forms.Padding(4);
            this.lengthValue.Size = new System.Drawing.Size(23, 23);
            this.lengthValue.TabIndex = 9;
            this.lengthValue.Text = "--";
            // 
            // yearValue
            // 
            this.yearValue.AutoSize = true;
            this.yearValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearValue.Location = new System.Drawing.Point(75, 78);
            this.yearValue.Name = "yearValue";
            this.yearValue.Padding = new System.Windows.Forms.Padding(4);
            this.yearValue.Size = new System.Drawing.Size(23, 23);
            this.yearValue.TabIndex = 8;
            this.yearValue.Text = "--";
            // 
            // albumValue
            // 
            this.albumValue.AutoSize = true;
            this.albumValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumValue.Location = new System.Drawing.Point(75, 55);
            this.albumValue.Name = "albumValue";
            this.albumValue.Padding = new System.Windows.Forms.Padding(4);
            this.albumValue.Size = new System.Drawing.Size(23, 23);
            this.albumValue.TabIndex = 7;
            this.albumValue.Text = "--";
            // 
            // titleValue
            // 
            this.titleValue.AutoSize = true;
            this.titleValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleValue.Location = new System.Drawing.Point(75, 32);
            this.titleValue.Name = "titleValue";
            this.titleValue.Padding = new System.Windows.Forms.Padding(4);
            this.titleValue.Size = new System.Drawing.Size(23, 23);
            this.titleValue.TabIndex = 6;
            this.titleValue.Text = "--";
            // 
            // artistValue
            // 
            this.artistValue.AutoSize = true;
            this.artistValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistValue.Location = new System.Drawing.Point(75, 9);
            this.artistValue.Name = "artistValue";
            this.artistValue.Padding = new System.Windows.Forms.Padding(4);
            this.artistValue.Size = new System.Drawing.Size(23, 23);
            this.artistValue.TabIndex = 5;
            this.artistValue.Text = "--";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(6, 101);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Padding = new System.Windows.Forms.Padding(4);
            this.lengthLabel.Size = new System.Drawing.Size(54, 23);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(6, 78);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Padding = new System.Windows.Forms.Padding(4);
            this.yearLabel.Size = new System.Drawing.Size(40, 23);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLabel.Location = new System.Drawing.Point(6, 55);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Padding = new System.Windows.Forms.Padding(4);
            this.albumLabel.Size = new System.Drawing.Size(51, 23);
            this.albumLabel.TabIndex = 2;
            this.albumLabel.Text = "Album";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(6, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(4);
            this.titleLabel.Size = new System.Drawing.Size(39, 23);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.Location = new System.Drawing.Point(6, 9);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Padding = new System.Windows.Forms.Padding(4);
            this.artistLabel.Size = new System.Drawing.Size(46, 23);
            this.artistLabel.TabIndex = 0;
            this.artistLabel.Text = "Artist";
            // 
            // albumCover
            // 
            this.albumCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.albumCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumCover.Location = new System.Drawing.Point(36, 163);
            this.albumCover.Name = "albumCover";
            this.albumCover.Size = new System.Drawing.Size(300, 300);
            this.albumCover.TabIndex = 13;
            this.albumCover.TabStop = false;
            // 
            // trackInfoMenu
            // 
            this.trackInfoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.trackInfoMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackInfoMenu.BackgroundImage")));
            this.trackInfoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.trackInfoMenu.FlatAppearance.BorderSize = 0;
            this.trackInfoMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.trackInfoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trackInfoMenu.ForeColor = System.Drawing.Color.White;
            this.trackInfoMenu.Location = new System.Drawing.Point(0, 590);
            this.trackInfoMenu.Name = "trackInfoMenu";
            this.trackInfoMenu.Size = new System.Drawing.Size(30, 30);
            this.trackInfoMenu.TabIndex = 13;
            this.trackInfoMenu.UseVisualStyleBackColor = false;
            this.trackInfoMenu.Click += new System.EventHandler(this.trackInfoMenu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 680F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Controls.Add(this.durationSlider, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.durationNow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.durationTotal, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.volumeSlider, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.volumeIcon, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.nowPlaying, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 623);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1198, 74);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // volumeIcon
            // 
            this.volumeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumeIcon.BackgroundImage")));
            this.volumeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.volumeIcon.Location = new System.Drawing.Point(1030, 40);
            this.volumeIcon.Name = "volumeIcon";
            this.volumeIcon.Size = new System.Drawing.Size(21, 23);
            this.volumeIcon.TabIndex = 15;
            this.volumeIcon.TabStop = false;
            this.volumeIcon.Click += new System.EventHandler(this.volumeIcon_Click);
            // 
            // volumeTooltip
            // 
            this.volumeTooltip.BackColor = System.Drawing.Color.Black;
            this.volumeTooltip.ForeColor = System.Drawing.Color.White;
            // 
            // playlistMenu
            // 
            this.playlistMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playlistMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistMenu.BackgroundImage")));
            this.playlistMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playlistMenu.FlatAppearance.BorderSize = 0;
            this.playlistMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.playlistMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistMenu.ForeColor = System.Drawing.Color.White;
            this.playlistMenu.Location = new System.Drawing.Point(0, 555);
            this.playlistMenu.Name = "playlistMenu";
            this.playlistMenu.Size = new System.Drawing.Size(30, 30);
            this.playlistMenu.TabIndex = 15;
            this.playlistMenu.UseVisualStyleBackColor = false;
            this.playlistMenu.Click += new System.EventHandler(this.playlistMenu_Click);
            // 
            // playlistPanel
            // 
            this.playlistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playlistPanel.Controls.Add(this.label1);
            this.playlistPanel.Controls.Add(this.playlistList);
            this.playlistPanel.Location = new System.Drawing.Point(342, 163);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(383, 457);
            this.playlistPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loaded playlist";
            // 
            // playlistList
            // 
            this.playlistList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playlistList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.playlistList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistList.ForeColor = System.Drawing.Color.White;
            this.playlistList.FormattingEnabled = true;
            this.playlistList.ItemHeight = 15;
            this.playlistList.Location = new System.Drawing.Point(3, 34);
            this.playlistList.Name = "playlistList";
            this.playlistList.Size = new System.Drawing.Size(377, 420);
            this.playlistList.TabIndex = 0;
            this.playlistList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.playlistList_DrawItem_1);
            this.playlistList.SelectedIndexChanged += new System.EventHandler(this.playlistList_SelectedIndexChanged);
            // 
            // durationSlider
            // 
            this.durationSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.durationSlider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.durationSlider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.durationSlider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel1.SetColumnSpan(this.durationSlider, 5);
            this.durationSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.durationSlider.ElapsedPenColorBottom = System.Drawing.Color.Teal;
            this.durationSlider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.durationSlider.Enabled = false;
            this.durationSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.durationSlider.ForeColor = System.Drawing.Color.White;
            this.durationSlider.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.durationSlider.Location = new System.Drawing.Point(43, 3);
            this.durationSlider.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.durationSlider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.durationSlider.Name = "durationSlider";
            this.durationSlider.ScaleDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.durationSlider.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.durationSlider.ShowDivisionsText = true;
            this.durationSlider.ShowSmallScale = false;
            this.durationSlider.Size = new System.Drawing.Size(1112, 31);
            this.durationSlider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationSlider.TabIndex = 4;
            this.durationSlider.Text = "colorSlider1";
            this.durationSlider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(114)))), ((int)(((byte)(166)))));
            this.durationSlider.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(147)))), ((int)(((byte)(173)))));
            this.durationSlider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(103)))), ((int)(((byte)(199)))));
            this.durationSlider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.durationSlider.ThumbSize = new System.Drawing.Size(16, 16);
            this.durationSlider.TickAdd = 0F;
            this.durationSlider.TickColor = System.Drawing.Color.White;
            this.durationSlider.TickDivide = 0F;
            this.durationSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.durationSlider.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.durationSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.durationSlider_MouseDown);
            this.durationSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.durationSlider_MouseUp);
            // 
            // volumeSlider
            // 
            this.volumeSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.volumeSlider.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.volumeSlider.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.volumeSlider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel1.SetColumnSpan(this.volumeSlider, 2);
            this.volumeSlider.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.volumeSlider.ElapsedPenColorBottom = System.Drawing.Color.Teal;
            this.volumeSlider.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.volumeSlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.volumeSlider.ForeColor = System.Drawing.Color.White;
            this.volumeSlider.LargeChange = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.volumeSlider.Location = new System.Drawing.Point(1058, 40);
            this.volumeSlider.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.volumeSlider.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.ScaleDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.volumeSlider.ScaleSubDivisions = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.volumeSlider.ShowDivisionsText = true;
            this.volumeSlider.ShowSmallScale = false;
            this.volumeSlider.Size = new System.Drawing.Size(78, 23);
            this.volumeSlider.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumeSlider.TabIndex = 13;
            this.volumeSlider.Text = "colorSlider1";
            this.volumeSlider.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(114)))), ((int)(((byte)(166)))));
            this.volumeSlider.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(147)))), ((int)(((byte)(173)))));
            this.volumeSlider.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(103)))), ((int)(((byte)(199)))));
            this.volumeSlider.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.volumeSlider.ThumbSize = new System.Drawing.Size(16, 16);
            this.volumeSlider.TickAdd = 5F;
            this.volumeSlider.TickColor = System.Drawing.Color.White;
            this.volumeSlider.TickDivide = 10F;
            this.volumeSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volumeSlider.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.volumeSlider.ValueChanged += new System.EventHandler(this.volumeSlider_ValueChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1198, 697);
            this.Controls.Add(this.playlistPanel);
            this.Controls.Add(this.playlistMenu);
            this.Controls.Add(this.trackInfoMenu);
            this.Controls.Add(this.albumCover);
            this.Controls.Add(this.trackInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.backgroundCredits);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.trackInfo.ResumeLayout(false);
            this.trackInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumCover)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeIcon)).EndInit();
            this.playlistPanel.ResumeLayout(false);
            this.playlistPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer timer1;
        private ColorSlider.ColorSlider durationSlider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label durationNow;
        private System.Windows.Forms.Label durationTotal;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button nextTrack;
        private System.Windows.Forms.Button previousTrack;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSongs;
        private System.Windows.Forms.Label nowPlaying;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button repeatButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.LinkLabel backgroundCredits;
        private System.Windows.Forms.Label trackName;
        private System.Windows.Forms.Panel trackInfo;
        private System.Windows.Forms.Label bitrateValue;
        private System.Windows.Forms.Label bitrateLabel;
        private System.Windows.Forms.Label lengthValue;
        private System.Windows.Forms.Label yearValue;
        private System.Windows.Forms.Label albumValue;
        private System.Windows.Forms.Label titleValue;
        private System.Windows.Forms.Label artistValue;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.PictureBox albumCover;
        private System.Windows.Forms.Button toggleAlbumCover;
        private System.Windows.Forms.Button trackInfoMenu;
        private ColorSlider.ColorSlider volumeSlider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox volumeIcon;
        private System.Windows.Forms.ToolTip volumeTooltip;
        private System.Windows.Forms.ToolTip controlsTooltip;
        private System.Windows.Forms.Button playlistMenu;
        private System.Windows.Forms.Panel playlistPanel;
        private System.Windows.Forms.ListBox playlistList;
        private System.Windows.Forms.Label label1;
    }
}

