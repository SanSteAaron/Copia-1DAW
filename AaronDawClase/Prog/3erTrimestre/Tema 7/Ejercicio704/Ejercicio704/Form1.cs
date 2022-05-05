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

namespace Ejercicio704
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TListaEmpleados empresa = new TListaEmpleados();

        private void BEmpleado_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            name = Interaction.InputBox("Introduzca el nombre.");
            age = int.Parse(Interaction.InputBox("Introduzca la edad."));
            empresa.AnyadirEmpleado(name, age);
        }

        private void BMostrarListaEmpleados_Click(object sender, EventArgs e)
        {
            string texto;
            texto = empresa.MostrarListaEmpleados();
            MessageBox.Show(texto);
        }

        private void BCumpleañosEmpleado_Click(object sender, EventArgs e)
        {
            string name;
            double sale;
            bool right;
            name = Interaction.InputBox("Introduzca el nombre.");
            sale = double.Parse(Interaction.InputBox("Introduzca la venta."));
            right = empresa.AnyadirVenta(name, sale);
            if (right)
                MessageBox.Show("Se ha añadido correctamente la venta.");
            else
                MessageBox.Show("No se ha encontrado el empleado.");
        }

        private void BAñadirVenta_Click(object sender, EventArgs e)
        {
            string name;
            bool right;
            name = Interaction.InputBox("Introduzca el nombre.");
            right = empresa.cumpleanyos(name);
            if (!right)
                MessageBox.Show("No se ha encontrado el empleado.");
        }
    }
}
