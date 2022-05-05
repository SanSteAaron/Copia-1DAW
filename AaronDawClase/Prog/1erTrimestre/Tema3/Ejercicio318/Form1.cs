using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio318
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPares_Click(object sender, EventArgs e)
        {
            int i, num, resultado;
            i = 2;
            num = int.Parse(textBox1.Text);
            string texto;
            texto = " ";
            while (i <= 50)
            {
                resultado = i + num;
                texto = texto + "," + resultado.ToString();
                i = i + 2;
            }
            MessageBox.Show(texto);
        }
    }
}
