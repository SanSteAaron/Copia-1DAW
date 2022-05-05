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

namespace Ejercicio507
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 10;
        int[] vector = new int[kNUM];
        void LeerVectorComprobar (int [] vector, ref int num, ref bool comprobante)
        {
            comprobante = true;
            int vmayor = vector[num];
            while (num < kNUM && comprobante == true)
            {
                vector[num] = int.Parse(Interaction.InputBox("Introduce un número mayor que el anterior: "));
                if (vector[num] > vmayor)
                {
                    vmayor = vector[num];
                }
                else
                    comprobante = false;
                num++;
            }
        }

        private void Bvector_Click(object sender, EventArgs e)
        {
            int num = 0;
            bool comprobante = true;
            LeerVectorComprobar(vector, ref num, ref comprobante);
            while(comprobante == false)
            {
                    MessageBox.Show("El número inroducido no es mayor que el anterior.");
                    LeerVectorComprobar(vector, ref num, ref comprobante);
            }
            MessageBox.Show("Has introducido todos los números correctamente.");
        }
    }
}
