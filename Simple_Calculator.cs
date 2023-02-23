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
    public partial class Simple_Calculator : Form
    {

        double ResultValu = 0;
        string Opration = "";
        bool isOpration = false;

        public Simple_Calculator()
        {
            InitializeComponent();
        }

        private void Simple_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Press_Buttun(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOpration) )

                textBox1.Clear();

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            isOpration = false;
        }

        private void Oprator_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Opration = button.Text;
            ResultValu = Double.Parse(textBox1.Text);
            isOpration = true;
        }

        private void buttonCleanE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ResultValu = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = VisualUtils.TextJustDigit(sender, e, 1);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (Opration)
            {
                case "+":
                    textBox1.Text = (ResultValu + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (ResultValu - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (ResultValu * Double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (ResultValu / Double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
