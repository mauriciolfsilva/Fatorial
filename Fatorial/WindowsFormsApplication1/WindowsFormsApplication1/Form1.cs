using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Iterativa_Click(object sender, EventArgs e)
        {
            double a = double.Parse(NumEnter.Text);
            double r = 1;

            for (var i = 1; i <= a; i++)
            {
                r *= i;
            }

            NumEnter.Text = r.ToString();
        }

        private void Recursiva_Click(object sender, EventArgs e)
        {
            NumEnter.Text = recursiva(double.Parse(NumEnter.Text)).ToString();
        }

        public double recursiva(double n1)
        {
            if (n1 == 0)
                return 1;
            return recursiva(n1 - 1) * n1;
        }
    }
}
