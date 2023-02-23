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
    class MyFramwork
    {
    }


    static public class VisualUtils
    {

        static public bool TextJustDigit(object sender, KeyPressEventArgs e, int SenderType)

        {
            bool Result = false;

            if (!(char.IsDigit(e.KeyChar))
                  &&
                   !(char.IsControl(e.KeyChar))
                  &&
                   !(e.KeyChar == '.'))

                Result = true;


            switch (SenderType)
            {

                case 1:

                    if (e.KeyChar == '.'
                        &&
                       (sender as TextBox).Text.IndexOf('.') > -1)

                        Result = true;


                    break;

                case 2:

                    if (e.KeyChar == '.'
                        &&
                       (sender as RichTextBox).Text.IndexOf('.') > -1)

                        Result = true;


                    break;

                default:
                    break;
            }



            return Result;



        }



    }


    class DonbaleHesabi
    {
        int n;


        double a
             , b;


        public double JomleAvval
        {
            set { a = value; }
        }

        public double FaseleJomalat
        {
            set { b = value; }
        }

        public int JomleN
        {
            set { n = value; }
        }



        
    }



    public class CircleUtils
    {
        const double Pi = 3.14;

        Double r
             , a
             , prm
             , d
             , h
             , v ;

        public double Redius
        {
            get { return r; }
            set { r = value; }
        }

        public double Area
        {
            get { return a; }
            //set { a = value; }
        }

        public double Primeter
        {
            get { return prm; }
            //set { prm = value; }
        }

        public double Degree
        {
           // get { return d; }
            set { d = value; }
        }

        public double High
        {
            //get { return h; }
            set { h = value; }
        }
        public double Volume
        {
            get { return v;  }
            //set { v = value; }
        }


        public double CirecleArea()
        {
            a = Pi * (r * r) * (d / 360 ) ;

            return a;
        }

        public double CirclePrimeter()
        {
            prm = Pi * (r * 2) * (d / 360 );

            return prm;
        }

        public double CircleVolume()
        {
            v = (4 / 3) * (Pi) * (r * r * r) * (d / 360);

            return v;
        }
    }


    public class triangleUtils
    {
        double a
               , b
               , c
               , h
               , ar ;

        public double SideA
        {
            //get { return a; }
            set { a = value; }
        }

        public double SideB
        {
            //get { return b; }
            set { b = value; }
        }

        public double SideC
        {
            get { return c; }
            //set { c = value; }
        }

        public double High
        {
            //get { return h; }
            set { h = value; }
        }

        public double Area
        {
            get { return ar; }
            //set { ar = value; }
        }


        public double TriangleArea()
        {
            ar = ( (1/2) * (a * h) );

            return ar;
        }

        public double Pythagorean()
        {
            c = Math.Sqrt((a * a) + (b * b));

            return c;
        }
    }

    public static class Myutils
    {

        static public int CopyColumnToArray(DataGridView grid, string[] array, int ColumnIndex)
        {



            int c = 0;

            while (c < grid.Rows.Count - 1)
            {
                array[c] = grid[ColumnIndex, c].Value.ToString();

                c++;

            }


            return c;
        }



        static public int CopyArrayToGrid(DataGridView grid, string[] array, int rows, int columnIndex)
        {

            int c = 0;

            while (grid.RowCount - 1 < rows)

                grid.Rows.Add();



            c = 0;

            while (c < grid.Rows.Count)
            {

                grid[columnIndex, c].Value = array[c];

                c++;
            }


            return c;
        }



        static public void BubbleSortArray(string[] array, int ArrayLimit)
        {

            int outerLoopCounter = 0;

            int innerLoopCounter = 0;


            while (outerLoopCounter < ArrayLimit - 1)
            {
                innerLoopCounter = 0;

                while (innerLoopCounter < (ArrayLimit - outerLoopCounter) - 1)
                {
                    string temp = "";

                    if (Convert.ToDouble(array[innerLoopCounter + 1]) < Convert.ToDouble(array[innerLoopCounter]))
                    {
                        temp = array[innerLoopCounter];
                        array[innerLoopCounter] = array[innerLoopCounter + 1];
                        array[innerLoopCounter + 1] = temp;

                    }

                    innerLoopCounter++;
                }

                outerLoopCounter++;
            }
        }


    }

}
