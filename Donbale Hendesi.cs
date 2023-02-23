using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Tools
{
    public partial class Donbale_Hendesi : Form
    {
        public Donbale_Hendesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(richTextBox1.Text == ""))

                richTextBox1.Clear();

            double a = Double.Parse(textBox1_Jomle1.Text);

            double b = Double.Parse(textBox2_Zarib.Text);

            int n = Int16.Parse(textBox4_Tedad.Text);

            richTextBox1.AppendText(a + "\n");

            for (int i = 1 ; i < n; i++)
            {

                a = a * b;

                richTextBox1.AppendText(a + "\n");

            }

        }

        private void textBox1_Jomle1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void textBox2_Zarib_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void textBox4_Tedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void textBox3_JomleN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void textBox5_ShowN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(textBox5_ShowN.Text == ""))

                textBox5_ShowN.Clear();

            double a = Double.Parse(textBox1_Jomle1.Text);

            double b = Double.Parse(textBox2_Zarib.Text);

            int n = Int16.Parse(textBox3_JomleN.Text);

            

            for (int i = 1; i < n; i++)
            {

                a = a * b;

            }

            textBox5_ShowN.AppendText(a.ToString());
        }

        private void button3_Clear_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
            richTextBox1.Clear();
        }
    }
}
