using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);
            if (num > 0 && num <= 100)
            {
                string texto;
                int i, resultado;
                texto = "La tabla del " + num.ToString() + " es:";
                for (i = 1; i<=10; i++)
                {
                    resultado = num * i;
                    texto = texto + "\n" + num.ToString() + "x" + i.ToString() + " = " + resultado.ToString();
                }
                MessageBox.Show(texto);
            }
            else
                MessageBox.Show("El número introducido debe estar entre 1 y 100");
        }
    }
}
