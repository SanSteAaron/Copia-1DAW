using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio213
{
    public partial class Ejercicio213 : Form
    {
        public Ejercicio213()
        {
            InitializeComponent();
        }

        private void BCalculo_Click(object sender, EventArgs e)
        {
            double horas, extras, pago, dinerohoras, dineroextras, dinerototal;
            horas = double.Parse(THoras.Text);
            extras = double.Parse(TExtras.Text);
            pago = double.Parse(TPago.Text);
            dinerohoras = horas * pago;
            dineroextras = extras * 2 * pago;
            dinerototal = (dineroextras + dinerohoras) - ((dineroextras + dinerohoras) * 0.18);
            MessageBox.Show("El salario emsual es: " + dinerototal.ToString() + " €");

        }
    }
}
