using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BCalcular_Click(object sender, EventArgs e)
        {
            int horas, minutos, segundos;
            horas = int.Parse(CHora.Text);
            minutos = int.Parse(CMinutos.Text);
            segundos = int.Parse(CSegundos.Text);
            if (segundos <= 59)
            {
                if (segundos >= 0)
                {
                    if (minutos <= 59)
                    {
                        if (minutos >= 0)
                        {
                            if (horas <= 23)
                            {
                                if (horas >= 0)
                                {
                                    segundos = segundos + 1;
                                    if (segundos == 60)
                                    {
                                        segundos = segundos - 60;
                                        minutos = minutos + 1;
                                        if (minutos == 60)
                                        {
                                            minutos = minutos - 60;
                                            horas = horas + 1;
                                            if (horas == 24)
                                            {
                                                horas = horas - 24;
                                            }     
                                        }
                                    }
                                    MessageBox.Show("La hora siguiente será " + horas.ToString() + ":" + minutos.ToString() + ":" + segundos.ToString());
                                }
                                else
                                    MessageBox.Show("Hora no válida.");
                            }
                            else
                                MessageBox.Show("Hora no válida.");
                        }
                        else
                            MessageBox.Show("Hora no válida.");
                    }
                    else
                        MessageBox.Show("Hora no válida.");
                }
                else
                    MessageBox.Show("Hora no válida.");
            }
            else
                MessageBox.Show("Hora no válida.");
        }
    }
}
