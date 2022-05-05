using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio415
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string MEuros(double cantidad)
        {
            string res = " ";
            int billetes, monedas;
            cantidad = cantidad * 100;
            if (cantidad >= 50000)
            {
                billetes = (int)cantidad / 50000;
                cantidad = (int)cantidad % 50000;
                res = billetes.ToString() + " billetes de 500€.";
            }
            if (cantidad >= 20000)
            {
                billetes = (int)cantidad / 20000;
                cantidad = (int)cantidad % 20000;
                res = res + "\n" + billetes.ToString() + " billetes de 200€.";
            }
            if (cantidad >= 10000)
            {
                billetes = (int)cantidad / 10000;
                cantidad = (int)cantidad % 10000;
                res = res + "\n" + billetes.ToString() + " billetes de 100€.";
            }
            if (cantidad >= 5000)
            {
                billetes = (int)cantidad / 5000;
                cantidad = (int)cantidad % 5000;
                res = res + "\n" + billetes.ToString() + " billetes de 50€.";
            }
            if (cantidad >= 2000)
            {
                billetes = (int)cantidad / 2000;
                cantidad = (int)cantidad % 2000;
                res = res + "\n" + billetes.ToString() + " billetes de 20€.";
            }
            if (cantidad >= 1000)
            {
                billetes = (int)cantidad / 1000;
                cantidad = (int)cantidad % 1000;
                res = res + "\n" + billetes.ToString() + " billetes de 10€.";
            }
            if (cantidad >= 500)
            {
                billetes = (int)cantidad / 500;
                cantidad = (int)cantidad % 500;
                res = res + "\n" + billetes.ToString() + " billetes de 5€.";
            }
            if (cantidad >= 100)
            {
                monedas = (int)cantidad / 100;
                cantidad = (int)cantidad % 100;
                res = res + "\n" + monedas.ToString() + " monedas de 1€.";
            }
                if (cantidad >= 50)
                {
                    monedas = (int)cantidad / 50;
                    cantidad = (int)cantidad % 50;
                    res = res + "\n" + monedas.ToString() + " monedas de 50 centimos.";
                }
                if (cantidad >= 20)
                {
                    monedas = (int)cantidad / 20;
                    cantidad = (int)cantidad % 20;
                    res = res + "\n" + monedas.ToString() + " monedas de 20 centimos.";
                }
                if (cantidad >= 10)
                {
                    monedas = (int)cantidad / 10;
                    cantidad = (int)cantidad % 10;
                    res = res + "\n" + monedas.ToString() + " monedas de 10 centimos.";
                }
                if (cantidad >= 5)
                {
                    monedas = (int)cantidad / 5;
                    cantidad = (int)cantidad % 5;
                    res = res + "\n" + monedas.ToString() + " monedas de 5 centimos.";
                }
                if (cantidad >= 2)
                {
                    monedas = (int)cantidad / 2;
                    cantidad = (int)cantidad % 2;
                    res = res + "\n" + monedas.ToString() + " monedas de 2 centimos.";
                }
                if(cantidad >= 1)
                {
                    res = res + "\n" + cantidad.ToString() + " monedas de 1 centimos.";
                }
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double cant;
            cant = double.Parse(CEuros.Text);
            string final = MEuros(cant);
            MessageBox.Show(final);
        }
    }
}
