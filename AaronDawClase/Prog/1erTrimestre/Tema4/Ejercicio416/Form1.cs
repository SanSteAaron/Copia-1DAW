using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio416
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Factorial(int num)
        {
            int res = num;
            for (int i = 1; i < num; i++ )
            {
                res = res * i;
            }
            return res;
        }

        private void BFactorial_Click(object sender, EventArgs e)
        {
            int n,resultado;
            n = int.Parse(textBox1.Text);
            resultado = Factorial(n);
            MessageBox.Show("El resultado es " + resultado.ToString());
        }
    }
}
