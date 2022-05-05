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

namespace Ejercicio512
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 24;
        double[] vector = new double[kNUM];
        
        void LeerTemperaturas (double [] vector)
        {
            for (int i = 0; i < kNUM;i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce la temperatura de las " + i.ToString() + ":00 horas: "));
            }
        }

        void CalcularMAXMINMEDIA(double[] vector, out double maxima, out double minima, out double media)
        {
            maxima = minima = media = vector[0];
            for (int i = 1; i < kNUM; i++)
            {
                media += vector[i];
                if (maxima < vector[i])
                {
                    maxima = vector[i];
                }
                if (minima > vector[i])
                {
                    minima = vector[i];
                }
            }
            media = media / kNUM;
        }

        private void BLeerTemperaturas_Click(object sender, EventArgs e)
        {
            LeerTemperaturas(vector);
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            CalcularMAXMINMEDIA(vector, out double maxima, out double minima, out double media);
            MessageBox.Show("La temperatura máxima del día ha sido: " + maxima.ToString() + "\n" + "La mínima ha sido: " + minima.ToString() + "\n" + "Y la media de las temperaturas de hoy es: " + media.ToString());
        }
    }
}
