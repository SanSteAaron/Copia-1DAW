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

namespace Ejercicio601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kTAM = 10;
        int[] vectornum = new int[kTAM];
        void DiezNúmeros (int[] vectornum)
        {
            for(int i = 0;i < kTAM;i++)
            {
                vectornum[i] = int.Parse(Interaction.InputBox("Introduce un número: " + i));
            }
        }
        string MostrarNúmeros(int[] vectornum)
        {
            string numeros = "Números introducidos: ";
            for(int i = 0;i < kTAM;i++)
            {
                if(i== kTAM - 1)
                {
                    numeros += vectornum[i];
                }
                else
                {
                    numeros += vectornum[i] + ", ";
                }
            }
            return numeros;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DiezNúmeros(vectornum);
        }

        private void BMNumeros_Click(object sender, EventArgs e)
        {
            string resultado;
            resultado = MostrarNúmeros(vectornum);
            MessageBox.Show(resultado);
        }
    }
}
