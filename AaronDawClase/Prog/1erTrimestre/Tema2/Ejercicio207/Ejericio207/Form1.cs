using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejericio207
{
    public partial class Ejercicio207 : Form
    {
        public Ejercicio207()
        {
            InitializeComponent();
        }

        private void BSolucion_Click(object sender, EventArgs e)
        {
            int altura, metros, centimetros;
            altura = int.Parse(TCentimetros.Text);
            metros = altura / 100;
            centimetros = altura % 100;
            string resultado;
            resultado = "Seria " + metros.ToString() + " " + "metros y " + centimetros.ToString() + " " + "centimetros";
            LResultado.Text = resultado;
        }
    }
}
