using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio319
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFactorial_Click(object sender, EventArgs e)
        {
            int num, resultado, producto;
            num = int.Parse(textBox1.Text);
            producto = 1;
            resultado = num;
            while (producto < num)
            {
                resultado = resultado * producto;
                producto++;
            }
            MessageBox.Show("El factorial de " + num.ToString() + " es " + resultado.ToString());
        }
    }
}
