using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace flac_player_form
{
    public partial class main : Form
    {
        public LibVLC libVLC;
        public MediaPlayer mp;
        public List<string> playlist = new List<string>();
        bool shuffle = false;
        bool repeat = false;
        bool albumCoverVisible = false;
        bool trackInfoVisible = true;
        bool playlistVisible = false;
        int currentTrack = 0;
        public main()
        {
            InitializeComponent();
            LibVLCSharp.Shared.Core.Initialize();

        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void getAttributes()
        {
            trackName.Text = "";
            artistValue.Text = "";
            var file = TagLib.File.Create(playlist[currentTrack]);
            string title = file.Tag.Title;
            string album = file.Tag.Album;
            string year = "";
            string artist = "";
            string seconds_display = "";
            //Add 0 to seconds if less than 10
            if (file.Properties.Duration.Seconds <= 9)
            {
                seconds_display = "0" + file.Properties.Duration.Seconds.ToString();
            }
            else
            {
                seconds_display = file.Properties.Duration.Seconds.ToString();
            }
            //Check if tags exist, if not replace tags with unknown
            //Title
            if (String.IsNullOrWhiteSpace(title))
            {
                title = Path.GetFileNameWithoutExtension(file.Name);
            }
            else
            {
                if (title.Length > 25)
                {
                    title = title.Substring(0, 25) + "...";
                }
            }
            //Current Track
            trackName.Text = title + " by ";
            //Album
            if (String.IsNullOrWhiteSpace(file.Tag.Album))
            {
                album = "Unknown";
            }
            else if (album.Length > 25)
            {
                album = album.Substring(0, 25) + "...";
            }
            //Year
            if (file.Tag.Year == 0)
            {
                year = "Unknown";
            }
            else
            {
                year = file.Tag.Year.ToString();
            }
            //Artist
            try
            {
                artist = file.Tag.Performers[0];
                //Is the name too long?
                if (artist.Length > 25)
                {
                    artist = artist.Substring(0, 25) + "...";
                }
                //Current Track
                trackName.Text = trackName.Text + artist;

            }
            catch (Exception ex)
            {
                artist = "Unknown";
                //Current Track
                trackName.Text = trackName.Text + artist;
            }

            //Update track info labels
            artistValue.Text = artist;
            titleValue.Text = title;
            albumValue.Text = album;
            yearValue.Text = year;
            lengthValue.Text = file.Properties.Duration.Minutes.ToString() + ":" + seconds_display;
            bitrateValue.Text = file.Properties.AudioBitrate.ToString() + " kbps";

            //Set bitrate label color
            if (file.Properties.AudioBitrate <= 196)
            {
                bitrateValue.BackColor = Color.OrangeRed;
            }
            else if (file.Properties.AudioBitrate <= 320 && file.Properties.AudioBitrate > 196)
            {
                bitrateValue.BackColor = Color.Green;
            }
            else if (file.Properties.AudioBitrate <= 1000 && file.Properties.AudioBitrate > 320)
            {
                bitrateValue.BackColor = Color.FromArgb(22, 147, 173);
            }
            else if (file.Properties.AudioBitrate <= 1411 && file.Properties.AudioBitrate > 1000)
            {
                bitrateValue.BackColor = Color.Purple;
            }
            else if (file.Properties.AudioBitrate <= 99999 && file.Properties.AudioBitrate > 1411)
            {
                bitrateValue.BackColor = Color.Gold;
            }

            //Get cover
            //try to set the cover
            try
            {
                TagLib.IPicture cover = file.Tag.Pictures[0];
                MemoryStream ms = new MemoryStream(cover.Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                albumCover.BackgroundImage = System.Drawing.Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                toggleAlbumCover.BackgroundImage = System.Drawing.Image.FromFile(@"assets\up.png");
                albumCoverVisible = false;
                albumCover.Hide();
            }



        }
        private void play()
        {
            var media = new Media(libVLC, playlist[currentTrack]);
            mp.Play(media);
            System.Threading.Thread.Sleep(100);
            durationSlider.Maximum = mp.Media.Duration;
            timer1.Start();
            timer2.Start();
            getAttributes();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mp.IsPlaying == true)
            {
                mp.Pause();
            }
            else
            {
                mp.Play();
            }
            if (mp.State == VLCState.Ended)
            {
                play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mp.State == VLCState.Playing)
            {
                durationSlider.Enabled = true;
                previousTrack.Enabled = true;
                nextTrack.Enabled = true;
                durationSlider.Value = (long)(mp.Position * mp.Media.Duration);
                playButton.BackgroundImage = System.Drawing.Image.FromFile(@"assets\pause.png");
            }
            else
            {
                playButton.BackgroundImage = System.Drawing.Image.FromFile(@"assets\play.png");
            }

            if (mp.State == VLCState.Ended)
            {
                durationSlider.Value = durationSlider.Maximum;
                if (repeat == true)
                {
                    play();
                }
                else if (shuffle == true)
                {
                    Random rndTrack = new Random();
                    int nextTrack = rndTrack.Next(0, playlist.Count);
                    while (nextTrack == currentTrack)
                    {
                        nextTrack = rndTrack.Next(0, playlist.Count);
                    }
                    currentTrack = nextTrack;
                    playlistList.SelectedIndex = currentTrack;
                    play();
                }
                else
                {
                    if (currentTrack < playlist.Count - 1)
                    {
                        currentTrack++;
                        play();
                    }
                    else
                    {
                        currentTrack = 0;
                    }
                }
                playlistList.SelectedIndex = currentTrack;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialization process
            playlistList.CustomTabOffsets.Add(100);
            playlistList.UseCustomTabOffsets = true;
            libVLC = new LibVLC();
            mp = new MediaPlayer(libVLC);
            backgroundCredits.BackColor = System.Drawing.Color.Transparent;
            //Menu alignment
            trackInfoMenu.Location = new System.Drawing.Point(0, 590);
            playlistMenu.Location = new System.Drawing.Point(0, 555);
            playlistPanel.Location = new System.Drawing.Point(36, 163);
            //Hide/show panels
            albumCover.Hide();
            playlistPanel.Hide();
            //Tooltips
            controlsTooltip.SetToolTip(playButton, "Play/pause");
            controlsTooltip.SetToolTip(nextTrack, "Next track");
            controlsTooltip.SetToolTip(previousTrack, "Previous track");
            controlsTooltip.SetToolTip(shuffleButton, "Shuffle play");
            controlsTooltip.SetToolTip(repeatButton, "Repeat mode");
            //File dialog filter
            openSongs.Filter = "All Audio Files|*.wav;*.aac;*.flac;*.wma;*.wmv;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;";
        }

        private void durationSlider_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            mp.Pause();
        }

        private void durationSlider_MouseUp(object sender, MouseEventArgs e)
        {
            mp.Position = (float)((durationSlider.Value) / mp.Media.Duration);
            mp.Play();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Duration times calculation and display
            double sliderValue = (double)durationSlider.Value;
            TimeSpan currentTime = TimeSpan.FromMilliseconds(sliderValue);
            string timeSpan = string.Format("{0:D2}:{1:D2}",
                                    currentTime.Minutes,
                                    currentTime.Seconds);
            durationNow.Text = timeSpan;

            TimeSpan totalTime = TimeSpan.FromMilliseconds(mp.Media.Duration);
            string totalTimeSpan = string.Format("{0:D2}:{1:D2}",
                                    totalTime.Minutes,
                                    totalTime.Seconds);
            durationTotal.Text = totalTimeSpan;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSongs.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            playlist.Clear();
            playlistList.Items.Clear();
            currentTrack = 0;
            int trackIndex = 0;
            foreach (string file in openSongs.FileNames)
            {
                playlist.Add(file);
                //Get attributes to name item on playlist
                var track = TagLib.File.Create(playlist[trackIndex]);
                string trackTitle = track.Tag.Title;
                string trackArtist;
                string seconds_display;
                string playlistItemName = "";
                //Add 0 to seconds if less than 10
                if (track.Properties.Duration.Seconds <= 9)
                {
                    seconds_display = "0" + track.Properties.Duration.Seconds.ToString();
                }
                else
                {
                    seconds_display = track.Properties.Duration.Seconds.ToString();
                }
                //Check if tags exist, if not replace tags with unknown
                //Title
                if (String.IsNullOrWhiteSpace(trackTitle))
                {
                    trackTitle = Path.GetFileNameWithoutExtension(track.Name);
                }
                else
                {
                    trackTitle = track.Tag.Title.ToString();
                }
                //Artist
                try
                {
                    trackArtist = track.Tag.Performers[0];

                }
                catch (Exception ex)
                {
                    trackArtist = "Unknown";
                }
                //Update track info labels
                lengthValue.Text = track.Properties.Duration.Minutes.ToString() + ":" + seconds_display;
                playlistItemName = trackArtist + " — " + trackTitle;
                playlistList.Items.Add(playlistItemName);
                trackIndex++;
            }
            trackIndex = 0;
            playlistList.SelectedIndex = 0;
            //PLAY
            play();
            //Get cover
            //Try to set the cover
            var f = TagLib.File.Create(playlist[currentTrack]);
            try
            {
                TagLib.IPicture cover = f.Tag.Pictures[0];
                MemoryStream ms = new MemoryStream(cover.Data.Data);
                ms.Seek(0, SeekOrigin.Begin);
                albumCover.BackgroundImage = System.Drawing.Image.FromStream(ms);
                toggleAlbumCover.BackgroundImage = System.Drawing.Image.FromFile(@"assets\down.png");
                albumCover.Show();
                trackInfo.Show();
                albumCoverVisible = true;
                trackInfoVisible = true;
            }
            catch (Exception ex)
            {
                toggleAlbumCover.BackgroundImage = System.Drawing.Image.FromFile(@"assets\up.png");
                albumCoverVisible = false;
                albumCover.Hide();
            }
            //Get other attributes
            getAttributes();
        }

        private void nextTrack_Click(object sender, EventArgs e)
        {
            if (shuffle == true)
            {
                Random rndTrack = new Random();
                int nextTrack = rndTrack.Next(0, playlist.Count);
                while (nextTrack == currentTrack)
                {
                    nextTrack = rndTrack.Next(0, playlist.Count);
                }
                currentTrack = nextTrack;
            }
            else if (currentTrack < playlist.Count - 1)
            {
                currentTrack++;
            }
            else
            {
                currentTrack = 0;
            }
            playlistList.SelectedIndex = currentTrack;
        }

        private void previousTrack_Click(object sender, EventArgs e)
        {
            if (currentTrack > 0)
            {
                currentTrack--;
            }
            else
            {
                currentTrack = playlist.Count - 1;
            }
            playlistList.SelectedIndex = currentTrack;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutPage = new about();
            aboutPage.ShowDialog();
            aboutPage.TopLevel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                shuffle = true;
                shuffleButton.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                shuffle = false;
                shuffleButton.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (repeat == false)
            {
                repeat = true;
                repeatButton.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                repeat = false;
                repeatButton.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void backgroundCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pixel-city.tumblr.com/post/143713704161/late-vibes");
        }

        private void toggleAlbumCover_Click_1(object sender, EventArgs e)
        {
            if (albumCoverVisible == false)
            {
                albumCoverVisible = true;
                toggleAlbumCover.BackgroundImage = System.Drawing.Image.FromFile(@"assets\down.png");
                albumCover.Show();
            }
            else if (albumCoverVisible == true)
            {
                albumCoverVisible = false;
                toggleAlbumCover.BackgroundImage = System.Drawing.Image.FromFile(@"assets\up.png");
                albumCover.Hide();
            }
        }

        private void trackInfoMenu_Click(object sender, EventArgs e)
        {
            playlistPanel.Hide();
            playlistVisible = false;
            if (trackInfoVisible == false)
            {
                trackInfoVisible = true;
                trackInfo.Show();
                if (albumCoverVisible == false)
                {
                    albumCover.Hide();
                }
                else if (albumCoverVisible == true)
                {
                    albumCover.Show();
                }
            }
            else if (trackInfoVisible == true)
            {
                trackInfoVisible = false;
                trackInfo.Hide();
                albumCover.Hide();
            }
        }

        private void volumeSlider_ValueChanged(object sender, EventArgs e)
        {
            mp.Volume = (int)volumeSlider.Value;
            volumeTooltip.SetToolTip(volumeSlider, volumeSlider.Value.ToString() + "%");
            if (mp.Volume >= 50)
            {
                volumeIcon.BackgroundImage = System.Drawing.Image.FromFile(@"assets\high.png");
            }
            else if (mp.Volume < 50 && mp.Volume > 0)
            {
                volumeIcon.BackgroundImage = System.Drawing.Image.FromFile(@"assets\low.png");
            }
            else if (mp.Volume == 0)
            {
                mp.Volume = 0;
                volumeIcon.BackgroundImage = System.Drawing.Image.FromFile(@"assets\mute.png");
            }
        }

        private void volumeIcon_Click(object sender, EventArgs e)
        {
            if (mp.Volume > 0)
            {
                volumeSlider.Value = 0;
            }
            else
            {
                volumeSlider.Value = 30;
            }

        }

        private void playlistMenu_Click(object sender, EventArgs e)
        {
            trackInfoVisible = false;
            trackInfo.Hide();
            albumCover.Hide();
            if (playlistVisible == false)
            {
                playlistVisible = true;
                playlistPanel.Show();
            } else if (playlistVisible == true)
            {
                playlistVisible = false;
                playlistPanel.Hide();
            }
        }
        private void playlistList_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          Color.Black,
                                          Color.FromArgb(22, 147, 173));//Accent color
            e.DrawBackground();
            e.Graphics.DrawString(playlistList.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void playlistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTrack = playlistList.SelectedIndex;
            play();
        }
    }

}


