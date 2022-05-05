using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio308
{
    public partial class Ejercicio308 : Form
    {
        public Ejercicio308()
        {
            InitializeComponent();
        }

        private void BEscribir_Click(object sender, EventArgs e)
        {
            string texto;
            texto = TTexto.Text;
            LEscribir.Text = LEscribir.Text + texto + "\n";
        }
    }
}
