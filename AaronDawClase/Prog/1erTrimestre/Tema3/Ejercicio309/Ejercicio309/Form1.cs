using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio309
{
    public partial class Ejercicio308 : Form
    {
        public Ejercicio308()
        {
            InitializeComponent();
        }

        private void BCambio_Click(object sender, EventArgs e)
        {
            int pesetas, n1, n1resto, n2, n2resto, n3, n3resto, n4, n4resto, n5, n5resto, n6;
            pesetas = int.Parse(TPesetas.Text);
            n1 = pesetas / 10000;
            n1resto = pesetas % 10000;
            n2 = n1resto / 5000;
            n2resto = n1resto % 5000;
            n3 = n2resto / 2000;
            n3resto = n2resto % 2000;
            n4 = n3resto / 1000;
            n4resto = n3resto % 1000;
            n5 = n4resto / 100;
            n5resto = n4resto % 100;
            n6 = n5resto / 25;
            string f1, f2, f3, f4, f5, f6;
            if (n1 == 0)
                f1 = " ";
            else
                f1 = "Son " + n1.ToString() + " billetes de 10000.";
            if (n2 == 0)
                f2 = " ";
            else
                f2 = "Son " + n2.ToString() + " billetes de 5000.";
            if (n3 == 0)
                f3 = " ";
            else
                f3 = "Son " + n3.ToString() + " billetes de 2000.";
            if (n4 == 0)
                f4 = " ";
            else
                f4 = "Son " + n4.ToString() + " billetes de 1000.";
            if (n5 == 0)
                f5 = " ";
            else
                f5 = "Son " + n5.ToString() + " monedas de 100.";
            if (n6 == 0)
                f6 = " ";
            else
                f6 = "Son " + n6.ToString() + " monedas de 25.";
            LBilletes.Text = f1 + "\n" + f2 + "\n" + f3 + "\n" + f4 + "\n" + f5 + "\n" + f6;
        }
    }
}
