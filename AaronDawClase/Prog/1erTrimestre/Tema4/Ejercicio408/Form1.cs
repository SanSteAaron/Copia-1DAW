using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio408
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double nmfuncion(double num1,double num2,double num3)
        {
            double res = (num1 + num2 + num3) / 3;
            return res;
        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            double n1, n2,n3, nmresultado;
            n1 = double.Parse(CNúm1.Text);
            n2 = double.Parse(CNúm2.Text);
            n3 = double.Parse(CNúm3.Text);
            if (n1 >= 0 && n1 <= 10 && n2 >= 0 && n2 <= 10 && n3 >= 0 && n3 <= 10)
            {
                nmresultado = nmfuncion(n1, n2, n3);
                MessageBox.Show("La nota media es " + nmresultado.ToString());
            }
            else
                MessageBox.Show("Alguna de las notas no es válida, no está comprendida entre 0 y 10.");
        }
    }
}
