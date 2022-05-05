using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio203
{
    public partial class Ejercicio204 : Form
    {
        public Ejercicio204()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(CuadrodeTexto.Text);
            num2 = int.Parse(CuadrodeTexto2.Text);
            resultado = num1 + num2;
            MessageBox.Show(resultado.ToString());
        }
    }
}
