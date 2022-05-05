using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioAmp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = " ";
            int contador = 0;
            bool primo = true;
            for(int i = 2; contador <= 100;i++)
            {
                for(int j = 2; j < i && primo; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                    }
                }
                if (primo == false)
                {
                    texto = texto + i.ToString() + " ";
                    contador++;
                    primo = true;
                }
            }
            MessageBox.Show("Los 100 primeros números primos son: " + texto);
        }
    }
}
