using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio302
{
    public partial class Ejercicio302 : Form
    {
        public Ejercicio302()
        {
            InitializeComponent();
        }

        private void BComprobar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            if (num1 == num2)
                MessageBox.Show("Los numeros introducidos són iguales");
            else
                MessageBox.Show("Los numeros introducidos no són iguales");
        }
    }
}
