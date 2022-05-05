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

namespace Ejercicio505
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 10;
        int[] vector = new int[kNUM];
        int[] vector2 = new int[kNUM];
        int[] vectorsuma = new int[kNUM];
        void LeerVector1 (int [] vector)
        {
            for (int i = 0; i < kNUM; i++)
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número:"));
        }
        void LeerVector2(int [] vector2)
        {
            for (int i = 0; i < kNUM; i++)
                vector2[i] = int.Parse(Interaction.InputBox("Introduce un número para sumarlo al vector anterior:"));
        }
        void SumaVectores(int [] vectorsuma, int [] vector, int [] vector2)
        {
            for(int i = 0; i < kNUM;i++)
                vectorsuma[i] = vector[i] + vector2[i];

        }
        string MostrarResultado (int [] vectorsuma)
        {
            string texto = "El resultadode la suma de los vectores es:" + "\n";
            for (int i = 0; i < kNUM; i++)
                texto += "El resultado en la posición " + i.ToString() + " es: " + vectorsuma[i] + "\n";
            return texto;
        }
        private void BLeerNum_Click(object sender, EventArgs e)
        {
            LeerVector1(vector);
            LeerVector2(vector2);
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            SumaVectores(vectorsuma, vector, vector2);
            MessageBox.Show(MostrarResultado(vectorsuma));
        }
    }
}
