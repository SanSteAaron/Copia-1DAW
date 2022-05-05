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

namespace Ejercicio508
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
            int i = 0;
            while(i < kNUM)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introdce un número positivo: "));
                if(vector[i]< 0)
                {
                    MessageBox.Show("El número introducido no es positivo, introduzca uno positivo.");
                }
                else
                    i++;
            }
        }

        string MostrarVector(int [] vector)
        {
            string texto = "Estos son los números introducidos: " + "\n";
            for(int i = 0;i < kNUM;i++)
            {
                texto += "El número introducido en la casilla " + i.ToString() + " es " + vector[i] + "\n"; 
            }
            return texto;
        }

        int CambiarDuplicados (int [] vector)
        {
            int contador = 0;
            for(int i = 0;i < kNUM;i++)
            {
                if(vector[i] != -1)
                {     
                    for(int j = i +1;j < kNUM;j++)
                    {
                        if(vector[i] == vector[j])
                        {
                            vector[j] = -1;
                            contador++;
                        }
                    }
                }
            }
            return contador;
        }

        private void BLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BMostrarVector_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarVector(vector));

        }

        private void BDuplicados_Click(object sender, EventArgs e)
        {
            int num = CambiarDuplicados(vector);
            MessageBox.Show(MostrarVector(vector) + "y el número de números duplicados es " + num.ToString());
        }
    }
}
