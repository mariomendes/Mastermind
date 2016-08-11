using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MastermindV2
{
    public partial class ColourControl : UserControl
    {
        public static Color SelectedColor = SystemColors.Control;

        public ColourControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            SelectedColor = b.BackColor;
            button9.BackColor = SelectedColor;
        }


    }
}
