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

namespace Ejercicio509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 10;
        int[] vector = new int[kNUM];
        int[] vectorCambio = new int[kNUM];
        
        void LeerVector (int [] vector)
        {
            for (int i = 0; i <kNUM;i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }

        void VectorAlRevés (int [] vector, int [] vectorCambio)
        {
            for (int i = 0; i < kNUM;i++)
            {
                vectorCambio[(kNUM - 1) - i] = vector[i];
            }
        }

        void VectorAlRevésConUnVector (int [] vector)
        {
            for (int i = 0 , j = kNUM - 1 - i; i < kNUM/2; i++, j--)
            {
                int aux = vector[i];
                vector[i] = vector[j];
                vector[j] = aux;

            }
        }

        string MostrarVector (int [] vector, int[] vectorCambio)
        {
            string texto = "El vector normal y el otro vector al revés quedarían así:" + "\n";
            for(int i = 0; i < kNUM;i++)
            {
                texto += "El número del vector normal en esta posición es: " + vector[i] + "\n" + "Y el del vector al revés es: " + vectorCambio[i] + "\n";
            }
            return texto;
        }

        string MostrarVectorcon1(int[] vector)
        {
            string texto = "El vector quedaría así:" + "\n";
            for (int i = 0; i < kNUM; i++)
            {
                texto += "El número del vector en esta posición es: " + vector[i] + "\n";
            }
            return texto;
        }
        private void BLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BMostrarVector2_Click(object sender, EventArgs e)
        {
            VectorAlRevés(vector, vectorCambio);
            MessageBox.Show(MostrarVector(vector, vectorCambio));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VectorAlRevésConUnVector(vector);
            MessageBox.Show(MostrarVectorcon1(vector));
        }
    }
}
