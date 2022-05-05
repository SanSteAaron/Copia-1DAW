using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio327
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num, i;
            string texto;
            texto = "Es primo";
            num = int.Parse(textBox1.Text);
            if (num > 1)
            {
                for (i = 2; i < num; i++)
                {
                    int comprobante = num % i;
                    if (comprobante == 0)
                        texto = "No es primo";
                }
                MessageBox.Show(texto);
            }
            else
                MessageBox.Show("El número introducido debe ser mayor que 1.");
        }
    }
}
