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

namespace Ejercicio514
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 24;
        double[] vector = new double[kNUM];

        void LeerVector(double[] vector)
        {
            for (int i = 0; i < kNUM; i++)
            {
                vector[i] = double.Parse(Interaction.InputBox("Introduce la temperatura de las " + i.ToString() + ":00 horas de hoy:"));
            }
        }

        double CalcularMedia(double[] vector)
        {
            double media = vector[0];
            for (int i = 1; i < kNUM; i++)
            {
                media += vector[i];
            }
            media = media / kNUM;
            return media;
        }

        string MostrarMayorOIgual(double[] vector)
        {
            string texto = "Las temperaturas introducidas que igualan o superan la media, " + CalcularMedia(vector).ToString() + " grados, son:" + "\n";
            for(int i = 0; i < kNUM;i++)
            {
                if (vector[i] >= CalcularMedia(vector))
                {
                    texto += vector[i].ToString() + " grados y pertenece a las " + i.ToString() + ":00 horas." + "\n";
                }
            }
            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BMostrarTemp_Click(object sender, EventArgs e)
        {
            CalcularMedia(vector);
            MessageBox.Show(MostrarMayorOIgual(vector));
        }
    }
}
