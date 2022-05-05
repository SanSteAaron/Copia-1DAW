using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio306
{
    public partial class Ejercicio306 : Form
    {
        public Ejercicio306()
        {
            InitializeComponent();
        }

        private void BNota_Click(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(TNumero.Text);
            if (numero > 10)
                MessageBox.Show("El numero que se ha introducido no se encuentra en el intervalo de 1 a 10");
            else
            {
                if (numero >= 9)
                    MessageBox.Show("La nota es un sobresaliente");
                else
                {
                    if (numero >= 7)
                        MessageBox.Show("La nota es un notable");
                    else
                    {
                        if (numero >= 6)
                            MessageBox.Show("La nota es un bien");
                        else
                        {
                            if (numero >= 5)
                                MessageBox.Show("La nota es un suficiente");
                            else
                            {
                                if (numero >= 3)
                                    MessageBox.Show("La nota es un insuficiente");
                                else
                                {
                                    if (numero >= 0)
                                        MessageBox.Show("La nota es un muy deficiente");
                                    else
                                    {
                                        MessageBox.Show("El numero que se ha introducido no se encuentra en el intervalo de 1 a 10");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}