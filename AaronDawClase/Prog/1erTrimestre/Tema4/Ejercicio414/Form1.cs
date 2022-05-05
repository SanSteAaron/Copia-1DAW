using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio414
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string MPesetas(int pesetas)
        {
            int n1, n1resto, n2, n2resto, n3, n3resto, n4, n4resto, n5, n5resto, n6;
            string res;
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
            string t1, t2, t3, t4, t5,t6;
            if (n1 != 0)
            {
                t1 = n1.ToString() + " billetes de 10000.";
            }
            else
                t1 = " ";
            if (n2 != 0)
            {
                t2 = n2.ToString() + " billetes de 5000.";
            }
            else
                t2 = " ";
            if (n3 != 0)
            {
                t3 = n3.ToString() + " billetes de 2000.";
            }
            else
                t3 = " ";
            if (n4 != 0)
            {
                t4 = n4.ToString() + " billetes de 1000.";
            }
            else
                t4 = " ";
            if (n5 != 0)
            {
                t5 = n5.ToString() + " monedas de 100.";
            }
            else
                t5 = " ";
            if (n6 != 0)
            {
                t6 = n6.ToString() + " monedas de 25.";
            }
            else
                t6 = " ";
            res = pesetas.ToString() + " pesetas se pueden dividir en: " + "\n" + t1 + "\n" + t2 + "\n" + t3 + "\n" + t4 + "\n" + t5 + "\n" + t6;
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pesetas;
            pesetas = int.Parse(CPesetas.Text);
            string final = MPesetas(pesetas);
            MessageBox.Show(final);
        }
    }
}
