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

namespace Ejercicio504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int kNUM = 10;
        int[] vector = new int [kNUM];

        void LeerVector (int [] vector)
        {
            for (int i = 0; i < kNUM; i++)
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número:"));
        }
        int Recorrido (int [] vector)
        {
            int contadornegativos = 0;
            for (int i = 0; i < kNUM; i++)
            {
                if (vector[i] >= 0)
                {
                    vector[i] = 0;
                }
                else
                    contadornegativos++;
            }
            return contadornegativos;
        }
        string Mostrar (int [] vector)
        {
            int neg = Recorrido(vector);
            string texto = "La lista modificada de los números introducidos sería: " + "\n";
            for(int i =0; i < kNUM; i++)
            {
                texto += "Número introducido en la casilla " + i.ToString() + ": " + vector[i] + "\n";
            }
            texto += "En total hay " + neg.ToString() + " números negativos.";
            return texto;
        }
        private void BLeerNum_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BNegative_Click(object sender, EventArgs e)
        {
            Recorrido(vector);
            MessageBox.Show(Mostrar(vector));
        }
    }
}
