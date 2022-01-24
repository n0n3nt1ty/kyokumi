using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace flac_player_form
{
    public partial class themeEditor : Form
    {
        //Preview variables
        bool shuffle = false;
        bool repeat = false;
        //UI settings
        Color ui_textColor;
        Color ui_textBackgroundColor;
        Color ui_primaryColor;
        Color ui_backgroundColor;
        decimal ui_textSize;
        Font ui_textFont;
        //Controls settings
        Color controls_playPauseBackColor;
        Color controls_previousBackColor;
        Color controls_nextBackColor;
        Color controls_repeatBackColor;
        Color controls_shuffleBackColor;
        Color controls_shuffleRepeatBorderColor;
        //Track slider settings
        Color trackSlider_elapsedInnerColor;
        Color trackSlider_elapsedPenColorTop;
        Color trackSlider_elapsedPenColorBottom;
        Color trackSlider_barInnerColor;
        Color trackSlider_barPenColorTop;
        Color trackSlider_barPenColorBottom;
        Color trackSlider_thumbInnerColor;
        Color trackSlider_thumbOuterColor;
        Color trackSlider_thumbPenColor;
        //Volume slider settings
        Color volumeSlider_elapsedInnerColor;
        Color volumeSlider_elapsedPenColorTop;
        Color volumeSlider_elapsedPenColorBottom;
        Color volumeSlider_barInnerColor;
        Color volumeSlider_barPenColorTop;
        Color volumeSlider_barPenColorBottom;
        Color volumeSlider_thumbInnerColor;
        Color volumeSlider_thumbOuterColor;
        Color volumeSlider_thumbPenColor;
        //Background settings
        string background_layout;
        string background_file;
        bool background_animated;
        Color background_fillColor;
        public themeEditor()
        {
            InitializeComponent();
        }
        string RGBBtoHEX(Color RGBcolor)
        {
            return "#" + RGBcolor.R.ToString("X2") + RGBcolor.G.ToString("X2") + RGBcolor.B.ToString("X2");
        }
        private Font selectFont()
        {
            Font selectedFont = null;
            fontDialog1.ShowColor = false;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = false;
            fontDialog1.ShowHelp = false;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                selectedFont = fontDialog1.Font;
            }
            return selectedFont;
        }
        private Color selectColor()
        {
            Color selectedColor = Color.Empty;
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorPicker.Color;
            }
            return selectedColor;
        }

        private void themeEditor_Load(object sender, EventArgs e)
        {
            ui_textFont = (Font)Font.Clone();
            textPreview.Font = ui_textFont;

            //##Update variables##
            //UI settings
            ui_textColor = Properties.Settings.Default.ui_textColor;
            ui_primaryColor = Properties.Settings.Default.ui_primaryColor;
            ui_backgroundColor = Properties.Settings.Default.ui_backgroundColor;
            //ui_textSize;
            ui_textFont = Properties.Settings.Default.ui_textFont;
            //Controls settings
            controls_nextBackColor = Properties.Settings.Default.controls_nextBackColor;
            controls_previousBackColor = Properties.Settings.Default.controls_previousBackColor;
            controls_playPauseBackColor = Properties.Settings.Default.controls_playPauseBackColor;
            controls_repeatBackColor = Properties.Settings.Default.controls_repeatBackColor;
            controls_shuffleBackColor = Properties.Settings.Default.controls_shuffleBackColor;
            controls_shuffleRepeatBorderColor = Properties.Settings.Default.controls_shuffleRepeatBorderColor;
            //Duration slider settings
            trackSlider_elapsedInnerColor = Properties.Settings.Default.trackSlider_elapsedInnerColor;
            trackSlider_elapsedPenColorTop = Properties.Settings.Default.trackSlider_elapsedPenColorTop;
            trackSlider_elapsedPenColorBottom = Properties.Settings.Default.trackSlider_elapsedPenColorBottom;
            trackSlider_barInnerColor = Properties.Settings.Default.trackSlider_barInnerColor;
            trackSlider_barPenColorTop = Properties.Settings.Default.trackSlider_barPenColorTop;
            trackSlider_barPenColorBottom = Properties.Settings.Default.trackSlider_barPenColorBottom;
            trackSlider_thumbInnerColor = Properties.Settings.Default.trackSlider_thumbInnerColor;
            trackSlider_thumbOuterColor = Properties.Settings.Default.trackSlider_thumbOuterColor;
            trackSlider_thumbPenColor = Properties.Settings.Default.trackSlider_thumbPenColor;
            //Volume slider settings
            volumeSlider_elapsedInnerColor = Properties.Settings.Default.volumeSlider_elapsedInnerColor;
            volumeSlider_elapsedPenColorTop = Properties.Settings.Default.volumeSlider_elapsedPenColorTop;
            volumeSlider_elapsedPenColorBottom = Properties.Settings.Default.volumeSlider_elapsedPenColorBottom;
            volumeSlider_barInnerColor = Properties.Settings.Default.volumeSlider_barInnerColor;
            volumeSlider_barPenColorTop = Properties.Settings.Default.volumeSlider_barPenColorTop;
            volumeSlider_barPenColorBottom = Properties.Settings.Default.volumeSlider_barPenColorBottom;
            volumeSlider_thumbInnerColor = Properties.Settings.Default.volumeSlider_thumbInnerColor;
            volumeSlider_thumbOuterColor = Properties.Settings.Default.volumeSlider_thumbOuterColor;
            volumeSlider_thumbPenColor = Properties.Settings.Default.volumeSlider_thumbPenColor;
            //Background settings
            background_layout = Properties.Settings.Default.background_layout;
            background_file = Properties.Settings.Default.background_file;
            background_animated = Properties.Settings.Default.background_animated;
            background_fillColor = Properties.Settings.Default.background_fillColor;


            //##Update interface & previews according to settings##
            //UI Panels
            textColorPanel.BackColor = Properties.Settings.Default.ui_textColor;
            primaryColorPanel.BackColor = Properties.Settings.Default.ui_primaryColor;
            backgroundColorPanel.BackColor = Properties.Settings.Default.ui_backgroundColor;
            //UI textboxes
            textColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.ui_textColor);
            primaryColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.ui_primaryColor);
            backgroundColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.ui_backgroundColor);
            //fontSizeTrackBar.Value = Properties.Settings.Default.ui_textSize;
            //Controls panels
            nextBackColorPanel.BackColor = Properties.Settings.Default.controls_nextBackColor;
            previousBackColorPanel.BackColor = Properties.Settings.Default.controls_previousBackColor;
            playPauseBackColorPanel.BackColor = Properties.Settings.Default.controls_playPauseBackColor;
            repeatBackColorPanel.BackColor = Properties.Settings.Default.controls_repeatBackColor;
            shuffleBackColorPanel.BackColor = Properties.Settings.Default.controls_shuffleBackColor;
            shuffleRepeatBorderColorPanel.BackColor = Properties.Settings.Default.controls_shuffleRepeatBorderColor;
            //Controls textboxes
            nextBackColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.controls_nextBackColor);
            previousBackColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.controls_previousBackColor);
            playPauseBackColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.controls_playPauseBackColor);
            repeatBackColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.controls_repeatBackColor);
            shuffleBackColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.controls_shuffleBackColor);
            shuffleRepeatBorderColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.controls_shuffleRepeatBorderColor);
            //Track duration slider panels
            elapsedInnerColorTrackPanel.BackColor = Properties.Settings.Default.trackSlider_elapsedInnerColor;
            elapsedPenColorTopTrackPanel.BackColor = Properties.Settings.Default.trackSlider_elapsedPenColorTop;
            elapsedPenColorBottomTrackPanel.BackColor = Properties.Settings.Default.trackSlider_elapsedPenColorBottom;
            barInnerColorTrackPanel.BackColor = Properties.Settings.Default.trackSlider_barInnerColor;
            barPenColorTopTrackPanel.BackColor = Properties.Settings.Default.trackSlider_barPenColorTop;
            barPenColorBottomTrackPanel.BackColor = Properties.Settings.Default.trackSlider_barPenColorBottom;
            thumbInnerColorTrackPanel.BackColor = Properties.Settings.Default.trackSlider_thumbInnerColor;
            thumbOuterColorTrackPanel.BackColor = Properties.Settings.Default.trackSlider_thumbOuterColor;
            penColorTrackPanel.BackColor = Properties.Settings.Default.trackSlider_thumbPenColor;
            //Track duration slider textboxes
            elapsedInnerColorTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_elapsedInnerColor);
            elapsedPenColorTopTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_elapsedPenColorTop);
            elapsedPenColorBottomTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_elapsedPenColorBottom);
            barInnerColorTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_barInnerColor);
            barPenColorTopTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_barPenColorTop);
            barPenColorBottomTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_barPenColorBottom);
            thumbInnerColorTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_thumbInnerColor);
            thumbOuterColorTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_thumbOuterColor);
            penColorTrackTextBox.Text = RGBBtoHEX(Properties.Settings.Default.trackSlider_thumbPenColor);
            //Volume slider panels
            elapsedInnerColorVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_elapsedInnerColor;
            elapsedPenColorTopVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_elapsedPenColorTop;
            elapsedPenColorBottomVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_elapsedPenColorBottom;
            barInnerColorVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_barInnerColor;
            barPenColorTopVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_barPenColorTop;
            barPenColorBottomVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_barPenColorBottom;
            thumbInnerColorVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_thumbInnerColor;
            thumbOuterColorVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_thumbOuterColor;
            penColorVolumePanel.BackColor = Properties.Settings.Default.volumeSlider_thumbPenColor;
            //Volume slider textboxes
            elapsedInnerColorVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_elapsedInnerColor);
            elapsedPenColorTopVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_elapsedPenColorTop);
            elapsedPenColorBottomVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_elapsedPenColorBottom);
            barInnerColorVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_barInnerColor);
            barPenColorTopVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_barPenColorTop);
            barPenColorBottomVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_barPenColorBottom);
            thumbInnerColorVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_thumbInnerColor);
            thumbOuterColorVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_thumbOuterColor);
            penColorVolumeTextBox.Text = RGBBtoHEX(Properties.Settings.Default.volumeSlider_thumbPenColor);
            //Background picture interface
            switch (Properties.Settings.Default.background_layout)
            {
                case "none":
                    background_layout = "none";
                    backgroundImageLayout.SelectedItem = "None";
                    break;
                case "tile":
                    background_layout = "tile";
                    backgroundImageLayout.SelectedItem = "Tile";
                    break;
                case "center":
                    background_layout = "center";
                    backgroundImageLayout.SelectedItem = "Center";
                    break;
                case "stretch":
                    background_layout = "stretch";
                    backgroundImageLayout.SelectedItem = "Stretch";
                    break;
                case "zoom":
                    background_layout = "zoom";
                    backgroundImageLayout.SelectedItem = "Zoom";
                    break;
            }
            backgroundImagePathTextBox.Text = Environment.CurrentDirectory + Properties.Settings.Default.background_file;
            animatedBackgroundCheck.Checked = Properties.Settings.Default.background_animated;
            backgroundFillColorPanel.BackColor = Properties.Settings.Default.background_fillColor;
            backgroundFillColorTextBox.Text = RGBBtoHEX(Properties.Settings.Default.background_fillColor);

            //Load previews
            //UI Text preview
            textPreview.Font = Properties.Settings.Default.ui_textFont;
            textPreview.ForeColor = Properties.Settings.Default.ui_textColor;
            textPreview.BackColor = Properties.Settings.Default.ui_backgroundColor;
            controlsBackgroundPanelPreview.BackColor = Properties.Settings.Default.ui_backgroundColor;
            //Controls preview
            controlsBackgroundPanelPreview.BackColor = Properties.Settings.Default.ui_backgroundColor;
            playButton.BackColor = Properties.Settings.Default.controls_playPauseBackColor;
            previousTrack.BackColor = Properties.Settings.Default.controls_previousBackColor;
            nextTrack.BackColor = Properties.Settings.Default.controls_nextBackColor;
            shuffleButton.BackColor = Properties.Settings.Default.controls_shuffleBackColor;
            repeatButton.BackColor = Properties.Settings.Default.controls_repeatBackColor;
            shuffleButton.FlatAppearance.BorderColor = Properties.Settings.Default.controls_shuffleRepeatBorderColor;
            repeatButton.FlatAppearance.BorderColor = Properties.Settings.Default.controls_shuffleRepeatBorderColor;
            //Track duration slider preview
            durationSliderPreview.ElapsedInnerColor = Properties.Settings.Default.trackSlider_elapsedInnerColor;
            durationSliderPreview.ElapsedPenColorTop = Properties.Settings.Default.trackSlider_elapsedPenColorTop;
            durationSliderPreview.ElapsedPenColorBottom = Properties.Settings.Default.trackSlider_elapsedPenColorBottom;
            durationSliderPreview.BarInnerColor = Properties.Settings.Default.trackSlider_barInnerColor;
            durationSliderPreview.BarPenColorTop = Properties.Settings.Default.trackSlider_barPenColorTop;
            durationSliderPreview.BarPenColorBottom = Properties.Settings.Default.trackSlider_barPenColorBottom;
            durationSliderPreview.ThumbInnerColor = Properties.Settings.Default.trackSlider_thumbInnerColor;
            durationSliderPreview.ThumbOuterColor = Properties.Settings.Default.trackSlider_thumbOuterColor;
            durationSliderPreview.ThumbPenColor = Properties.Settings.Default.trackSlider_thumbPenColor;
            //Volume slider preview
            volumeSliderPreview.ElapsedInnerColor = Properties.Settings.Default.volumeSlider_elapsedInnerColor;
            volumeSliderPreview.ElapsedPenColorTop = Properties.Settings.Default.volumeSlider_elapsedPenColorTop;
            volumeSliderPreview.ElapsedPenColorBottom = Properties.Settings.Default.volumeSlider_elapsedPenColorBottom;
            volumeSliderPreview.BarInnerColor = Properties.Settings.Default.volumeSlider_barInnerColor;
            volumeSliderPreview.BarPenColorTop = Properties.Settings.Default.volumeSlider_barPenColorTop;
            volumeSliderPreview.BarPenColorBottom = Properties.Settings.Default.volumeSlider_barPenColorBottom;
            volumeSliderPreview.ThumbInnerColor = Properties.Settings.Default.volumeSlider_thumbInnerColor;
            volumeSliderPreview.ThumbOuterColor = Properties.Settings.Default.volumeSlider_thumbOuterColor;
            volumeSliderPreview.ThumbPenColor = Properties.Settings.Default.volumeSlider_thumbPenColor;
            //Background picture preview
            backgroundPictureBox.BackColor = Properties.Settings.Default.background_fillColor;
            if (Properties.Settings.Default.background_animated == true)
            {
                backgroundPictureBox.Image = Image.FromFile(@"assets\" + Path.GetFileName(Properties.Settings.Default.background_file));
                backgroundPictureBox.BackgroundImage = null;
                backgroundImageLayout.Enabled = false;
                animatedBackgroundCheck.Checked = true;
            }
            else
            {
                backgroundPictureBox.BackgroundImage = Image.FromFile(@"assets\" + Path.GetFileName(Properties.Settings.Default.background_file));
                backgroundPictureBox.Image = null;
                animatedBackgroundCheck.Checked = false;
            }
            switch (Properties.Settings.Default.background_layout)
            {
                case "none":
                    backgroundImageLayout.SelectedItem = "None";
                    background_layout = "none";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.None;
                    break;
                case "tile":
                    backgroundImageLayout.SelectedItem = "Tile";
                    background_layout = "tile";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Tile;
                    break;
                case "center":
                    backgroundImageLayout.SelectedItem = "Center";
                    background_layout = "center";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case "stretch":
                    backgroundImageLayout.SelectedItem = "Stretch";
                    background_layout = "stretch";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "zoom":
                    backgroundImageLayout.SelectedItem = "Zoom";
                    background_layout = "zoom";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
            }

        }
        private void textColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.White;
            }
            else
            {
                ui_textColor = color;
                textColorPanel.BackColor = color;
                textColorTextBox.Text = RGBBtoHEX(color);
                textPreview.ForeColor = color;
            }
        }

        private void primaryColorBackground_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(91, 176, 225);
            }
            else
            {
                ui_primaryColor = color;
                primaryColorPanel.BackColor = color;
                primaryColorTextBox.Text = RGBBtoHEX(color);
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(25, 25, 25);
            }
            else
            {
                ui_backgroundColor = color;
                backgroundColorPanel.BackColor = color;
                backgroundColorTextBox.Text = RGBBtoHEX(color);
                controlsBackgroundPanelPreview.BackColor = color;
            }
        }

        private void fontSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ui_textSize = fontSizeTrackBar.Value;
            ui_textFont = new Font(ui_textFont.FontFamily, ((float)fontSizeTrackBar.Value / 100) * 9);
            textPreview.Font = ui_textFont;
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            Font font = selectFont();
            if (font == null)
            {

            }
            else
            {
                //Set the font
                ui_textFont = font;
                textPreview.Font = new Font(font.SystemFontName, ui_textFont.Size);
                //Adjust the size
                ui_textSize = fontSizeTrackBar.Value;
                ui_textFont = new Font(ui_textFont.FontFamily, ((float)fontSizeTrackBar.Value / 100) * 9);
                textPreview.Font = ui_textFont;
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            //Set UI Settings
            Properties.Settings.Default.ui_textColor = ui_textColor;
            Properties.Settings.Default.ui_primaryColor = ui_primaryColor;
            Properties.Settings.Default.ui_backgroundColor = ui_backgroundColor;
            //Properties.Settings.Default.ui_textSize = ui_textSize;
            Properties.Settings.Default.ui_textFont = ui_textFont;
            //Set Controls Settings
            Properties.Settings.Default.controls_shuffleRepeatBorderColor = controls_shuffleRepeatBorderColor;
            Properties.Settings.Default.controls_playPauseBackColor = controls_playPauseBackColor;
            Properties.Settings.Default.controls_nextBackColor = controls_nextBackColor;
            Properties.Settings.Default.controls_previousBackColor = controls_previousBackColor;
            Properties.Settings.Default.controls_shuffleBackColor = controls_shuffleBackColor;
            Properties.Settings.Default.controls_repeatBackColor = controls_repeatBackColor;
            //Set duration slider settings
            Properties.Settings.Default.trackSlider_elapsedInnerColor = trackSlider_elapsedInnerColor;
            Properties.Settings.Default.trackSlider_elapsedPenColorTop = trackSlider_elapsedPenColorTop;
            Properties.Settings.Default.trackSlider_elapsedPenColorBottom = trackSlider_elapsedPenColorBottom;
            Properties.Settings.Default.trackSlider_barInnerColor = trackSlider_barInnerColor;
            Properties.Settings.Default.trackSlider_barPenColorTop = trackSlider_barPenColorTop;
            Properties.Settings.Default.trackSlider_barPenColorBottom = trackSlider_barPenColorBottom;
            Properties.Settings.Default.trackSlider_thumbInnerColor = trackSlider_thumbInnerColor;
            Properties.Settings.Default.trackSlider_thumbOuterColor = trackSlider_thumbOuterColor;
            Properties.Settings.Default.trackSlider_thumbPenColor = trackSlider_thumbPenColor;
            //Set volume slider settings
            Properties.Settings.Default.volumeSlider_elapsedInnerColor = volumeSlider_elapsedInnerColor;
            Properties.Settings.Default.volumeSlider_elapsedPenColorTop = volumeSlider_elapsedPenColorTop;
            Properties.Settings.Default.volumeSlider_elapsedPenColorBottom = volumeSlider_elapsedPenColorBottom;
            Properties.Settings.Default.volumeSlider_barInnerColor = volumeSlider_barInnerColor;
            Properties.Settings.Default.volumeSlider_barPenColorTop = volumeSlider_barPenColorTop;
            Properties.Settings.Default.volumeSlider_barPenColorBottom = volumeSlider_barPenColorBottom;
            Properties.Settings.Default.volumeSlider_thumbInnerColor = volumeSlider_thumbInnerColor;
            Properties.Settings.Default.volumeSlider_thumbOuterColor = volumeSlider_thumbOuterColor;
            Properties.Settings.Default.volumeSlider_thumbPenColor = volumeSlider_thumbPenColor;
            //Background settings
            Properties.Settings.Default.background_layout = background_layout;
            Properties.Settings.Default.background_file = background_file;
            Properties.Settings.Default.background_animated = background_animated;
            Properties.Settings.Default.background_fillColor = background_fillColor;
            //Save & close
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void playPauseBackColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(25, 25, 25);
            }
            else
            {
                controls_playPauseBackColor = color;
                playPauseBackColorPanel.BackColor = color;
                playPauseBackColorTextBox.Text = RGBBtoHEX(color);
                playButton.BackColor = color;
            }
        }

        private void nextBackColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(25, 25, 25);
            }
            else
            {
                controls_nextBackColor = color;
                nextBackColorPanel.BackColor = color;
                nextBackColorTextBox.Text = RGBBtoHEX(color);
                nextTrack.BackColor = color;
            }
        }

        private void previousBackColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(25, 25, 25);
            }
            else
            {
                controls_previousBackColor = color;
                previousBackColorPanel.BackColor = color;
                previousBackColorTextBox.Text = RGBBtoHEX(color);
                previousTrack.BackColor = color;
            }
        }

        private void shuffleBackColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(25, 25, 25);
            }
            else
            {
                controls_shuffleBackColor = color;
                shuffleBackColorPanel.BackColor = color;
                shuffleBackColorTextBox.Text = RGBBtoHEX(color);
                shuffleButton.BackColor = color;
            }
        }

        private void repeatBackColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(25, 25, 25);
            }
            else
            {
                controls_repeatBackColor = color;
                repeatBackColorPanel.BackColor = color;
                repeatBackColorTextBox.Text = RGBBtoHEX(color);
                repeatButton.BackColor = color;
            }
        }

        private void shuffleRepeatBorderColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(25, 25, 25);
            }
            else
            {
                controls_shuffleRepeatBorderColor = color;
                shuffleRepeatBorderColorPanel.BackColor = color;
                shuffleRepeatBorderColorTextBox.Text = RGBBtoHEX(color);
                shuffleButton.FlatAppearance.BorderColor = color;
                repeatButton.FlatAppearance.BorderColor = color;
            }
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            if (shuffle == false)
            {
                shuffle = true;
                shuffleButton.FlatAppearance.BorderColor = controls_shuffleRepeatBorderColor;
            }
            else
            {
                shuffle = false;
                shuffleButton.FlatAppearance.BorderColor = ui_backgroundColor;
            }
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            if (repeat == false)
            {
                repeat = true;
                repeatButton.FlatAppearance.BorderColor = controls_shuffleRepeatBorderColor;
            }
            else
            {
                repeat = false;
                repeatButton.FlatAppearance.BorderColor = ui_backgroundColor;
            }
        }

        private void animatedBackgroundCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (animatedBackgroundCheck.Checked == true)
            {
                background_animated = true;
                backgroundImageLayout.Enabled = false;
                backgroundImageLayout.SelectedIndex = 0;
                background_layout = "none";
            }
            else
            {
                background_animated = false;
                backgroundImageLayout.Enabled = true;
                backgroundImageLayout.SelectedIndex = 0;
                background_layout = "none";
            }
            if (background_animated == true)
            {
                backgroundPictureBox.Image = Image.FromFile(@"assets\" + Path.GetFileName(background_file));
                backgroundPictureBox.BackgroundImage = null;
            }
            else
            {
                backgroundPictureBox.BackgroundImage = Image.FromFile(@"assets\" + Path.GetFileName(background_file));
                backgroundPictureBox.Image = null;
            }
        }

        private void browseBackgroundimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                File.Copy(openFileDialog1.FileName, @"assets\" + Path.GetFileName(openFileDialog1.FileName), true);
                backgroundImagePathTextBox.Text = System.Environment.CurrentDirectory + Path.GetFileName(openFileDialog1.FileName); ;
                background_file = @"assets\" + Path.GetFileName(openFileDialog1.FileName);
                if (background_animated == true)
                {
                    backgroundPictureBox.Image = Image.FromFile(background_file);
                    backgroundPictureBox.BackgroundImage = null;
                }
                else
                {
                    backgroundPictureBox.BackgroundImage = Image.FromFile(background_file);
                    backgroundPictureBox.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: couldn't choose this background.  " + ex.Message);
            }
        }

        private void defaultBackgroundImageButton_Click(object sender, EventArgs e)
        {
            background_file = @"assets\background.gif";
            background_animated = true;
            backgroundImageLayout.Enabled = false;
            backgroundImageLayout.SelectedIndex = 0;

            backgroundPictureBox.Image = Image.FromFile(@"assets\" + Path.GetFileName(background_file));
            backgroundPictureBox.BackgroundImage = null;
            background_layout = "none";
            backgroundPictureBox.BackgroundImageLayout = ImageLayout.None;
            animatedBackgroundCheck.Checked = true;
        }

        private void backgroundImageLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (backgroundImageLayout.SelectedItem)
            {
                case "None":
                    background_layout = "none";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.None;
                    break;
                case "Tile":
                    background_layout = "tile";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Tile;
                    break;
                case "Center":
                    background_layout = "center";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case "Stretch":
                    background_layout = "stretch";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Zoom":
                    background_layout = "zoom";
                    backgroundPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
            }

        }

        private void backgroundFillColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(21, 155, 179);
            }
            else
            {
                background_fillColor = color;
                backgroundPictureBox.BackColor = color;
                backgroundFillColorPanel.BackColor = color;
                backgroundFillColorTextBox.Text = RGBBtoHEX(color);
            }
        }

        private void elapsedInnerColorTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255);
            }
            else
            {
                trackSlider_elapsedInnerColor = color;
                elapsedInnerColorTrackPanel.BackColor = color;
                elapsedInnerColorTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.ElapsedInnerColor = color;
            }
        }

        private void elapsedPenColorTopTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(0, 192, 192);
            }
            else
            {
                trackSlider_elapsedPenColorTop = color;
                elapsedPenColorTopTrackPanel.BackColor = color;
                elapsedPenColorTopTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.ElapsedPenColorTop = color;
            }
        }

        private void elapsedPenColorBottomTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.Teal;
            }
            else
            {
                trackSlider_elapsedPenColorBottom = color;
                elapsedPenColorBottomTrackPanel.BackColor = color;
                elapsedPenColorBottomTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.ElapsedPenColorBottom = color;
            }
        }

        private void barInnerColorTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.Black;
            }
            else
            {
                trackSlider_barInnerColor = color;
                barInnerColorTrackPanel.BackColor = color;
                barInnerColorTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.BarInnerColor = color;
            }
        }

        private void barPenColorTopTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(55, 60, 74);
            }
            else
            {
                trackSlider_barPenColorTop = color;
                barPenColorTopTrackPanel.BackColor = color;
                barPenColorTopTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.BarPenColorTop = color;
            }
        }

        private void barPenColorBottomTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(87, 94, 110);
            }
            else
            {
                trackSlider_barPenColorBottom = color;
                barPenColorBottomTrackPanel.BackColor = color;
                barPenColorBottomTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.BarPenColorBottom = color;
            }
        }

        private void thumbInnerColorTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(51, 114, 166);
            }
            else
            {
                trackSlider_thumbInnerColor = color;
                thumbInnerColorTrackPanel.BackColor = color;
                thumbInnerColorTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.ThumbInnerColor = color;
            }
        }

        private void thumberOuterColorTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(22, 147, 173);
            }
            else
            {
                trackSlider_thumbOuterColor = color;
                thumbOuterColorTrackPanel.BackColor = color;
                thumbOuterColorTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.ThumbOuterColor = trackSlider_thumbOuterColor;
            }
        }

        private void penColorTrackButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(63, 103, 199);
            }
            else
            {
                trackSlider_thumbPenColor = color;
                penColorTrackPanel.BackColor = color;
                penColorTrackTextBox.Text = RGBBtoHEX(color);
                durationSliderPreview.ThumbPenColor = trackSlider_thumbPenColor;
            }
        }

        private void loadDefault_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to load the default settings?", "Default settings", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.background_file = @"assets\background.gif";
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                //do nothing 
            } 
        }

        private void elapsedInnerColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_elapsedInnerColor = color;
                elapsedInnerColorVolumePanel.BackColor = color;
                elapsedInnerColorVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.ElapsedInnerColor = color;
            }
        }

        private void elapsedPenColorTopButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_elapsedPenColorTop = color;
                elapsedPenColorTopVolumePanel.BackColor = color;
                elapsedPenColorTopVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.ElapsedPenColorTop = color;
            }
        }

        private void elapsedPenColorBottomButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_elapsedPenColorBottom = color;
                elapsedPenColorBottomVolumePanel.BackColor = color;
                elapsedPenColorBottomVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.ElapsedPenColorBottom = color;
            }
        }

        private void barInnerColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_barInnerColor = color;
                barInnerColorVolumePanel.BackColor = color;
                barInnerColorVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.BarInnerColor = color;
            }
        }

        private void barPenColorTopButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_barPenColorTop = color;
                barPenColorTopVolumePanel.BackColor = color;
                barPenColorTopVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.BarPenColorTop = color;
            }
        }

        private void barPenColorBottomButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_barPenColorBottom = color;
                barPenColorBottomVolumePanel.BackColor = color;
                barPenColorBottomVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.BarPenColorBottom = color;
            }
        }

        private void thumbInnerColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_thumbInnerColor = color;
                thumbInnerColorVolumePanel.BackColor = color;
                thumbInnerColorVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.ThumbInnerColor = color;
            }
        }

        private void thumbOuterColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_thumbOuterColor = color;
                thumbOuterColorVolumePanel.BackColor = color;
                thumbOuterColorVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.ThumbOuterColor = color;
            }
        }

        private void penColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.FromArgb(128, 255, 255); //edit this
            }
            else
            {
                volumeSlider_thumbPenColor = color;
                penColorVolumePanel.BackColor = color;
                penColorVolumeTextBox.Text = RGBBtoHEX(color);
                volumeSliderPreview.ThumbPenColor = color;
            }
        }
    }
}
