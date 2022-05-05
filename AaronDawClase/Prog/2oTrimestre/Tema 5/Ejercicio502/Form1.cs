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

namespace Ejercicio602
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kTAM = 10;
        int[] vectornum = new int[kTAM];
        void FLeerNum(int [] vectornum)
        {
            for (int i = 0; i < kTAM;i++)
            {
                vectornum[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }
        double FMedia(int[]vectornum)
        {
            double suma, media;
            suma = 0;
            for(int i = 0;i < kTAM;i++)
            {
                suma += vectornum[i];
            }
            media = suma / kTAM;
            return media;
        }
        private void BNumeros_Click(object sender, EventArgs e)
        {
            FLeerNum(vectornum);
        }

        private void BMedia_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = FMedia(vectornum);
            MessageBox.Show("La media de la serie de números introducida es: " + resultado);
        }
    }
}
