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

namespace Ejercicio517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 10;
        int[] vector = new int[kNUM];

        void LeerVector(int [] vector)
        {
            for (int i = 0; i < kNUM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }

        void BuscarElemento(int [] vector)
        {
            bool comprobar = true;
            int num = int.Parse(Interaction.InputBox("Introduce el número que quieres buscar dentro del vector: "));
            for (int i = 0;i < kNUM && comprobar == true;i++)
            {
                if (vector[i] == num)
                {
                    comprobar = false;
                    MessageBox.Show("El número intoducido se encuentra dentro del vector en la posición " + i.ToString());
                }
            }
            if(comprobar == true)
            {
                MessageBox.Show("El número introducido no se necuentra en el vector.");
            }
        }

        void OrdenarVector (int [] vector)
        {
            for(int i = 0; i < kNUM;i++)
            {
                for (int j = i; j < kNUM;j++)
                {
                    if (vector[j] > vector[i])
                    {
                        int aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
        }

        string MostrarVector (int[] vector)
        {
            string texto = "El vector actualmente se vería así: " + "\n";
            for(int i = 0; i < kNUM;i++)
            {
                texto += "En la posición " + i.ToString() + " del vector se encuentra el número " + vector[i] + "\n";
            }
            return texto;
        }

        private void BLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BBuscarElemento_Click(object sender, EventArgs e)
        {
            BuscarElemento(vector);
        }

        private void BOrdenarVector_Click(object sender, EventArgs e)
        {
            OrdenarVector(vector);
        }

        private void BMostrarVector_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarVector(vector));
        }
    }
}
