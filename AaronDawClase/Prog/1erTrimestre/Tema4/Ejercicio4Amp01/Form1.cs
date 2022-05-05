using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4Amp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void FPrimos(int num1, int num2,out string textoprimo)
        {
            bool primo = true;
            textoprimo = " ";
            if (num2 > num1)
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        i = 2;
                    }
                    for (int j = 2; j < i && primo; j++)
                    {
                        if (i % j == 0)
                        {
                            primo = false;

                        }
                    }
                    if (primo)
                    {
                        textoprimo = textoprimo + i + " ";
                    }
                    primo = true;
                }
            }
        }
        private void BPrimos_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(CNum1.Text);
            num2 = int.Parse(CNum2.Text);
            if (num2 < num1)
            {
                int aux = num1;
                num1 = num2;
                num2 = aux;
            }
            FPrimos(num1, num2, out string textresult);
            MessageBox.Show("Los números primos entre " + num1.ToString() + " y " + num2 + " son: " + textresult);
        }
    }
}
