namespace MastermindV2
{
    partial class GuessControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Button();
            this.color4 = new System.Windows.Forms.Button();
            this.rrBox = new System.Windows.Forms.Button();
            this.rwBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(135, 5);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(48, 45);
            this.color1.TabIndex = 0;
            this.color1.UseVisualStyleBackColor = true;
            this.color1.Click += new System.EventHandler(this.color4_Click);
            this.color1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color1_MouseDown);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(189, 5);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(48, 45);
            this.color2.TabIndex = 1;
            this.color2.UseVisualStyleBackColor = true;
            this.color2.Click += new System.EventHandler(this.color4_Click);
            this.color2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color1_MouseDown);
            // 
            // color3
            // 
            this.color3.Location = new System.Drawing.Point(243, 5);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(48, 45);
            this.color3.TabIndex = 2;
            this.color3.UseVisualStyleBackColor = true;
            this.color3.Click += new System.EventHandler(this.color4_Click);
            this.color3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color1_MouseDown);
            // 
            // color4
            // 
            this.color4.Location = new System.Drawing.Point(297, 5);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(48, 45);
            this.color4.TabIndex = 3;
            this.color4.UseVisualStyleBackColor = true;
            this.color4.Click += new System.EventHandler(this.color4_Click);
            this.color4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color1_MouseDown);
            // 
            // rrBox
            // 
            this.rrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.rrBox.Location = new System.Drawing.Point(8, 5);
            this.rrBox.Name = "rrBox";
            this.rrBox.Size = new System.Drawing.Size(48, 45);
            this.rrBox.TabIndex = 4;
            this.rrBox.UseVisualStyleBackColor = true;
            this.rrBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rrBox_KeyDown);
            this.rrBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rrBox_KeyUp);
            // 
            // rwBox
            // 
            this.rwBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.rwBox.Location = new System.Drawing.Point(62, 5);
            this.rwBox.Name = "rwBox";
            this.rwBox.Size = new System.Drawing.Size(48, 45);
            this.rwBox.TabIndex = 5;
            this.rwBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rwBox);
            this.Controls.Add(this.rrBox);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Name = "GuessControl";
            this.Size = new System.Drawing.Size(450, 55);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button rrBox;
        public System.Windows.Forms.Button rwBox;
        public System.Windows.Forms.Button color1;
        public System.Windows.Forms.Button color2;
        public System.Windows.Forms.Button color3;
        public System.Windows.Forms.Button color4;
        public System.Windows.Forms.Button button1;

    }
}
