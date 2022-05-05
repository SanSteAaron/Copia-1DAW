using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio329
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            double num, resultado, i;
            num = double.Parse(textBox1.Text);
            resultado = 0;
            if (num > 0)
            {
                for(i=1;i<=num;i++)
                {
                    resultado = resultado + 1 / i;
                    if(num != i)
                    {
                        i++;
                        resultado = resultado - 1 / i;
                    }
                }
                MessageBox.Show("El resultado de la serie es " + resultado.ToString());
            }
            else
                MessageBox.Show("El número debe ser mayor que 0.");
        }
    }
}
