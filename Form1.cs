using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trekanter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string selected = "Test";
        //private string Cosinus()
        //{
            //double a, b, c, A, B, C;
            //switch (selected)
            //{
                
            //    case "a,b,c":
            //        double AUdregnet = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            //        double BUdregnet = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            //        double CUdregnet = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
            //        break;
            //}
            //return "void";
        //}

        private void button1_Click(object sender, EventArgs e)
        {
                selected = "";
                if (storeA.Text.Length != 0)
                {
                    selected += "A";
                }
                if (storeB.Text.Length != 0)
                {
                    if (selected.Length > 0)
                    {
                        selected += ",B";
                    }
                    else
                    {
                        selected += "B";
                    }
                }
                if (storeC.Text.Length != 0)
                {
                    if (selected.Length > 0)
                    {
                        selected += ",C";
                    }
                    else
                    {
                        selected += "C";
                    }
                }
                if (lilleA.Text.Length != 0 && selected.Length != 5)
                {
                    if (selected.Length > 0)
                    {
                        selected += ",a";
                    }
                    else
                    {
                        selected += "a";
                    }
                }
                if (lilleB.Text.Length != 0 && selected.Length != 5)
                {
                    selected += ",b";
                }
                if (lilleC.Text.Length != 0 && selected.Length != 5)
                {
                    selected += ",c";
                }
                consoleOut.Text = selected;
            }
    }
}
