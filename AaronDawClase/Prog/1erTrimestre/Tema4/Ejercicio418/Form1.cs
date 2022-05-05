using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio418
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Factorial(double num)
        {
            double res = num;
            for(int i =1;i < num; i++)
            {
                res = res * i;
            }
            return res;
        }
        double PotFuncion(double m, double n)
        {
            double res = m;
            for(int i = 1; i<=n;i++)
            {
                res = res * m;
            }
            return res;
        }
        void OperarFuncion(double m, double n,out double result, out string restexto)
        {
            restexto = "m ";
            result = 0;
            for(int i=1;i<=n; i++)
            {
                double resultfact = Factorial(n);
                double resultpotencia = PotFuncion(m,n);
                result = result + resultpotencia / resultfact;
                i++;
                if(i<=n)
                {
                    restexto = restexto + "+ m^" + i.ToString() + " / " + i.ToString() + "! ";
                }
                i--;
            }
        }
        private void BCalcular_Click(object sender, EventArgs e)
        {
            double m, n, total;
            string serietotal;
            m = double.Parse(CuadroM.Text);
            n = int.Parse(CuadroN.Text);
            OperarFuncion(m, n, out total, out serietotal);
            MessageBox.Show("El resultado del cálculo seria: " + total.ToString() + "\n" + "Y la serie sería así: " + serietotal);
        }
    }
}
