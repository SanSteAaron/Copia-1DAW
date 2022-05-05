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

namespace Ejercicio603
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kTAM = 10;
        int[] vectornum = new int[kTAM];
        void FLeerNum(int[] vectornum)
        {
            for (int i = 0; i < kTAM; i++)
            {
                vectornum[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }
        string FListaNúmeros(int[] vectornum)
        {
            string texto;
            texto = "Los números introducidos son: ";
            for(int i = 0; i < kTAM;i++)
            {
                if(i== kTAM - 1)
                {
                    texto += vectornum[i];
                }
                else
                {
                    texto += vectornum[i] + ", ";
                }
            }
            return texto;
        }
        int FMenor(int [] vectornum)
        {
            int menor = vectornum[0];
            for(int i = 1;i < kTAM;i++)
            {
                if(vectornum[i]< menor)
                {
                    menor = vectornum[i];
                }
            }
            return menor;
        }
        private void BLeerNúmeros_Click(object sender, EventArgs e)
        {
            FLeerNum(vectornum);
        }

        private void BMostrarNúmeros_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FListaNúmeros(vectornum).ToString());
        }

        private void BMostrarMenor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FMenor(vectornum).ToString());
        }
    }
}
