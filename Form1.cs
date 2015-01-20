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
                A = Convert.ToDouble(storeA.Text);
            }
            if (storeB.Text.Length != 0)
            {
                B = Convert.ToDouble(storeB.Text);
            }
            if (storeC.Text.Length != 0)
            {
                C = Convert.ToDouble(storeC.Text);
            }
            switch (selected)
            {
                case "A,B,a":
                    C = 180 - A - B;
                    b = a * (Math.Sin(B * Math.PI / 180) / Math.Sin(A * Math.PI / 180));
                    c = a * (Math.Sin(C * Math.PI / 180) / Math.Sin(A * Math.PI / 180));
                    break;
                case "A,B,b":
                    C = 180 - A - B;
                    a = (Math.Sin(A * Math.PI / 180) * b) / Math.Sin(B * Math.PI / 180);
                    c = a * (Math.Sin(C * Math.PI / 180) / Math.Sin(A * Math.PI / 180));
                    break;
                case "A,B,c":
                    C = 180 - A - B;
                    a = (Math.Sin(A * Math.PI / 180) * c) / Math.Sin(C * Math.PI / 180);
                    b = Math.Sin(B * Math.PI / 180) * c / Math.Sin(C * Math.PI / 180);
                    break;
                case "A,C,a":
                    B = 180 - A - C;
                    b = Math.Sin(B * Math.PI / 180) * a / Math.Sin(A * Math.PI / 180);
                    c = Math.Sin(C * Math.PI / 180) * a / Math.Sin(A * Math.PI / 180);
                    break;
                case "A,C,b":
                    B = 180 - A - C;
                    a = (Math.Sin(A * Math.PI / 180) * b) / Math.Sin(B * Math.PI / 180);
                    c = Math.Sin(C * Math.PI / 180) * b / Math.Sin(B * Math.PI / 180);
                    break;
                case "A,C,c":
                    B = 180 - A - C;
                    a = (Math.Sin(A * Math.PI / 180) * c) / Math.Sin(C * Math.PI / 180);
                    b = Math.Sin(B * Math.PI / 180) * c / Math.Sin(C * Math.PI / 180);
                    break;
                case "A,a,b":
                    B = Math.Asin((Math.Sin(A * Math.PI / 180) * b) / a) * 180 / Math.PI;
                    C = 180 - A - B;
                    c = Math.Sin(C * Math.PI / 180) * a / Math.Sin(A * Math.PI / 180);
                    break;
                case "A,a,c":
                    C = Math.Asin((Math.Sin(A * Math.PI / 180) * c) / a) * 180 / Math.PI;
                    B = 180 - A - C;
                    b = Math.Sin(B * Math.PI / 180) * a / Math.Sin(A * Math.PI / 180);
                    break;
                case "A,b,c":
                    a = Math.Sqrt(b * b + c * c - 2 * b * c * Math.Cos(A * Math.PI / 180));
                    B = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
                    C = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI);
                    break;
                case "B,C,a":
                    C = 180 - A - B;
                    b = Math.Sin(B * Math.PI / 180) * a / Math.Sin(A * Math.PI / 180);
                    c = Math.Sin(C * Math.PI / 180) * a / Math.Sin(A * Math.PI / 180);
                    break;
                case "B,C,b":
                    A = 180 - B - C;
                    a = (Math.Sin(A * Math.PI / 180) * b) / Math.Sin(B * Math.PI / 180);
                    c = (Math.Sin(C * Math.PI / 180) * b) / Math.Sin(B * Math.PI / 180);
                    break;
                case "B,C,c":
                    A = 180 - B - C;
                    a = (Math.Sin(A * Math.PI / 180) * c) / Math.Sin(C * Math.PI / 180);
                    b = Math.Sin(B * Math.PI / 180) * c / Math.Sin(C * Math.PI / 180);
                    break;
                case "B,a,b":
                    A = Math.Asin((Math.Sin(B * Math.PI / 180) * a) / b) * 180 / Math.PI;
                    C = 180 - A - B;
                    c = (Math.Sin(C * Math.PI / 180) * a) / Math.Sin(A * Math.PI / 180);
                    break;
                case "B,a,c":
                    b = Math.Sqrt(a * a + c * c - 2 * a * c * Math.Cos(B * Math.PI / 180));
                    A = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
                    C = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI);
                    break;
                case "B,b,c":
                    C = Math.Asin((Math.Sin(B * Math.PI / 180) * c) / b) * 180 / Math.PI;
                    A = 180 - B - C;
                    a = (Math.Sin(A * Math.PI / 180) * b) / Math.Sin(B * Math.PI / 180);
                    break;
                case "C,a,b":
                    c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(C * Math.PI / 180));
                    A = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
                    B = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
                    break;
                case "C,a,c":
                    A = Math.Asin((Math.Sin(C * Math.PI / 180) * a) / c) * 180 / Math.PI;
                    B = 180 - A - C;
                    b = Math.Sin(B * Math.PI / 180) * a / Math.Sin(A * Math.PI / 180);
                    break;
                case "a,b,c":
                    A = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
                    B = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
                    C = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * (180 / Math.PI);
                    break;
            }
            storeA.Text = Convert.ToString(Math.Round(A, (int)numericUpDown1.Value));
            storeB.Text = Convert.ToString(Math.Round(B, (int)numericUpDown1.Value));
            storeC.Text = Convert.ToString(Math.Round(C, (int)numericUpDown1.Value));
            lilleA.Text = Convert.ToString(Math.Round(a, (int)numericUpDown1.Value));
            lilleB.Text = Convert.ToString(Math.Round(b, (int)numericUpDown1.Value));
            lilleC.Text = Convert.ToString(Math.Round(c, (int)numericUpDown1.Value));
            storeAudregn.Text = String.Format("cos^-1(({0}^2+{1}^2-{2}^2)/(2*{0}*{1}))", Math.Round(b, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value), Math.Round(a, (int)numericUpDown1.Value));
            storeBudregn.Text = String.Format("cos^-1(({0}^2+{1}^2-{2}^2)/(2*{0}*{1}))", Math.Round(a, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value), Math.Round(b, (int)numericUpDown1.Value));
            storeCudregn.Text = String.Format("cos^-1(({0}^2+{1}^2-{2}^2)/(2*{0}*{1}))", Math.Round(a, (int)numericUpDown1.Value), Math.Round(b, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value));
            lilleAudregn.Text = String.Format("√({0}^2+{1}^2-2*{0}*{1}*cos({2}))", Math.Round(b, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value), Math.Round(A, (int)numericUpDown1.Value));
            lilleBudregn.Text = String.Format("√({0}^2+{1}^2-2*{0}*{1}*cos({2}))", Math.Round(a, (int)numericUpDown1.Value), Math.Round(c, (int)numericUpDown1.Value), Math.Round(B, (int)numericUpDown1.Value));
            lilleCudregn.Text = String.Format("√({0}^2+{1}^2-2*{0}*{1}*cos({2}))", Math.Round(a, (int)numericUpDown1.Value), Math.Round(b, (int)numericUpDown1.Value), Math.Round(C, (int)numericUpDown1.Value));
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
            storeAudregn.Text = "";
            storeBudregn.Text = "";
            storeCudregn.Text = "";
            lilleAudregn.Text = "";
            lilleBudregn.Text = "";
            lilleCudregn.Text = "";
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