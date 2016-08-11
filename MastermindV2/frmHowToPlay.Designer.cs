namespace MastermindV2
{
    partial class frmHowToPlay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guessControl1 = new MastermindV2.GuessControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The objective of Mastermind is to guess the colours and get them all in the corre" +
    "ct position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Below is a guess control, the two boxes on the far left indicate the colours you " +
    "have right in your guess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "and the four other boxes accept colours for your guess.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "The box with the green number indicates how many colours you have correct in the " +
    "correct position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(488, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "The box with the orange number indicates how many colours you have correct in the" +
    " incorrect position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(86, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "You have 10 guesses to figure out the combination of colours, Good Luck!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guessControl1
            // 
            this.guessControl1.BackColor = System.Drawing.Color.Transparent;
            this.guessControl1.Location = new System.Drawing.Point(35, 144);
            this.guessControl1.Name = "guessControl1";
            this.guessControl1.Size = new System.Drawing.Size(450, 55);
            this.guessControl1.TabIndex = 1;
            // 
            // frmHowToPlay
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmHowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to play";
            this.Load += new System.EventHandler(this.frmHowToPlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GuessControl guessControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}