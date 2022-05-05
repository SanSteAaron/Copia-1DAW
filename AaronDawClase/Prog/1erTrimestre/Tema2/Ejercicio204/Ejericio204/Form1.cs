using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejericio204
{
    public partial class Ejercicio204 : Form
    {
        public Ejercicio204()
        {
            InitializeComponent();
        }

        private void BSuma_Click(object sender, EventArgs e)
        {
          
            int numero1, numero2, resultado;
            numero1 = int.Parse(TNumero1.Text);
            numero2 =  int.Parse(TNumero2.Text);
            resultado = numero1 + numero2;
            MessageBox.Show(resultado.ToString());
        }
    }
}
