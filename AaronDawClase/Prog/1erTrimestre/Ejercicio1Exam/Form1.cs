using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num, i, j, resultadopar, resultadoimpar;
            string textoimpar, textopar;
            num = int.Parse(textBox1.Text);
            resultadopar = 0;
            resultadoimpar = 0;
            textopar = " ";
            textoimpar = " ";
            for (i = 2; i <= num; i = i + 2)
            {
                resultadopar = num % i;
                if(resultadopar == 0)
                {
                    textopar = textopar + " " + i.ToString();
                }
            }
            for (j = 1; j <= num; j = j + 2)
            {
                resultadoimpar = num % j;
                if (resultadoimpar == 0)
                {
                    textoimpar = textoimpar + " " + j.ToString();
                }
            }
            MessageBox.Show("Los divisores pares del número " + num.ToString() + " son: " + textopar + "\n" + "Los divisores impares del número " + num.ToString() + " son: " + textoimpar);
        }
    }
}
