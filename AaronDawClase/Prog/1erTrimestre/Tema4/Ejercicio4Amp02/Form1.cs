using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4Amp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string FDivisores (int num)
        {
            string textodiv = " ";
            bool primo = true;
            int resultado;
            for (int i = 2; i < num && primo; i++)
            {
                resultado = num % i;
                if (resultado == 0)
                {
                    primo = false;
                }
            }
            if (primo)
            {
                textodiv = "1 " + num.ToString() + " y su mayor divisor es " + num.ToString() + " porque es un número primo";
            }
            else
            {
                int mayordiv = 0;
                for(int i = 1;i < num;i++)
                {
                    resultado = num % i;
                    if (resultado == 0)
                    {
                        textodiv = textodiv + i + " ";
                        mayordiv = i;
                    }
                }
                textodiv = textodiv + " y su mayor divisor es " + mayordiv.ToString();                
            }
            return textodiv;
        }
        private void BDivisores_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);
            string result;
            result = FDivisores(num);
            if (num < 0)
            {
                MessageBox.Show("El número introducido no es válido");
            }
            else
                MessageBox.Show("Los divisores de " + num.ToString() + " son " + result);
        }
    }
}
