using System.Windows.Forms;
namespace MastermindV2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guessControl20 = new MastermindV2.GuessControl();
            this.guessControl19 = new MastermindV2.GuessControl();
            this.guessControl18 = new MastermindV2.GuessControl();
            this.guessControl17 = new MastermindV2.GuessControl();
            this.guessControl16 = new MastermindV2.GuessControl();
            this.guessControl15 = new MastermindV2.GuessControl();
            this.guessControl14 = new MastermindV2.GuessControl();
            this.guessControl13 = new MastermindV2.GuessControl();
            this.guessControl12 = new MastermindV2.GuessControl();
            this.guessControl11 = new MastermindV2.GuessControl();
            this.guessControl10 = new MastermindV2.GuessControl();
            this.guessControl9 = new MastermindV2.GuessControl();
            this.guessControl8 = new MastermindV2.GuessControl();
            this.guessControl7 = new MastermindV2.GuessControl();
            this.guessControl6 = new MastermindV2.GuessControl();
            this.guessControl5 = new MastermindV2.GuessControl();
            this.guessControl4 = new MastermindV2.GuessControl();
            this.guessControl3 = new MastermindV2.GuessControl();
            this.guessControl2 = new MastermindV2.GuessControl();
            this.guessControl1 = new MastermindV2.GuessControl();
            this.colourControl1 = new MastermindV2.ColourControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.playerToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.playerToolStripMenuItem.Text = "1 Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem1
            // 
            this.playerToolStripMenuItem1.Name = "playerToolStripMenuItem1";
            this.playerToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.playerToolStripMenuItem1.Text = "2 Player";
            this.playerToolStripMenuItem1.Click += new System.EventHandler(this.playerToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToPlayToolStripMenuItem.Text = "&How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // guessControl20
            // 
            this.guessControl20.BackColor = System.Drawing.Color.Transparent;
            this.guessControl20.Location = new System.Drawing.Point(542, 81);
            this.guessControl20.Name = "guessControl20";
            this.guessControl20.Size = new System.Drawing.Size(450, 55);
            this.guessControl20.TabIndex = 22;
            // 
            // guessControl19
            // 
            this.guessControl19.BackColor = System.Drawing.Color.Transparent;
            this.guessControl19.Location = new System.Drawing.Point(542, 142);
            this.guessControl19.Name = "guessControl19";
            this.guessControl19.Size = new System.Drawing.Size(450, 55);
            this.guessControl19.TabIndex = 21;
            // 
            // guessControl18
            // 
            this.guessControl18.BackColor = System.Drawing.Color.Transparent;
            this.guessControl18.Location = new System.Drawing.Point(542, 203);
            this.guessControl18.Name = "guessControl18";
            this.guessControl18.Size = new System.Drawing.Size(450, 55);
            this.guessControl18.TabIndex = 20;
            // 
            // guessControl17
            // 
            this.guessControl17.BackColor = System.Drawing.Color.Transparent;
            this.guessControl17.Location = new System.Drawing.Point(542, 264);
            this.guessControl17.Name = "guessControl17";
            this.guessControl17.Size = new System.Drawing.Size(450, 55);
            this.guessControl17.TabIndex = 19;
            // 
            // guessControl16
            // 
            this.guessControl16.BackColor = System.Drawing.Color.Transparent;
            this.guessControl16.Location = new System.Drawing.Point(542, 325);
            this.guessControl16.Name = "guessControl16";
            this.guessControl16.Size = new System.Drawing.Size(450, 55);
            this.guessControl16.TabIndex = 18;
            // 
            // guessControl15
            // 
            this.guessControl15.BackColor = System.Drawing.Color.Transparent;
            this.guessControl15.Location = new System.Drawing.Point(542, 386);
            this.guessControl15.Name = "guessControl15";
            this.guessControl15.Size = new System.Drawing.Size(450, 55);
            this.guessControl15.TabIndex = 17;
            // 
            // guessControl14
            // 
            this.guessControl14.BackColor = System.Drawing.Color.Transparent;
            this.guessControl14.Location = new System.Drawing.Point(542, 447);
            this.guessControl14.Name = "guessControl14";
            this.guessControl14.Size = new System.Drawing.Size(450, 55);
            this.guessControl14.TabIndex = 16;
            // 
            // guessControl13
            // 
            this.guessControl13.BackColor = System.Drawing.Color.Transparent;
            this.guessControl13.Location = new System.Drawing.Point(542, 508);
            this.guessControl13.Name = "guessControl13";
            this.guessControl13.Size = new System.Drawing.Size(450, 55);
            this.guessControl13.TabIndex = 15;
            // 
            // guessControl12
            // 
            this.guessControl12.BackColor = System.Drawing.Color.Transparent;
            this.guessControl12.Location = new System.Drawing.Point(542, 569);
            this.guessControl12.Name = "guessControl12";
            this.guessControl12.Size = new System.Drawing.Size(450, 55);
            this.guessControl12.TabIndex = 14;
            // 
            // guessControl11
            // 
            this.guessControl11.BackColor = System.Drawing.Color.Transparent;
            this.guessControl11.Location = new System.Drawing.Point(542, 630);
            this.guessControl11.Name = "guessControl11";
            this.guessControl11.Size = new System.Drawing.Size(450, 55);
            this.guessControl11.TabIndex = 13;
            // 
            // guessControl10
            // 
            this.guessControl10.BackColor = System.Drawing.Color.Transparent;
            this.guessControl10.Location = new System.Drawing.Point(12, 81);
            this.guessControl10.Name = "guessControl10";
            this.guessControl10.Size = new System.Drawing.Size(447, 55);
            this.guessControl10.TabIndex = 9;
            // 
            // guessControl9
            // 
            this.guessControl9.BackColor = System.Drawing.Color.Transparent;
            this.guessControl9.Location = new System.Drawing.Point(12, 142);
            this.guessControl9.Name = "guessControl9";
            this.guessControl9.Size = new System.Drawing.Size(447, 55);
            this.guessControl9.TabIndex = 8;
            // 
            // guessControl8
            // 
            this.guessControl8.BackColor = System.Drawing.Color.Transparent;
            this.guessControl8.Location = new System.Drawing.Point(12, 203);
            this.guessControl8.Name = "guessControl8";
            this.guessControl8.Size = new System.Drawing.Size(447, 55);
            this.guessControl8.TabIndex = 7;
            // 
            // guessControl7
            // 
            this.guessControl7.BackColor = System.Drawing.Color.Transparent;
            this.guessControl7.Location = new System.Drawing.Point(12, 264);
            this.guessControl7.Name = "guessControl7";
            this.guessControl7.Size = new System.Drawing.Size(447, 55);
            this.guessControl7.TabIndex = 6;
            // 
            // guessControl6
            // 
            this.guessControl6.BackColor = System.Drawing.Color.Transparent;
            this.guessControl6.Location = new System.Drawing.Point(12, 325);
            this.guessControl6.Name = "guessControl6";
            this.guessControl6.Size = new System.Drawing.Size(447, 55);
            this.guessControl6.TabIndex = 5;
            // 
            // guessControl5
            // 
            this.guessControl5.BackColor = System.Drawing.Color.Transparent;
            this.guessControl5.Location = new System.Drawing.Point(12, 386);
            this.guessControl5.Name = "guessControl5";
            this.guessControl5.Size = new System.Drawing.Size(447, 55);
            this.guessControl5.TabIndex = 4;
            // 
            // guessControl4
            // 
            this.guessControl4.BackColor = System.Drawing.Color.Transparent;
            this.guessControl4.Location = new System.Drawing.Point(12, 447);
            this.guessControl4.Name = "guessControl4";
            this.guessControl4.Size = new System.Drawing.Size(447, 55);
            this.guessControl4.TabIndex = 3;
            // 
            // guessControl3
            // 
            this.guessControl3.BackColor = System.Drawing.Color.Transparent;
            this.guessControl3.Location = new System.Drawing.Point(12, 508);
            this.guessControl3.Name = "guessControl3";
            this.guessControl3.Size = new System.Drawing.Size(447, 55);
            this.guessControl3.TabIndex = 2;
            // 
            // guessControl2
            // 
            this.guessControl2.BackColor = System.Drawing.Color.Transparent;
            this.guessControl2.Location = new System.Drawing.Point(12, 569);
            this.guessControl2.Name = "guessControl2";
            this.guessControl2.Size = new System.Drawing.Size(447, 55);
            this.guessControl2.TabIndex = 1;
            // 
            // guessControl1
            // 
            this.guessControl1.BackColor = System.Drawing.Color.Transparent;
            this.guessControl1.Location = new System.Drawing.Point(12, 630);
            this.guessControl1.Name = "guessControl1";
            this.guessControl1.Size = new System.Drawing.Size(447, 55);
            this.guessControl1.TabIndex = 0;
            // 
            // colourControl1
            // 
            this.colourControl1.BackColor = System.Drawing.Color.Transparent;
            this.colourControl1.Location = new System.Drawing.Point(459, 27);
            this.colourControl1.Name = "colourControl1";
            this.colourControl1.Size = new System.Drawing.Size(82, 709);
            this.colourControl1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(542, 699);
            this.Controls.Add(this.guessControl20);
            this.Controls.Add(this.guessControl19);
            this.Controls.Add(this.guessControl18);
            this.Controls.Add(this.guessControl17);
            this.Controls.Add(this.guessControl16);
            this.Controls.Add(this.guessControl15);
            this.Controls.Add(this.guessControl14);
            this.Controls.Add(this.guessControl13);
            this.Controls.Add(this.guessControl12);
            this.Controls.Add(this.guessControl11);
            this.Controls.Add(this.guessControl10);
            this.Controls.Add(this.guessControl9);
            this.Controls.Add(this.guessControl8);
            this.Controls.Add(this.guessControl7);
            this.Controls.Add(this.guessControl6);
            this.Controls.Add(this.guessControl5);
            this.Controls.Add(this.guessControl4);
            this.Controls.Add(this.guessControl3);
            this.Controls.Add(this.guessControl2);
            this.Controls.Add(this.guessControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.colourControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mastermind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GuessControl guessControl1;
        private GuessControl guessControl2;
        private GuessControl guessControl3;
        private GuessControl guessControl4;
        private GuessControl guessControl5;
        private GuessControl guessControl6;
        private GuessControl guessControl7;
        private GuessControl guessControl8;
        private GuessControl guessControl9;
        private GuessControl guessControl10;
        private ColourControl colourControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private GuessControl guessControl11;
        private GuessControl guessControl12;
        private GuessControl guessControl13;
        private GuessControl guessControl14;
        private GuessControl guessControl15;
        private GuessControl guessControl16;
        private GuessControl guessControl17;
        private GuessControl guessControl18;
        private GuessControl guessControl19;
        private GuessControl guessControl20;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

