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

namespace Ejercicio515
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 20;
        int[] vector = new int[kNUM];

        void LeerVector (int [] vector)
        {
            for(int i = 0; i < kNUM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }

        void Fmayor (int [] vector, out int mayor, out int contadorM)
        {
            mayor = vector[0];
            contadorM = 0;
            for (int i = 1; i < kNUM; i++)
            {
                if(vector[i] > mayor)
                {
                    mayor = vector[i];
                    contadorM = 0;
                }
                if(mayor == vector[i])
                {
                    contadorM++;
                }
            }
        }

        void Fmenor (int[] vector, out int menor, out int contadorm)
        {
            menor = vector[0];
            contadorm = 0;
            for ( int i = 0; i < kNUM;i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                    contadorm = 0;
                }
                if(menor == vector[i])
                {
                    contadorm++;
                }
            }
        }
        private void BLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BMostrarResult_Click(object sender, EventArgs e)
        {
            int mayor, menor, contadorM, contadorm;
            Fmayor(vector, out mayor, out contadorM);
            Fmenor(vector, out menor, out contadorm);
            MessageBox.Show("El mayor de los números introducidos es el " + mayor.ToString() + " y se repite " + contadorM.ToString() + " veces." + "\n" + "El menor de los números introducidos es el " + menor.ToString() + " y se repite " + contadorm.ToString() + " veces.");
        }
    }
}
