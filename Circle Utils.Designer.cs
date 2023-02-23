namespace Math_Tools
{
    partial class Circle_Utils
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circle_Utils));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_Redius = new System.Windows.Forms.TextBox();
            this.textBox2_Degree = new System.Windows.Forms.TextBox();
            this.button1_Primeter = new System.Windows.Forms.Button();
            this.button2_Area = new System.Windows.Forms.Button();
            this.textBox3_ShowArea = new System.Windows.Forms.TextBox();
            this.textBox4_ShowPrimeter = new System.Windows.Forms.TextBox();
            this.textBox5_ShowVolume = new System.Windows.Forms.TextBox();
            this.button3_Volume = new System.Windows.Forms.Button();
            this.button1_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = " (0 - 360) درجه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "شعاع";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1_Redius
            // 
            this.textBox1_Redius.Location = new System.Drawing.Point(92, 49);
            this.textBox1_Redius.Name = "textBox1_Redius";
            this.textBox1_Redius.Size = new System.Drawing.Size(187, 38);
            this.textBox1_Redius.TabIndex = 2;
            this.textBox1_Redius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_Redius_KeyPress);
            // 
            // textBox2_Degree
            // 
            this.textBox2_Degree.Location = new System.Drawing.Point(92, 141);
            this.textBox2_Degree.Name = "textBox2_Degree";
            this.textBox2_Degree.Size = new System.Drawing.Size(187, 38);
            this.textBox2_Degree.TabIndex = 3;
            this.textBox2_Degree.TextChanged += new System.EventHandler(this.textBox2_Degree_TextChanged);
            this.textBox2_Degree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_Degree_KeyPress);
            // 
            // button1_Primeter
            // 
            this.button1_Primeter.Location = new System.Drawing.Point(380, 266);
            this.button1_Primeter.Name = "button1_Primeter";
            this.button1_Primeter.Size = new System.Drawing.Size(278, 72);
            this.button1_Primeter.TabIndex = 4;
            this.button1_Primeter.Text = "محیط بر حسب درجه";
            this.button1_Primeter.UseVisualStyleBackColor = true;
            this.button1_Primeter.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_Area
            // 
            this.button2_Area.Location = new System.Drawing.Point(36, 266);
            this.button2_Area.Name = "button2_Area";
            this.button2_Area.Size = new System.Drawing.Size(278, 72);
            this.button2_Area.TabIndex = 5;
            this.button2_Area.Text = "مساحت بر حسب درجه";
            this.button2_Area.UseVisualStyleBackColor = true;
            this.button2_Area.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3_ShowArea
            // 
            this.textBox3_ShowArea.Location = new System.Drawing.Point(36, 365);
            this.textBox3_ShowArea.Name = "textBox3_ShowArea";
            this.textBox3_ShowArea.ReadOnly = true;
            this.textBox3_ShowArea.Size = new System.Drawing.Size(278, 38);
            this.textBox3_ShowArea.TabIndex = 6;
            this.textBox3_ShowArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_Redius_KeyPress);
            // 
            // textBox4_ShowPrimeter
            // 
            this.textBox4_ShowPrimeter.Location = new System.Drawing.Point(380, 365);
            this.textBox4_ShowPrimeter.Name = "textBox4_ShowPrimeter";
            this.textBox4_ShowPrimeter.ReadOnly = true;
            this.textBox4_ShowPrimeter.Size = new System.Drawing.Size(278, 38);
            this.textBox4_ShowPrimeter.TabIndex = 7;
            this.textBox4_ShowPrimeter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_Redius_KeyPress);
            // 
            // textBox5_ShowVolume
            // 
            this.textBox5_ShowVolume.Location = new System.Drawing.Point(219, 547);
            this.textBox5_ShowVolume.Name = "textBox5_ShowVolume";
            this.textBox5_ShowVolume.ReadOnly = true;
            this.textBox5_ShowVolume.Size = new System.Drawing.Size(278, 38);
            this.textBox5_ShowVolume.TabIndex = 9;
            this.textBox5_ShowVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_Redius_KeyPress);
            // 
            // button3_Volume
            // 
            this.button3_Volume.Location = new System.Drawing.Point(219, 450);
            this.button3_Volume.Name = "button3_Volume";
            this.button3_Volume.Size = new System.Drawing.Size(278, 72);
            this.button3_Volume.TabIndex = 11;
            this.button3_Volume.Text = "حجم بر حسب درجه";
            this.button3_Volume.UseVisualStyleBackColor = true;
            this.button3_Volume.Click += new System.EventHandler(this.button3_Volume_Click);
            // 
            // button1_Clear
            // 
            this.button1_Clear.Location = new System.Drawing.Point(36, 618);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Size = new System.Drawing.Size(622, 69);
            this.button1_Clear.TabIndex = 12;
            this.button1_Clear.Text = "Clear";
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click);
            // 
            // Circle_Utils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 733);
            this.Controls.Add(this.button1_Clear);
            this.Controls.Add(this.button3_Volume);
            this.Controls.Add(this.textBox5_ShowVolume);
            this.Controls.Add(this.textBox4_ShowPrimeter);
            this.Controls.Add(this.textBox3_ShowArea);
            this.Controls.Add(this.button2_Area);
            this.Controls.Add(this.button1_Primeter);
            this.Controls.Add(this.textBox2_Degree);
            this.Controls.Add(this.textBox1_Redius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Circle_Utils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle_Utils";
            this.Load += new System.EventHandler(this.Circle_Utils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_Redius;
        private System.Windows.Forms.TextBox textBox2_Degree;
        private System.Windows.Forms.Button button1_Primeter;
        private System.Windows.Forms.Button button2_Area;
        private System.Windows.Forms.TextBox textBox3_ShowArea;
        private System.Windows.Forms.TextBox textBox4_ShowPrimeter;
        private System.Windows.Forms.TextBox textBox5_ShowVolume;
        private System.Windows.Forms.Button button3_Volume;
        private System.Windows.Forms.Button button1_Clear;
    }
}