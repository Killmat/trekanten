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
        string selected;
        private string Cosinus()
        {
            double a, b, c, A, B, C;
            switch (selected)
            {
                
                case "a,b,c":
                    double AUdregnet = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
                    double BUdregnet = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
                    double CUdregnet = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
                    break;
            }
            return "void";
        }
    }
}
