using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio314
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFor_Click(object sender, EventArgs e)
        {
            int num, resultado, i;
            num = int.Parse(textBox1.Text);
            for (i = 1; i <= 10; i++)
            {
                resultado = num + i;
                MessageBox.Show(resultado.ToString());
            }              
        }

        private void BWhile_Click(object sender, EventArgs e)
        {
            int num, resultado, i;
            num = int.Parse(textBox1.Text);
            i = 1;
            while (i <= 10)
            {
                resultado = num + i;
                MessageBox.Show(resultado.ToString());
                i++;
            }              
        }
    }
}
