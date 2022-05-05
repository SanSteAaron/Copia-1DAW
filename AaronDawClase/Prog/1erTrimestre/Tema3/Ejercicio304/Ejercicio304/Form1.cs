using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio304
{
    public partial class Ejercicio304 : Form
    {
        public Ejercicio304()
        {
            InitializeComponent();
        }

        private void BComprobar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            if (num1 > num2)
                MessageBox.Show("El número " + num1.ToString() + " es el mayor.");
            else
            {
                if (num1 < num2)
                    MessageBox.Show("El número " + num2.ToString() + " es el mayor.");
                else
                    MessageBox.Show("Los dos numeros són iguales.");
            }

        }
    }
}
