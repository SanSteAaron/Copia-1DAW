using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio328
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado, i ;
            string texto, textnum1;
            texto = "";
            textnum1 = "";
            resultado = 0;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            if(num1 < 0 && num2 > 0)
            {
                for (i = -1; i >= num1; i--)
                {
                    resultado = resultado - num2;
                    textnum1 = textnum1 + " - " + num2.ToString();
                    texto =num1.ToString() + " * " + num2.ToString() + " = " + textnum1 + "\n" + "El resultado es: " + resultado.ToString();
                }
            }
            if(num2 < 0 && num1 > 0)
            {
                num2 = -num2;
                for (i = 1; i <= num1; i++)
                {
                    resultado = resultado - num2;
                    textnum1 = textnum1 + " - " + num2.ToString();
                    texto = num1.ToString() + " * " + "-" + num2.ToString() + " = " + textnum1 + "\n" + "El resultado es: " + resultado.ToString();
                }
                num2 = -num2;
            }
            if (num1 > 0 && num2 > 0)
            {
                for (i = 1; i <= num1; i++)
                {
                    resultado = resultado + num2;
                    textnum1 = textnum1 + " + " + num2.ToString();
                    texto = num1.ToString() + " * " + num2.ToString() + " = " + textnum1 + "\n" + "El resultado es: " + resultado.ToString();
                }
            }
            if (num1 < 0 && num2 < 0)
            {
                num2 = -num2;
                for (i = -1; i >= num1; i--)
                {
                    resultado = resultado + num2;
                    textnum1 = textnum1 + " + " + num2.ToString();
                    texto =num1.ToString() + " * " + "-" + num2.ToString() + " = " + textnum1 + "\n" + "El resultado es: " + resultado.ToString();
                }
                num2 = -num2;
            }
            MessageBox.Show(texto);
        }
    }
}
