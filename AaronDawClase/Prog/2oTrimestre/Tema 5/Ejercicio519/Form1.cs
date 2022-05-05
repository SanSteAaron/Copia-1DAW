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

namespace Ejercicio519
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int KFIL = 5;
        const int KCOL = 5;
        int[,] matriz = new int[KFIL, KCOL];

        void LeerMatriz (int [,] matriz)
        {
            for (int i = 0;i < KFIL;i++)
            {
                for(int j = 0; j < KCOL;j++)
                {
                    matriz[i, j] = int.Parse(Interaction.InputBox("Introduce un número: "));
                }
            }
        }

        int FSumaFila (int[,]matriz , int i)
        {
            int sumafilas = 0;
            for(int j = 0;j <KCOL;j++)
            {
                 sumafilas += matriz[i, j];
            }
            return sumafilas;
        }

        int FSumaColumna (int[,] matriz,int j)
        {
            int sumacolumnas = 0;
            for(int i = 0;i <KFIL;i++)
            {
                sumacolumnas += matriz[i, j];
            }
            return sumacolumnas;
        }

        string MostrarResultado (int [,] matriz)
        {
            string texto = "El resultado de las filas y las columnas una a una es el siguiente: " + "\n";
            int SFIL = 0;
            int SCOL = 0;
            for (int i = 0; i < KFIL;i++)
            {
                SFIL = FSumaFila(matriz, i);
                texto += "El resultado de la fila " + i.ToString() + " es " + SFIL.ToString() + "\n";
            }
            for (int j = 0;j < KCOL; j++)
            {
                SCOL = FSumaColumna(matriz, j);
                texto += "El resultado de la columna " + j.ToString() + " es " + SCOL.ToString() + "\n";
            }
            return texto;
        }

        private void BLeerMatriz_Click(object sender, EventArgs e)
        {
            LeerMatriz(matriz);
        }

        private void BMostrarMatriz_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarResultado(matriz));
        }
    }
}
