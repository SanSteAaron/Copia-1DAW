using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio316
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num, resultado;
            num = int.Parse(Interaction.InputBox("Introducir un número del 0 al 9."));
            resultado = num;
            if (num >= 0 && num <= 9)
            {
                resultado = num;
                do
                {
                    num = int.Parse(Interaction.InputBox("Introducir un número del 0 al 9."));
                    if (num >= 0 && num <= 9)
                    {
                        resultado = resultado + num;
                    }                   
                } while (num >= 0 && num <= 9);
                MessageBox.Show("El resultado de la suma es " + resultado.ToString());
            }
            else
                MessageBox.Show("Error, primer número no válido.");
        }
    }
}
