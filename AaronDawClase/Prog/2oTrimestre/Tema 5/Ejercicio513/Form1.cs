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

namespace Ejercicio513
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kNUM = 10;
        int[] vector = new int[kNUM];

        void LeerVector ( int [] vector)
        {
            for (int i = 0; i < kNUM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número: "));
            }
        }

        bool ComprobarNúmero (int [] vector)
        {
            int num = int.Parse(Interaction.InputBox("Introduce el número que quieras comprobar: "));
            bool comprobante = false;
            for (int i = 0; i < kNUM && comprobante == false; i++)
            {
                if (num == vector[i])
                {
                    comprobante = true;
                }
            }
            return comprobante;
        }

        private void BLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void BComprobarYMostrar_Click(object sender, EventArgs e)
        {
            if (ComprobarNúmero(vector) == true)
            {
                MessageBox.Show("El número introducido se encuentra en el vector.");
            }
            else
                MessageBox.Show("El número introducido no se encuentra en el vector.");
        }
    }
}
