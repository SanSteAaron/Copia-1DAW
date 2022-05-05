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

namespace EjercicioAmp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num1, num2;
            string textoprimo = " ";
            bool primo = true;
            num1 = int.Parse(Interaction.InputBox("Introduce el primer número (Ha de ser mayor o igual a cero):"));
            num2 = int.Parse(Interaction.InputBox("Introduce el segundo número (Ha de ser mayor o igual a cero y mayor que el primer número introducido):"));
            if (num2 < num1)
            {
                MessageBox.Show("El primer número es mayor que el segundo." + "\n" + "El programa no funcionará.");
            }
            if(num2 > num1)
            {
                for(int i = num1; i <= num2; i++)
                {
                    if(i == 0 || i == 1)
                    {
                        i = 2;
                    }
                    for (int j = 2; j < i && primo; j++)
                    {
                        if(i % j == 0)
                        {
                            primo = false;

                        }                       
                    }
                    if (primo)
                    {
                        textoprimo = textoprimo + i + " ";
                    }
                    primo = true;
                }
                MessageBox.Show("Los números primos entre " + num1.ToString() + " y " + num2 + " son: " + textoprimo);
            }
        }
    }
}
