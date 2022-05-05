using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio411
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool bisiesto ( int año)
        {
            bool res = false;
            int comprobante4 = año % 4;
            if (comprobante4 == 0)
            {
                res = true;
                int comprobante100 = año % 100;
                int comprobante400 = año % 400;
                if(comprobante100 == 0 && comprobante400 == 0)
                {
                    res = false;
                }
            }
            return res;
        }
        private void BBisiesto_Click(object sender, EventArgs e)
        {
            int year;
            year = int.Parse(textBox1.Text);
            bool bis = bisiesto(year);
            if (bis == true)
            {
                MessageBox.Show("El año " + year.ToString() + " es bisiesto");
            }
            else
                MessageBox.Show("El año " + year.ToString() + " no es bisiesto");
        }
    }
}
