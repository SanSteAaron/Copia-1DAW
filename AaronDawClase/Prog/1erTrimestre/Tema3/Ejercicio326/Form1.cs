using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio326
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int i, contador, suma;
            contador = 0;
            suma = 0;
            string texto;
            texto = "Serie:" + "\n";
            for (i = 3; i<=99; i = i + 3)
            {
                suma = suma + i;
                texto = texto + i.ToString() + ", ";
                contador++;
                if(contador == 7)
                {
                    contador = 0;
                    texto = texto + "\n";
                }
            }
            MessageBox.Show(texto + "\n" + "\n" + "La suma es: " + suma.ToString());
        }
    }
}
