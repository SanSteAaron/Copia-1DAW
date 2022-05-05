using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio305
{
    public partial class Ejercicio305 : Form
    {
        public Ejercicio305()
        {
            InitializeComponent();
        }

        private void BComparar_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = int.Parse(TNum1.Text);
            num2 = int.Parse(TNum2.Text);
            num3 = int.Parse(TNum3.Text);
            if (num1 > num2)
            {
                if (num1 > num3)
                    MessageBox.Show("El número " + num1.ToString() + " es el mayor.");
                else
                    MessageBox.Show("El número " + num3.ToString() + " es el mayor.");
            }
            else
            {
                if (num2 > num3)
                    MessageBox.Show("El número " + num2.ToString() + " es el mayor.");
                else
                    MessageBox.Show("El número " + num3.ToString() + " es el mayor.");
            }
        }
    }
}
