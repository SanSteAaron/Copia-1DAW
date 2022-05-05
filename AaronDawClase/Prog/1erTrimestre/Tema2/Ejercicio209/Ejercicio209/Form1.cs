using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio209
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BResta_Click(object sender, EventArgs e)
        {
            int num1, num2, resta;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            resta = num1 - num2;
            TResultado.Text = resta.ToString(); 
        }

        private void BSuma_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            suma = num1 + num2;
            TResultado.Text = suma.ToString();
        }

        private void BDivision_Click(object sender, EventArgs e)
        {
            int num1, num2, division;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            division = num1 / num2;
            TResultado.Text = division.ToString();
        }

        private void BMultiplicar_Click(object sender, EventArgs e)
        {
            int num1, num2, multiplicacion;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            multiplicacion = num1 * num2;
            TResultado.Text = multiplicacion.ToString();
        }

        private void BResto_Click(object sender, EventArgs e)
        {
            int num1, num2, resto;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            resto = num1 % num2;
            TResultado.Text = resto.ToString();
        }
    }
}
