using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio322
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);
            if (num >= 14681 && num <= 15681 || num >= 70001 && num <= 79999 || num >= 88888 && num <= 111111)
            {
                MessageBox.Show("El número de serie " + num.ToString() + " no es válido.");
            }
            else
                MessageBox.Show("El número de serie " + num.ToString() + " es válido.");
        }
    }
}
