namespace Math_Tools
{
    partial class Fibonachi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fibonachi));
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5_ShowN = new System.Windows.Forms.TextBox();
            this.textBox4_Tedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3_JomleN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 46);
            this.button2.TabIndex = 23;
            this.button2.Text = "n نمایش جمله ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "n جمله ";
            // 
            // textBox5_ShowN
            // 
            this.textBox5_ShowN.Location = new System.Drawing.Point(271, 387);
            this.textBox5_ShowN.Name = "textBox5_ShowN";
            this.textBox5_ShowN.ReadOnly = true;
            this.textBox5_ShowN.Size = new System.Drawing.Size(269, 38);
            this.textBox5_ShowN.TabIndex = 21;
            this.textBox5_ShowN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_JomleN_KeyPress);
            // 
            // textBox4_Tedad
            // 
            this.textBox4_Tedad.Location = new System.Drawing.Point(271, 44);
            this.textBox4_Tedad.Name = "textBox4_Tedad";
            this.textBox4_Tedad.Size = new System.Drawing.Size(112, 38);
            this.textBox4_Tedad.TabIndex = 20;
            this.textBox4_Tedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_JomleN_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "تعداد جملات";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "نمایش دنباله";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(228, 518);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // textBox3_JomleN
            // 
            this.textBox3_JomleN.Location = new System.Drawing.Point(271, 258);
            this.textBox3_JomleN.Name = "textBox3_JomleN";
            this.textBox3_JomleN.Size = new System.Drawing.Size(112, 38);
            this.textBox3_JomleN.TabIndex = 16;
            this.textBox3_JomleN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_JomleN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 15;
            // 
            // button3_Clear
            // 
            this.button3_Clear.Location = new System.Drawing.Point(271, 447);
            this.button3_Clear.Name = "button3_Clear";
            this.button3_Clear.Size = new System.Drawing.Size(269, 61);
            this.button3_Clear.TabIndex = 24;
            this.button3_Clear.Text = "Clear";
            this.button3_Clear.UseVisualStyleBackColor = true;
            this.button3_Clear.Click += new System.EventHandler(this.button3_Clear_Click);
            // 
            // Fibonachi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 558);
            this.Controls.Add(this.button3_Clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5_ShowN);
            this.Controls.Add(this.textBox4_Tedad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3_JomleN);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fibonachi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonachi";
            this.Load += new System.EventHandler(this.Fibonachi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5_ShowN;
        private System.Windows.Forms.TextBox textBox4_Tedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3_JomleN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3_Clear;
    }
}