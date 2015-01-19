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
        double A = 0;
        double B = 0;
        double C = 0;
        private void Calculate()
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
        private void Cosinus()
        {
            if (lilleA.Text.Length != 0)
            {
                a = Convert.ToDouble(lilleA.Text.Replace(",", "."));
            }
            
            if (lilleB.Text.Length != 0)
            {
                b = Convert.ToDouble(lilleB.Text.Replace(",", "."));
            }

            if (lilleC.Text.Length != 0)
            {
                c = Convert.ToDouble(lilleC.Text.Replace(",", "."));
            }
            if (storeA.Text.Length != 0)
            {
                A = Convert.ToDouble(storeA.Text.Replace(",", "."));
            }
            if (storeB.Text.Length != 0)
            {
                B = Convert.ToDouble(storeB.Text.Replace(",", "."));
            }
            if (storeC.Text.Length != 0)
            {
                C = Convert.ToDouble(storeC.Text.Replace(",", "."));
            }
            switch (selected)
            {

                case "a,b,c":
                    A = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
                    B = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
                    C = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI);
                    break;
                case "C,a,b":
                    c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(C * Math.PI / 180)); 
                    A = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
                    B = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
                    break;
                case "A,b,c":
                    a = Math.Sqrt(b * b + c * c - 2 * b * c * Math.Cos(A * Math.PI / 180));
                    B = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
                    C = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI);
                    break;
            }
            storeA.Text = Convert.ToString(Math.Round(A, (int)numericUpDown1.Value)).Replace(".", ",");
            storeB.Text = Convert.ToString(Math.Round(B, (int)numericUpDown1.Value)).Replace(".", ",");
            storeC.Text = Convert.ToString(Math.Round(C, (int)numericUpDown1.Value)).Replace(".", ",");
            lilleA.Text = Convert.ToString(Math.Round(a, (int)numericUpDown1.Value)).Replace(".", ",");
            lilleB.Text = Convert.ToString(Math.Round(b, (int)numericUpDown1.Value)).Replace(".", ",");
            lilleC.Text = Convert.ToString(Math.Round(c, (int)numericUpDown1.Value)).Replace(".", ",");
            storeAudregn.Text = String.Format("cos^-1(({0}^2+{1}^2-{2}^2)/(2*{0}*{1}))", Math.Round(b, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value), Math.Round(a, (int)numericUpDown1.Value));
            storeBudregn.Text = String.Format("cos^-1(({0}^2+{1}^2-{2}^2)/(2*{0}*{1}))", Math.Round(a, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value), Math.Round(b, (int)numericUpDown1.Value));
            storeCudregn.Text = String.Format("cos^-1(({0}^2+{1}^2-{2}^2)/(2*{0}*{1}))", Math.Round(a, (int)numericUpDown1.Value), Math.Round(b, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value));
            lilleAudregn.Text = String.Format("√{0}^2+{1}^2-2*{0}*{1}*cos({2})", Math.Round(b, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value), Math.Round(b, (int)numericUpDown1.Value));
            lilleBudregn.Text = "";
            lilleCudregn.Text = "";
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Cosinus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            storeA.Text = "";
            storeB.Text = "";
            storeC.Text = "";
            lilleA.Text = "";
            lilleB.Text = "";
            lilleC.Text = "";
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Calculate();
            }
        }
    }
}
