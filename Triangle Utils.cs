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
    public partial class Triangle_Utils : Form
    {
        public Triangle_Utils()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangleUtils tua = new triangleUtils();

            tua.High = Double.Parse(textBox1_High.Text);

            tua.SideA = Double.Parse(textBox2_SideA.Text);
                        
            tua.TriangleArea();

            textBox3_ShowArea.Text = tua.TriangleArea().ToString();
        }

        private void button2_CulcSideC_Click(object sender, EventArgs e)
        {
            triangleUtils tus = new triangleUtils();

            tus.SideA = Double.Parse(textBox6_SideA.Text);

            tus.SideB = Double.Parse(textBox5_SideB.Text);

            tus.Pythagorean();

            textBox4_SideC.Text = tus.Pythagorean().ToString();

        }

        private void textBox1_High_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
