using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BSolucion_Click(object sender, EventArgs e)
        {
            double cantidad, interes, capitalfinal, D100, D1;
            D100 = 100;
            D1 = 1;
            cantidad = double.Parse(TCantidad.Text);
            interes = ((double.Parse(TInteres.Text)) / D100);
            capitalfinal = cantidad * (D1 + interes);
            MessageBox.Show("Su capital final es: " + capitalfinal.ToString());
        }
    }
}
