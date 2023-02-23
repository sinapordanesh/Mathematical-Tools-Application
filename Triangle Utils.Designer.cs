namespace Math_Tools
{
    partial class Triangle_Utils
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triangle_Utils));
            this.textBox1_High = new System.Windows.Forms.TextBox();
            this.textBox2_SideA = new System.Windows.Forms.TextBox();
            this.textBox3_ShowArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4_SideC = new System.Windows.Forms.TextBox();
            this.textBox5_SideB = new System.Windows.Forms.TextBox();
            this.textBox6_SideA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2_CulcSideC = new System.Windows.Forms.Button();
            this.button2_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_High
            // 
            this.textBox1_High.Location = new System.Drawing.Point(62, 81);
            this.textBox1_High.Name = "textBox1_High";
            this.textBox1_High.Size = new System.Drawing.Size(205, 38);
            this.textBox1_High.TabIndex = 0;
            this.textBox1_High.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_High_KeyPress);
            // 
            // textBox2_SideA
            // 
            this.textBox2_SideA.Location = new System.Drawing.Point(62, 177);
            this.textBox2_SideA.Name = "textBox2_SideA";
            this.textBox2_SideA.Size = new System.Drawing.Size(205, 38);
            this.textBox2_SideA.TabIndex = 1;
            this.textBox2_SideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_High_KeyPress);
            // 
            // textBox3_ShowArea
            // 
            this.textBox3_ShowArea.Location = new System.Drawing.Point(62, 272);
            this.textBox3_ShowArea.Name = "textBox3_ShowArea";
            this.textBox3_ShowArea.ReadOnly = true;
            this.textBox3_ShowArea.Size = new System.Drawing.Size(205, 38);
            this.textBox3_ShowArea.TabIndex = 2;
            this.textBox3_ShowArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_High_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "ارتفاع";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "قاعده";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(362, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "مساحت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4_SideC
            // 
            this.textBox4_SideC.Location = new System.Drawing.Point(62, 588);
            this.textBox4_SideC.Name = "textBox4_SideC";
            this.textBox4_SideC.ReadOnly = true;
            this.textBox4_SideC.Size = new System.Drawing.Size(167, 38);
            this.textBox4_SideC.TabIndex = 6;
            this.textBox4_SideC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_High_KeyPress);
            // 
            // textBox5_SideB
            // 
            this.textBox5_SideB.Location = new System.Drawing.Point(62, 491);
            this.textBox5_SideB.Name = "textBox5_SideB";
            this.textBox5_SideB.Size = new System.Drawing.Size(167, 38);
            this.textBox5_SideB.TabIndex = 7;
            this.textBox5_SideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_High_KeyPress);
            // 
            // textBox6_SideA
            // 
            this.textBox6_SideA.Location = new System.Drawing.Point(62, 420);
            this.textBox6_SideA.Name = "textBox6_SideA";
            this.textBox6_SideA.Size = new System.Drawing.Size(167, 38);
            this.textBox6_SideA.TabIndex = 8;
            this.textBox6_SideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_High_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "انداره ضلع دوم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 55);
            this.label4.TabIndex = 10;
            this.label4.Text = "اندازه ضلع اول";
            // 
            // button2_CulcSideC
            // 
            this.button2_CulcSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_CulcSideC.Location = new System.Drawing.Point(308, 575);
            this.button2_CulcSideC.Name = "button2_CulcSideC";
            this.button2_CulcSideC.Size = new System.Drawing.Size(271, 60);
            this.button2_CulcSideC.TabIndex = 11;
            this.button2_CulcSideC.Text = "انداره ضلع سوم";
            this.button2_CulcSideC.UseVisualStyleBackColor = true;
            this.button2_CulcSideC.Click += new System.EventHandler(this.button2_CulcSideC_Click);
            // 
            // button2_Clear
            // 
            this.button2_Clear.Location = new System.Drawing.Point(62, 664);
            this.button2_Clear.Name = "button2_Clear";
            this.button2_Clear.Size = new System.Drawing.Size(517, 54);
            this.button2_Clear.TabIndex = 12;
            this.button2_Clear.Text = "Clear";
            this.button2_Clear.UseVisualStyleBackColor = true;
            this.button2_Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Triangle_Utils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 757);
            this.Controls.Add(this.button2_Clear);
            this.Controls.Add(this.button2_CulcSideC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6_SideA);
            this.Controls.Add(this.textBox5_SideB);
            this.Controls.Add(this.textBox4_SideC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3_ShowArea);
            this.Controls.Add(this.textBox2_SideA);
            this.Controls.Add(this.textBox1_High);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Triangle_Utils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_High;
        private System.Windows.Forms.TextBox textBox2_SideA;
        private System.Windows.Forms.TextBox textBox3_ShowArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4_SideC;
        private System.Windows.Forms.TextBox textBox5_SideB;
        private System.Windows.Forms.TextBox textBox6_SideA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2_CulcSideC;
        private System.Windows.Forms.Button button2_Clear;
    }
}