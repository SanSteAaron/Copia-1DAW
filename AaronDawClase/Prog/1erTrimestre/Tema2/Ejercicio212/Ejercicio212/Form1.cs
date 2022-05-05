using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio212
{
    public partial class Ejercicio212 : Form
    {
        public Ejercicio212()
        {
            InitializeComponent();
        }

        private void BImporte_Click(object sender, EventArgs e)
        {
            double prod1, prod2, prod3, siniva, coniva;
            const double kiva = 0.79;
            prod1 = double.Parse(TProducto1.Text);
            prod2 = double.Parse(TProducto2.Text);
            prod3 = double.Parse(TProducto3.Text);
            coniva = prod1 + prod2 + prod3;
            siniva = (prod1 + prod2 + prod3) * kiva;
            MessageBox.Show("El importe con IVA es: " + coniva.ToString() + " y sin IVA sería: " + siniva.ToString());
        }
    }
}
