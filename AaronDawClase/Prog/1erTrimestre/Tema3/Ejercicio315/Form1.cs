using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio315
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num, menor, mayor;
            num = int.Parse(Interaction.InputBox("Introducir un número."));
            mayor = num;
            menor = num;
            if (num >= 0)
            {
                while (num >= 0)
                {
                    num = int.Parse(Interaction.InputBox("Introducir un número."));
                    if (mayor < num)
                    {
                        mayor = num;
                    }
                    if (num >= 0)
                    {
                        if (menor > num)
                        {
                            menor = num;
                        }
                    }                
                }
                MessageBox.Show("El número mayor es el " + mayor.ToString() + " y el menor es el " + menor.ToString());
            }
            else
                MessageBox.Show("Error.");
        }
    }
}
