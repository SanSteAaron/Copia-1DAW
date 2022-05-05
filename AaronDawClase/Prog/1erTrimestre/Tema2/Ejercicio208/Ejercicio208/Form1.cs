using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio208
{
    public partial class Ejercicio208 : Form
    {
        public Ejercicio208()
        {
            InitializeComponent();
        }

        private void BSolucion_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, suma, producto;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            num3 = int.Parse(TNum3.Text);
            suma = num1 + num2 + num3;
            producto = num1 * num2 * num3;
            MessageBox.Show("Los tres numeros sumados da como resultado " + suma.ToString() + " y multiplicados " + producto.ToString());
        }
    }
}
