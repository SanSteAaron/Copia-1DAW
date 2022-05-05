using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio310
{
    public partial class Ejercicio310 : Form
    {
        public Ejercicio310()
        {
            InitializeComponent();
        }

        private void BCambio_Click(object sender, EventArgs e)
        {
            LEuros.Text = " ";
            double cantidad;
            cantidad = double.Parse(TEuros.Text);
            int billetes, monedas;
            if (cantidad >= 500)
            {
                billetes = (int)cantidad / 500;
                cantidad = (double)cantidad % 500;
                LEuros.Text = billetes.ToString() + " billetes de 500€.";
            }
            if (cantidad >= 200)
            {
                billetes = (int)cantidad / 200;
                cantidad = (double)cantidad % 200;
                LEuros.Text = LEuros.Text + "\n" + billetes.ToString() + " billetes de 200€.";
            }
            if (cantidad >= 100)
            {
                billetes = (int)cantidad / 100;
                cantidad = (double)cantidad % 100;
                LEuros.Text = LEuros.Text + "\n" + billetes.ToString() + " billetes de 100€.";
            }
            if (cantidad >= 50)
            {
                billetes = (int)cantidad / 50;
                cantidad = (double)cantidad % 50;
                LEuros.Text = LEuros.Text + "\n" + billetes.ToString() + " billetes de 50€.";
            }
            if (cantidad >= 20)
            {
                billetes = (int)cantidad / 20;
                cantidad = (double)cantidad % 20;
                LEuros.Text = LEuros.Text + "\n" + billetes.ToString() + " billetes de 20€.";
            }
            if (cantidad >= 10)
            {
                billetes = (int)cantidad / 10;
                cantidad = (double)cantidad % 10;
                LEuros.Text = LEuros.Text + "\n" + billetes.ToString() + " billetes de 10€.";
            }
            if (cantidad >= 5)
            {
                billetes = (int)cantidad / 5;
                cantidad = (double)cantidad % 5;
                LEuros.Text = LEuros.Text + "\n" + billetes.ToString() + " billetes de 5€.";
            }
            if (cantidad >= 1)
            {
                monedas = (int)cantidad / 1;
                cantidad = (double)cantidad % 1;
                LEuros.Text = LEuros.Text + "\n" + monedas.ToString() + " monedas de 1€.";
            }
            cantidad = cantidad * 100;
            if (cantidad < 100)
            {
                if (cantidad >= 50)
                {
                    monedas = (int)cantidad / 50;
                    cantidad = (double)cantidad % 50;
                    LEuros.Text = LEuros.Text + "\n" + monedas.ToString() + " monedas de 50 centimos.";
                }
                if (cantidad >= 20)
                {
                    monedas = (int)cantidad / 20;
                    cantidad = (double)cantidad % 20;
                    LEuros.Text = LEuros.Text + "\n" + monedas.ToString() + " monedas de 20 centimos.";
                }
                if (cantidad >= 10)
                {
                    monedas = (int)cantidad / 10;
                    cantidad = (double)cantidad % 10;
                    LEuros.Text = LEuros.Text + "\n" + monedas.ToString() + " monedas de 10 centimos.";
                }
                if (cantidad >= 5)
                {
                    monedas = (int)cantidad / 5;
                    cantidad = (double)cantidad % 5;
                    LEuros.Text = LEuros.Text + "\n" + monedas.ToString() + " monedas de 5 centimos.";
                }
                if (cantidad >= 2)
                {
                    monedas = (int)cantidad / 2;
                    cantidad = (double)cantidad % 2;
                    LEuros.Text = LEuros.Text + "\n" + monedas.ToString() + " monedas de 2 centimos.";
                }
                if (cantidad == 1)
                {
                    LEuros.Text = LEuros.Text + "\n" + cantidad.ToString() + " monedas de 1 centimos.";
                }
            }
        }
    }
}
