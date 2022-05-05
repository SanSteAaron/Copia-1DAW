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

namespace Ejercicio323
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            double contador, numpeso, peso50, peso65, peso80, peso81, perc50, perc65, perc80, perc81, pesomedio, pesomediofinal;
            perc50 = 0;
            perc65 = 0;
            perc80 = 0;
            perc81 = 0;
            peso50 = 0;
            peso65 = 0;
            peso80 = 0;
            peso81 = 0;
            contador = 0;
            pesomedio = 0;
            pesomediofinal = 0;
            numpeso = double.Parse(Interaction.InputBox("Introduzca un número:"));
            if (numpeso > 0)
            {
                if (numpeso <= 50)
                {
                    peso50++;
                    contador++;
                }
                if (numpeso <= 65 && numpeso > 50)
                {
                    peso65++;
                    contador++;
                }
                if (numpeso <= 80 && numpeso > 65)
                {
                    peso80++;
                    contador++;
                }
                if (numpeso > 80)
                {
                    peso81++;
                    contador++;
                }
                pesomedio = pesomedio + numpeso;
                pesomediofinal = pesomedio / contador;
                while (numpeso > 0)
                {
                    numpeso = double.Parse(Interaction.InputBox("Introduzca un número:"));
                    if (numpeso > 0)
                    {
                        if (numpeso <= 50)
                        {
                            peso50++;
                            contador++;
                        }
                        if (numpeso <= 65 && numpeso > 50)
                        {
                            peso65++;
                            contador++;
                        }
                        if (numpeso <= 80 && numpeso > 65)
                        {
                            peso80++;
                            contador++;
                        }
                        if (numpeso > 80)
                        {
                            peso81++;
                            contador++;
                        }
                        perc50 = peso50 * 100 / contador;
                        perc65 = peso65 * 100 / contador;
                        perc80 = peso80 * 100 / contador;
                        perc81 = peso81 * 100 / contador;
                        pesomedio = pesomedio + numpeso;
                        pesomediofinal = pesomedio / contador;
                    }

                }
                MessageBox.Show("Hay " + peso50.ToString() + " personas que pesan menos de 50Kg o 50 Kg justos, un " + perc50.ToString() + "% del total." + "\n" + "Hay " + peso65.ToString() + " personas que pesan entre 50Kg y 65Kg o 65Kg justos, un " + perc65.ToString() + "% del total." + "\n" + "Hay " + peso80.ToString() + " personas que pesan entre 65Kg y 80kg o 80Kg justos, un " + perc80.ToString() + "% del total." + "\n" + "Hay " + peso81.ToString() + " personas que pesan más de 80Kg, un " + perc81.ToString() + "% del total." + "\n" + "El peso medio es " + pesomediofinal.ToString() + "Kg");
            }
            else
                MessageBox.Show("El primer número negativo o 0 no es válido");
        }
    }
}
