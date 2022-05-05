using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio214
{
    public partial class Ejercicio214 : Form
    {
        public Ejercicio214()
        {
            InitializeComponent();
        }

        private void BMayor_Click(object sender, EventArgs e)
        {
            bool test;
            double num1, num2;
            num1 = double.Parse(TNum1.Text);
            num2 = double.Parse(TNum2.Text);
            test = num1 > num2;
            LResulotado.Text = test.ToString();
        }

        private void BMenor_Click(object sender, EventArgs e)
        {
            bool test;
            double num1, num2;
            num1 = double.Parse(TNum1.Text);
            num2 = double.Parse(TNum2.Text);
            test = num1 < num2;
            LResulotado.Text = test.ToString();
        }

        private void BIgual_Click(object sender, EventArgs e)
        {
            bool test;
            double num1, num2;
            num1 = double.Parse(TNum1.Text);
            num2 = double.Parse(TNum2.Text);
            test = num1 == num2;
            LResulotado.Text = test.ToString();
        }

        private void BDistinto_Click(object sender, EventArgs e)
        {
            bool test;
            double num1, num2;
            num1 = double.Parse(TNum1.Text);
            num2 = double.Parse(TNum2.Text);
            test = num1 != num2;
            LResulotado.Text = test.ToString();
        }
    }
}
