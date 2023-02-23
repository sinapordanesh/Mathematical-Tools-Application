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
    public partial class Circle_Utils : Form
    {

        public Circle_Utils()
        {
            InitializeComponent();
        }

        private void Circle_Utils_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CircleUtils cup = new CircleUtils();

            cup.Redius = Double.Parse(textBox1_Redius.Text);

            cup.Degree = Double.Parse(textBox2_Degree.Text);

            cup.CirclePrimeter();

            textBox4_ShowPrimeter.Text = cup.CirclePrimeter().ToString();
        }

        private void textBox1_Redius_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void textBox2_Degree_TextChanged(object sender, EventArgs e)
        {
            textBox2_Degree.MaxLength = 360;
        }

        private void textBox2_Degree_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CircleUtils cua = new CircleUtils() ;

            cua.Redius = Double.Parse(textBox1_Redius.Text);

            cua.Degree = Double.Parse(textBox2_Degree.Text);

            cua.CirecleArea();

            textBox3_ShowArea.Text = cua.CirecleArea().ToString();
        }

        private void button3_Volume_Click(object sender, EventArgs e)
        {
            CircleUtils cuv = new CircleUtils();

            cuv.Redius = Double.Parse(textBox1_Redius.Text);

            cuv.Degree = Double.Parse(textBox2_Degree.Text);

            cuv.CircleVolume();

            textBox5_ShowVolume.Text = cuv.CircleVolume().ToString();
        }

        private void button1_Clear_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
    }
}
