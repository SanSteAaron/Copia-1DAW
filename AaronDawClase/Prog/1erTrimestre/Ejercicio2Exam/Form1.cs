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

namespace Ejercicio2Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            int num, contadorpositive, contadornegative;
            contadorpositive = 0;
            contadornegative = 0;
            num = 1;
            while ( num < 0 || num > 0)
            {
                num = int.Parse(Interaction.InputBox("Introduce un número"));
                if (num > 0)
                {
                    contadorpositive++;
                }
                if(num < 0)
                {
                    contadornegative++;
                }
            }
            if(num == 0)
            {
                MessageBox.Show("Números positivos: " + contadorpositive.ToString()+ " y números negativos: " + contadornegative.ToString());
            }
        }
    }
}
