namespace Math_Tools
{
    partial class Trails_Donbale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trails_Donbale));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_TD = new System.Windows.Forms.Button();
            this.button2_TD = new System.Windows.Forms.Button();
            this.button3_TD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Tools.Properties.Resources._42209946215_eb3a3f0cd6_b;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1_TD
            // 
            this.button1_TD.Location = new System.Drawing.Point(640, 12);
            this.button1_TD.Name = "button1_TD";
            this.button1_TD.Size = new System.Drawing.Size(446, 152);
            this.button1_TD.TabIndex = 3;
            this.button1_TD.Text = "دنباله حسابی";
            this.button1_TD.UseVisualStyleBackColor = true;
            this.button1_TD.Click += new System.EventHandler(this.button1_TD_Click);
            // 
            // button2_TD
            // 
            this.button2_TD.Location = new System.Drawing.Point(640, 170);
            this.button2_TD.Name = "button2_TD";
            this.button2_TD.Size = new System.Drawing.Size(446, 152);
            this.button2_TD.TabIndex = 4;
            this.button2_TD.Text = " دنباله هندسی";
            this.button2_TD.UseVisualStyleBackColor = true;
            this.button2_TD.Click += new System.EventHandler(this.button2_TD_Click);
            // 
            // button3_TD
            // 
            this.button3_TD.Location = new System.Drawing.Point(640, 328);
            this.button3_TD.Name = "button3_TD";
            this.button3_TD.Size = new System.Drawing.Size(446, 152);
            this.button3_TD.TabIndex = 5;
            this.button3_TD.Text = "دنباله فیبوناچی";
            this.button3_TD.UseVisualStyleBackColor = true;
            this.button3_TD.Click += new System.EventHandler(this.button3_TD_Click);
            // 
            // Trails_Donbale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 505);
            this.Controls.Add(this.button3_TD);
            this.Controls.Add(this.button2_TD);
            this.Controls.Add(this.button1_TD);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Trails_Donbale";
            this.Text = "Trails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1_TD;
        private System.Windows.Forms.Button button2_TD;
        private System.Windows.Forms.Button button3_TD;
    }
}