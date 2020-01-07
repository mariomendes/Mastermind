using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MastermindV2
{
    public partial class GuessControl : UserControl
    {
        public List<Color> colours = new List<Color>();

        public GuessControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            color1.BackColor = SystemColors.Control;
            color2.BackColor = SystemColors.Control;
            color3.BackColor = SystemColors.Control;
            color4.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (color1.BackColor == SystemColors.Control | color2.BackColor == SystemColors.Control | color3.BackColor == SystemColors.Control | color4.BackColor == SystemColors.Control)
            {
                MessageBox.Show("Please fill each box with a colour before checking.");
                return;
            }
            if (Form1.colorSet == true)
                return;
            colours.Add(this.color1.BackColor);
            colours.Add(this.color2.BackColor);
            colours.Add(this.color3.BackColor);
            colours.Add(this.color4.BackColor);
            Form1.CheckGuess(this);
        }

        private void color4_Click(object sender, EventArgs e) //method to set colours of all colour boxes
        {
            foreach (Button b in this.Controls)
            {
                if (b.BackColor == ColourControl.SelectedColor)
                {
                    b.BackColor = SystemColors.Control;
                }

                Button btn = (Button)sender;
                btn.BackColor = ColourControl.SelectedColor;
            }
        }


        private void rrBox_KeyDown(object sender, KeyEventArgs e) //used as hack to see colours
        {
            if (e.KeyData == Keys.Delete)
            {
                Form1.ShowColours();
            }
        }

        private void rrBox_KeyUp(object sender, KeyEventArgs e) //used to hide colours
        {
            Form1.HideColours();
        }

        private void color1_MouseDown(object sender, MouseEventArgs e) //right click a colour to reset it to blank
        {
            if (Form1.colourControl1.button9.BackColor == new Button().BackColor)
            {
                MessageBox.Show("Please select a colour", "No colour selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;
                b.BackColor = SystemColors.Control;
            }
        }
    }
}
