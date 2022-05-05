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

namespace Ejercicio506
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

        void LeerVector (int [] vector)
        {
            for (int i = 0; i < kNUM; i++)
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número para el 1er vector: "));
        }
        void LeerVector2 (int[] vector2)
        {
            for (int i = 0; i < kNUM; i++)
                vector2[i] = int.Parse(Interaction.InputBox("Introduce un número para el 2o vector: "));
        }
        bool ComprobarVectores (int[] vector, int[] vector2)
        {
            bool comprobante = true;
            for ( int i = 0;i < kNUM && comprobante == true;i++)
            {
                if (vector[i] != vector2[i])
                {
                    comprobante = false;
                }
            }
            return comprobante;
        }
        private void BLeerVectores_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
            LeerVector2(vector2);
        }

        private void Bcomprobante_Click(object sender, EventArgs e)
        {
            if (ComprobarVectores(vector, vector2) == false)
                MessageBox.Show("Los vectores no son iguales.");
            else
                MessageBox.Show("Los vectores son iguales.");
        }
    }
}
