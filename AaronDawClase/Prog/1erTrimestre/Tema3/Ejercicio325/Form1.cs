using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio325
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int j, i, resultado;
            string texto;
            for (j = 1; j <= 10; j++)
            {
                texto = "La tabla del " + j.ToString() + " es:";
                for (i = 1; i <= 10; i++)
                {
                    resultado = j * i;
                    texto = texto + "\n" + j.ToString() + " * " + i.ToString() + " = " + resultado.ToString();
                }
                MessageBox.Show(texto);
            } 
        }
    }
}
