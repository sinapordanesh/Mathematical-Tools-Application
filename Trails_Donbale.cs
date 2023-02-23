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
    public partial class Trails_Donbale : Form
    {
        public Trails_Donbale()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_TD_Click(object sender, EventArgs e)
        {
            Donbale_Hesabi TD_DH = new Donbale_Hesabi();
            TD_DH.ShowDialog();
        }

        private void button2_TD_Click(object sender, EventArgs e)
        {
            Donbale_Hendesi TD_DHEN = new Donbale_Hendesi();
            TD_DHEN.ShowDialog();
        }

        private void button3_TD_Click(object sender, EventArgs e)
        {
            Fibonachi TD_FI = new Fibonachi();
            TD_FI.ShowDialog();
        }
    }
}
