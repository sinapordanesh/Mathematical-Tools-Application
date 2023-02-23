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
    public partial class Number_Sort : Form
    {
        public Number_Sort()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Number_Bool_Load(object sender, EventArgs e)
        {

        }

        private void button1_SortNumber_Click(object sender, EventArgs e)
        {
            string[] TempArray = new string[500];

            int rows = Myutils.CopyColumnToArray(dataGridView1, TempArray, 0);

            Myutils.BubbleSortArray(TempArray, rows);

            Myutils.CopyArrayToGrid(dataGridView2, TempArray, rows, 0);
        }

        private void button2_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }
    }
}
