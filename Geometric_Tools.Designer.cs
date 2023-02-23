namespace Math_Tools
{
    partial class Geometric_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geometric_Tools));
            this.button1_GT = new System.Windows.Forms.Button();
            this.button2_GT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_GT
            // 
            this.button1_GT.Location = new System.Drawing.Point(640, 68);
            this.button1_GT.Name = "button1_GT";
            this.button1_GT.Size = new System.Drawing.Size(446, 152);
            this.button1_GT.TabIndex = 3;
            this.button1_GT.Text = "ابزار دایره";
            this.button1_GT.UseVisualStyleBackColor = true;
            this.button1_GT.Click += new System.EventHandler(this.button1_GT_Click);
            // 
            // button2_GT
            // 
            this.button2_GT.Location = new System.Drawing.Point(640, 283);
            this.button2_GT.Name = "button2_GT";
            this.button2_GT.Size = new System.Drawing.Size(446, 152);
            this.button2_GT.TabIndex = 4;
            this.button2_GT.Text = "ابزار مثلث";
            this.button2_GT.UseVisualStyleBackColor = true;
            this.button2_GT.Click += new System.EventHandler(this.button2_GT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Tools.Properties.Resources._42_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Geometric_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 505);
            this.Controls.Add(this.button2_GT);
            this.Controls.Add(this.button1_GT);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Geometric_Tools";
            this.Text = "Geometric Tools";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1_GT;
        private System.Windows.Forms.Button button2_GT;
    }
}