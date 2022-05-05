using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int suma (int num1, int num2)
        {
            int res;
            res = num1 + num2;
            return res;
        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;
            n1 = int.Parse(CNúmero1.Text);
            n2 = int.Parse(CNúmero2.Text);
            resultado = suma(n1, n2);
            MessageBox.Show("El resultado de la suma es: " + resultado.ToString());
        }
    }
}
