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
        double a = 0;
        double b = 0;
        double c = 0;
        private void Cosinus()
        {
            if (lilleA.Text.Length != 0)
            {
                a = Convert.ToDouble(lilleA.Text);
            }
            
            if (lilleB.Text.Length != 0)
            {
                b = Convert.ToDouble(lilleB.Text);
            }

            if (lilleC.Text.Length != 0)
            {
                c = Convert.ToDouble(lilleC.Text);
            }
            if (storeA.Text.Length != 0)
            {
                double A = Convert.ToDouble(storeA.Text);
            }
            if (storeB.Text.Length != 0)
            {
                double B = Convert.ToDouble(storeB.Text);
            }
            if (storeC.Text.Length != 0)
            {
                double C = Convert.ToDouble(storeC.Text);
            }
            switch (selected)
            {

                case "a,b,c":
                    double AUdregnet = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
                    double BUdregnet = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
                    double CUdregnet = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI);
                    storeA.Text = Convert.ToString(AUdregnet);
                    storeB.Text = Convert.ToString(BUdregnet);
                    storeC.Text = Convert.ToString(CUdregnet);
                    break;
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            selected = "";
            if (storeA.Text.Length != 0)
            {   
                selected += "A";
            }
            if (storeB.Text.Length != 0)
            {
                if (selected.Length == 0)
                {
                    selected += "B";
                }
                else
                {
                    selected += ",B";
                }
            }
            if (storeC.Text.Length != 0)
            {
                if (selected.Length == 0)
                {
                    selected += "C";
                }
                else
                {
                    selected += ",C";
                }
            }
            if (lilleA.Text.Length != 0 && selected.Length != 5)
            {
                if (selected.Length == 0)
                {
                    selected += "a";
                }
                else
                {
                    selected += ",a";
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
            Cosinus();
        }
    }
}
