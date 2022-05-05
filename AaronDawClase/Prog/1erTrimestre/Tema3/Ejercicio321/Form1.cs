using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio321
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num ;
            num = int.Parse(textBox1.Text);
            if(num <= 15)
            {
                if (num >= 1)
                {
                    string texto;
                    texto = " ";
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            texto = texto + j + ",";
                        }
                        texto = texto + "\n";
                    }
                    MessageBox.Show(texto);
                }
                else
                    MessageBox.Show("Error, número no válido.");
            }
            else
                MessageBox.Show("Error, número no válido");
        }
    }
}
