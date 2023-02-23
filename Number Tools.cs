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
    public partial class Number_Tools : Form
    {
        public Number_Tools()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simple_Calculator NT_SC = new Simple_Calculator();
            NT_SC.ShowDialog();
        }

        private void button2_NT_Click(object sender, EventArgs e)
        {
            Number_Sort NT_NB = new Number_Sort();
            NT_NB.ShowDialog();
        }
    }
}
