using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio320
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPotencia_Click(object sender, EventArgs e)
        {
            int num, potencia, resultado;
            num = int.Parse(CNumero.Text);
            potencia = int.Parse(CPotencia.Text);
            resultado = 1;
            while(potencia > 0)
            {
                resultado = resultado * num;
                potencia--;
            } 
            MessageBox.Show("El resultado de la potencia es " + resultado.ToString());
        }
    }
}
