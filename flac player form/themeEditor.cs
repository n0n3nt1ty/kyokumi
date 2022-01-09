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


            //Update interface & previews according to settings
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
            Properties.Settings.Default.ui_textSize = ui_textSize;
            Properties.Settings.Default.ui_textFont = ui_textFont;
            //Set Controls Settings
            Properties.Settings.Default.controls_shuffleRepeatBorderColor = controls_shuffleRepeatBorderColor;
            Properties.Settings.Default.controls_playPauseBackColor = controls_playPauseBackColor;
            Properties.Settings.Default.controls_nextBackColor = controls_nextBackColor;
            Properties.Settings.Default.controls_previousBackColor = controls_previousBackColor;
            Properties.Settings.Default.controls_shuffleBackColor = controls_shuffleBackColor;
            Properties.Settings.Default.controls_repeatBackColor = controls_repeatBackColor;
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
            }
            else
            {
                background_animated = false;
            }
        }

        private void browseBackgroundimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            background_file = openFileDialog1.FileName;
            try
            {
                File.Copy(background_file, @"assets\" + Path.GetFileName(background_file));
                backgroundImagePathTextBox.Text = openFileDialog1.FileName;
                if (background_animated == false)
                {
                    backgroundPictureBox.Image = Image.FromFile(@"assets\" + Path.GetFileName(background_file));
                }
                else
                {
                    backgroundPictureBox.BackgroundImage = Image.FromFile(@"assets\" + Path.GetFileName(background_file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't choose this background: " + ex.Message);
            }
        }

        private void defaultBackgroundImageButton_Click(object sender, EventArgs e)
        {
            background_file = @"assets\background.gif";
            background_animated = true;
            backgroundPictureBox.BackgroundImage = Image.FromFile(@"assets\" + Path.GetFileName(background_file));
            background_layout = "tile";
            backgroundPictureBox.BackgroundImageLayout = ImageLayout.Tile;
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
    }
}
