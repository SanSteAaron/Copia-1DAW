using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio406
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void operacion(int num1,int num2,out int resultado,out int resto)
        {
            resultado = num1 / num2;
            resto = num1 % num2;
        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            int n1, n2, rdivisión, rresto;
            n1 = int.Parse(CDividendo.Text);
            n2 = int.Parse(CDivisor.Text);
            operacion(n1, n2, out rdivisión, out rresto);
            MessageBox.Show("El resultado de la división es " + rdivisión.ToString() + "\n" + "Y el resto es " + rresto.ToString());
        }
    }
}
