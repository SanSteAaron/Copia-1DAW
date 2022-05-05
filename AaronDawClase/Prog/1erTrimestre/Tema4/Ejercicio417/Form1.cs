using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Divisionresta(int dividendo, int divisor, out int result, out int resto)
        {
            result = 0;
            resto = dividendo;
            while(resto > divisor)
            {
                resto = resto - divisor;
                result++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int dendo, dsor, resultado, rest;
            dendo = int.Parse(CDividendo.Text);
            dsor = int.Parse(CDivisor.Text);
            int comprobar = dendo % dsor;
            if (comprobar != 0)
            {
                Divisionresta(dendo, dsor, out resultado, out rest);
                MessageBox.Show("La división es entera y el resultado es: " + resultado.ToString() + " con resto " + rest.ToString());
            }
            else
                MessageBox.Show("La división es exacta");
        }
    }
}
