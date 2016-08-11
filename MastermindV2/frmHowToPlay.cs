using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MastermindV2
{
    public partial class frmHowToPlay : Form
    {
        #region paintbackground
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Gray, Color.Black, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion

        public frmHowToPlay()
        {
            InitializeComponent();
        }

        private void frmHowToPlay_Load(object sender, EventArgs e)
        {
            guessControl1.rrBox.Text = "1";
            guessControl1.rwBox.Text = "1";
            guessControl1.button1.Enabled = false;
            this.button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
