namespace Math_Tools
{
    partial class Number_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Number_Tools));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_NT = new System.Windows.Forms.Button();
            this.button2_NT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Tools.Properties.Resources._3006_5f268dfb0fbef44de0f668a022707b86;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1_NT
            // 
            this.button1_NT.Location = new System.Drawing.Point(640, 81);
            this.button1_NT.Name = "button1_NT";
            this.button1_NT.Size = new System.Drawing.Size(446, 152);
            this.button1_NT.TabIndex = 3;
            this.button1_NT.Text = "ماشین حساب";
            this.button1_NT.UseVisualStyleBackColor = true;
            this.button1_NT.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_NT
            // 
            this.button2_NT.Location = new System.Drawing.Point(640, 289);
            this.button2_NT.Name = "button2_NT";
            this.button2_NT.Size = new System.Drawing.Size(446, 152);
            this.button2_NT.TabIndex = 4;
            this.button2_NT.Text = "مرتب سازی اعداد";
            this.button2_NT.UseVisualStyleBackColor = true;
            this.button2_NT.Click += new System.EventHandler(this.button2_NT_Click);
            // 
            // Number_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 505);
            this.Controls.Add(this.button2_NT);
            this.Controls.Add(this.button1_NT);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Number_Tools";
            this.Text = "Number Tools";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1_NT;
        private System.Windows.Forms.Button button2_NT;
    }
}