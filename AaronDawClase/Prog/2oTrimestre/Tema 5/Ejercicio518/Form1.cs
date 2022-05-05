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

namespace Ejercicio518
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kFIL = 5;
        const int kCOL = 5;
        int[,] matriz = new int[kFIL, kCOL];

        void LeerMatriz (int [,] matriz)
        {
            int i = int.Parse(TBFila.Text);
            int j = int.Parse(TBCOL.Text);
            int valor = int.Parse(TBValor.Text);
            matriz[i, j] = valor;
        }

        string MostrarMatriz (int [,] matriz)
        {
            string texto = "La matriz quedaría así: " + "\n";
            for(int i = 0; i < kFIL;i++)
            {
                for(int j = 0; j < kCOL;j++)
                {
                    texto += matriz[i, j].ToString() + " | ";
                }
                texto += "\n";
            }
            return texto;
        }

        private void BLeerMatriz_Click(object sender, EventArgs e)
        {
            LeerMatriz(matriz);
        }

        private void BMostrarMatriz_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarMatriz(matriz));
        }
    }
}
