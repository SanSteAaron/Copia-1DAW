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

namespace Ejercicio510
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
            for(int i = 0; i < kNUM;i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }

        void CambiarVector (int [] vector, int [] vectorCambio)
        {
            vectorCambio[0] = vector[kNUM - 1];
            for (int i = 1;i < kNUM;i++)
            {
                    vectorCambio[i] = vector[i - 1];
            }
        }

        string MostrarVector (int [] vector, int [] vectorCambio)
        {
            string texto = "Los vectores finalmente quedarían así:" + "\n";
            for(int i =0; i < kNUM;i++)
            {
                texto += "En esta posición el número en el vector normal sería: " + vector[i] + "\n" + "Y en el vector cambiado sería: " + vectorCambio[i] + "\n";
            }
            return texto;
        }
        private void BLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            CambiarVector(vector, vectorCambio);
            MessageBox.Show(MostrarVector(vector,vectorCambio));
        }
    }
}
