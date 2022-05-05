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

namespace Ejercicio516
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 10;
        int[] vector = new int[kNUM];

        void LeerVector (int [] vector)
        {
            int i = 0;
            while( i < kNUM)
            {
                bool comprobante = false;
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número sin repetir los introducidos anteriormente: "));
                for ( int j = 0; j < kNUM && comprobante == false;j++)
                {
                    if(j != i)
                    {
                        if (vector[i] == vector[j])
                        {
                            comprobante = true;
                        }
                    }
                }
                if (comprobante == false)
                {
                    i++;
                }
                else
                {
                    MessageBox.Show("El número introducido ya existe dentro del vector por favor introduce otro que no se haya introducido anteriormente.");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }
    }
}
