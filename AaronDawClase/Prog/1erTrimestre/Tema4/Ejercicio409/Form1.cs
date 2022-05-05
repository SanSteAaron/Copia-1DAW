using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio409
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int exponencial(int num, int expo)
        {
            int res = 1;
            for ( int i = 1; i <= expo;i++)
            {
                res = res * num;
            }
            return res;
        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            int n, expon, resultado;
            n = int.Parse(CNúm.Text);
            expon = int.Parse(CExponente.Text);
            resultado = exponencial(n, expon);
            MessageBox.Show("El resultado es " + resultado.ToString());

        }
    }
}
