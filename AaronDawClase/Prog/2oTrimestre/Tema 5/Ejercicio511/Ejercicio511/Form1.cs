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

namespace Ejercicio511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 10;
        int[] vector = new int[kNUM];

        void LeerVector(int[] vector)
        {
            for (int i = 0; i < kNUM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }

        void CambiarVector(int[] vector)
        {
            int aux = vector[kNUM - 1];
            for (int i = (kNUM -1);i >= 0;i--)
            {
                int j = i - 1;
                if (i == 0)
                    vector[i] = aux;
                else
                    vector[i] = vector[j];
            }
        }

        string MostrarVector(int[] vector)
        {
            string texto = "Los vectores quedarían así:" + "\n";
            for (int i = 0; i < kNUM; i++)
            {
                texto += "En esta posición el número en el vector sería: " + vector[i] + "\n";
            }
            return texto;
        }
        private void BLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarVector(vector));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarVector(vector);
            MessageBox.Show(MostrarVector(vector));
        }
    }
}
