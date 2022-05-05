using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio301
{
    public partial class Ejerciocio301 : Form
    {
        public Ejerciocio301()
        {
            InitializeComponent();
        }

        private void BComprobar_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(TNumero.Text);
            if (num == 2)
                MessageBox.Show("El número introducido es el 2");
            else
                MessageBox.Show("Ese no es el numero 2");

        }
    }
}
