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
    public partial class Fibonachi : Form
    {
        public Fibonachi()
        {
            InitializeComponent();
        }

        private void Fibonachi_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_JomleN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(richTextBox1.Text == ""))

                richTextBox1.Clear();

            int a = 1;
            int b = 1;

            int Sat;

            int n = Int32.Parse(textBox4_Tedad.Text);


            if (n == 1)

                richTextBox1.AppendText("1" + "\n");

            else if (n >= 2)

                richTextBox1.AppendText("1" + "\n" + "1" + "\n");



            for ( int i = 0; i < (n - 2); i++)
            {
                Sat = a + b ;

                a = b;

                b = Sat;

                richTextBox1.AppendText(Sat + "\n");
  
            }
                 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(textBox5_ShowN.Text == ""))

                textBox5_ShowN.Clear();

            int a = 1;
            int b = 1;

            int Sat = 0;

            int n = Int32.Parse(textBox3_JomleN.Text);


            if (n == 1 || n == 2)

                textBox5_ShowN.AppendText("1");

            else if (n > 2)
            {
                for (int i = 0; i < (n - 2); i++)
                {
                    Sat = a + b;

                    a = b;

                    b = Sat;

                }


                textBox5_ShowN.AppendText(Sat.ToString());


            }



            

        }

        private void button3_Clear_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

                richTextBox1.Clear();
            }
        }
    }
}
