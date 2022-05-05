using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio205
{
    public partial class Ejercicio205 : Form
    {
        public Ejercicio205()
        {
            InitializeComponent();
        }

        private void BSuma_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;
            numero1 = int.Parse(TNumero1.Text);
            numero2 = int.Parse(TNumero2.Text);
            resultado = numero1 + numero2;
            TResultado.Text = resultado.ToString();
        }
    }
}
