using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio206
{
    public partial class Ejercicio206 : Form
    {
        public Ejercicio206()
        {
            InitializeComponent();
        }

        private void BOperar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, division, resto;
            numero1 = int.Parse(TNumero1.Text);
            numero2 = int.Parse(TNumero2.Text);
            division = numero1 / numero2;
            resto = numero1 % numero2;
            string Resultado;
            Resultado = "El cociente es: " + division.ToString() + " " + "El resto es: " + resto.ToString();
            MessageBox.Show(Resultado);
        }
    }
}
