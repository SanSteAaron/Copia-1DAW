using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio403
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void cambio(ref int num1, ref int num2)
        {
            int auxiliar = num1;
            num1 = num2;
            num2 = auxiliar;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(CNum1.Text);
            n2 = int.Parse(CNum2.Text);
            string modif = n1.ToString() + " " + n2.ToString();
            cambio(ref n1,ref n2);
            MessageBox.Show("Los números ahora son: " + n1.ToString() + " y " + n2.ToString());
        }
    }
}
