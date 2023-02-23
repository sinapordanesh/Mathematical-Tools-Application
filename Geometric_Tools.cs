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
    public partial class Geometric_Tools : Form
    {
        public Geometric_Tools()
        {
            InitializeComponent();
        }

        private void button1_GT_Click(object sender, EventArgs e)
        {
            Circle_Utils CU_GT = new Circle_Utils();
            CU_GT.ShowDialog();
        }

        private void button2_GT_Click(object sender, EventArgs e)
        {
            Triangle_Utils TU_GU = new Triangle_Utils();
            TU_GU.ShowDialog();
        }
    }
}
