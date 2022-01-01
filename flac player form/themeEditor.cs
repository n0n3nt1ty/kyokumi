using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flac_player_form
{
    public partial class themeEditor : Form
    {
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
        public themeEditor()
        {
            InitializeComponent();
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
            ui_textBackgroundColor = Properties.Settings.Default.ui_textBackgroundColor;
            ui_primaryColor = Properties.Settings.Default.ui_primaryColor;
            ui_backgroundColor = Properties.Settings.Default.ui_backgroundColor;
            //ui_textSize;
            ui_textFont = Properties.Settings.Default.ui_textFont;

            //Update interface & previews according to settings
            //UI Panels
            textColorPanel.BackColor = Properties.Settings.Default.ui_textColor;
            textBackgroundColorPanel.BackColor = Properties.Settings.Default.ui_textBackgroundColor;
            primaryColorPanel.BackColor = Properties.Settings.Default.ui_primaryColor;
            backgroundColorPanel.BackColor = Properties.Settings.Default.ui_backgroundColor;
            //UI textboxes
            textColorTextBox.Text = "#" + Properties.Settings.Default.ui_textColor.R.ToString("X2") + Properties.Settings.Default.ui_textColor.G.ToString("X2") + Properties.Settings.Default.ui_textColor.B.ToString("X2");
            textBackgroundColorTextBox.Text = "#" + Properties.Settings.Default.ui_textBackgroundColor.R.ToString("X2") + Properties.Settings.Default.ui_textBackgroundColor.G.ToString("X2") + Properties.Settings.Default.ui_textBackgroundColor.B.ToString("X2");
            primaryColorTextBox.Text = "#" + Properties.Settings.Default.ui_primaryColor.R.ToString("X2") + Properties.Settings.Default.ui_primaryColor.G.ToString("X2") + Properties.Settings.Default.ui_primaryColor.B.ToString("X2");
            backgroundColorTextBox.Text = "#" + Properties.Settings.Default.ui_backgroundColor.R.ToString("X2") + Properties.Settings.Default.ui_backgroundColor.G.ToString("X2") + Properties.Settings.Default.ui_backgroundColor.B.ToString("X2");
            //fontSizeTrackBar.Value = Properties.Settings.Default.ui_textSize;

            //Load previews
            //UI Text preview
            textPreview.Font = Properties.Settings.Default.ui_textFont;
            textPreview.ForeColor = Properties.Settings.Default.ui_textColor;
            textPreview.BackColor = Properties.Settings.Default.ui_textBackgroundColor;
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
            }
            textColorTextBox.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            textPreview.ForeColor = color;
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
            }
            primaryColorTextBox.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        private void textBackgroundColorButton_Click(object sender, EventArgs e)
        {
            Color color = selectColor();
            if (color == Color.Empty)
            {
                color = Color.Black;
            }
            else
            {
                ui_textBackgroundColor = color;
                textBackgroundColorPanel.BackColor = color;
                textPreview.BackColor = color;
            }
            textBackgroundColorTextBox.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
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
            }
            backgroundColorTextBox.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
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
            //set UI Settings
            Properties.Settings.Default.ui_textColor = ui_textColor;
            Properties.Settings.Default.ui_textBackgroundColor = ui_textBackgroundColor;
            Properties.Settings.Default.ui_primaryColor = ui_primaryColor;
            Properties.Settings.Default.ui_backgroundColor = ui_backgroundColor;
            Properties.Settings.Default.ui_textSize = ui_textSize;
            Properties.Settings.Default.ui_textFont = ui_textFont;
            //Save
            Properties.Settings.Default.Save();
            themeEditor themeEditor = new themeEditor();
            themeEditor.Close();
        }
    }
}
