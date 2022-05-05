using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void check (int num1, int num2, out bool res)
        {
            int resultado = num1 % num2;
            if (resultado == 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }    
        }
        private void BDividir_Click(object sender, EventArgs e)
        {
            int n1, n2;
            bool respuesta;
            n1 = int.Parse(CDividendo.Text);
            n2 = int.Parse(CDivisor.Text);
            check(n1, n2, out respuesta);
            MessageBox.Show(respuesta.ToString());
        }
    }
}
