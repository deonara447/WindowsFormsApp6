using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt16(textBox1.Text);
            int solvedSum = Sum(input);
            output.Text = "the sum is " + Convert.ToString(solvedSum);
        }


        public int Sum(int n)

        {

            if (n == 0 || n == 1)

            {

                return n;

            }

            else

            {

                return (n + Sum(n - 1));

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch myWatch = new Stopwatch();

            int input = Convert.ToInt16(textBox1.Text);

            myWatch.Reset();
            myWatch.Start();
            int recursive = recursiveFibonnaci(input);
            myWatch.Stop();
            TimeSpan elapsed2 = myWatch.Elapsed;

            myWatch.Reset();
            myWatch.Start();
            int nonRecursive = iterativeFibonnaci(input);
            myWatch.Stop();
            TimeSpan elapsed1 = myWatch.Elapsed;

            


            output.Text = "non recursive value is " + Convert.ToString(nonRecursive) + "\n"
                + "this method took " + Convert.ToString(elapsed1.TotalMilliseconds) + " ms" + "\n"
                + "recursive value is " + Convert.ToString(recursive) + "\n" +
                "this method took " + Convert.ToString(elapsed2.TotalMilliseconds) + " ms" ;
        }


        int iterativeFibonnaci(int nSize)
        {
            int nMinus2 = 0;
            int nMinus1 = 1;
            int n = 0;
            int counter = nSize;

            for (int x = 2; x <= counter; x++)
            {
                n = nMinus2 + nMinus1;
                nMinus2 = nMinus1;
                nMinus1 = n;
            }

            if (nSize == 0)
                return 0;
            else if (nSize == 1)
                return 1;
            else
                return n;
        }

        int recursiveFibonnaci(int nSize)
        {
            switch (nSize)
            {
                case 0:
                    return 0;
                    
                case 1:
                    return 1;
                    
                default:
                    return recursiveFibonnaci((nSize - 2)) + recursiveFibonnaci((nSize - 1));
            }
        }
    }
}
