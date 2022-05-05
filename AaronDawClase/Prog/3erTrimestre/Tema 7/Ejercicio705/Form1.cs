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

namespace Ejercicio705
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TListaEmpleados empresa = new TListaEmpleados();

        private void BIntroducirEmpleado_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            name = Interaction.InputBox("Introduzca el nombre.");
            age = int.Parse(Interaction.InputBox("Introduzca la edad."));
            empresa.AnyadirEmpleado(name, age);
        }

        private void BEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string name;
            name = Interaction.InputBox("Introduzca el nombre del empleado que desea eliminar.");
            if (empresa.EliminarEmpleado(name) == true)
            {
                MessageBox.Show("El empleado con nombre " + name + " ha sido eliminado correctamente.");
            }
            else
                MessageBox.Show("El empleado con nombre " + name + " no existe en la empresa.");
        }

        private void BMostrarDatosEmpleados_Click(object sender, EventArgs e)
        {
            string name;
            name = Interaction.InputBox("Introduzca el nombre del empleado que quiere mostrar.");
            MessageBox.Show(empresa.MostrarDatosEmpleados(name));
        }

        private void BMostrarListaEmpleados_Click(object sender, EventArgs e)
        {
            string texto;
            texto = empresa.MostrarListaEmpleados();
            MessageBox.Show(texto);
        }

        private void BOrdEmpleados_Click(object sender, EventArgs e)
        {
            empresa.OrdenarListaEmpleados();
        }

        private void BAñadirVentasEmpleado_Click(object sender, EventArgs e)
        {
            string name;
            double sale;
            bool right;
            name = Interaction.InputBox("Introduzca el nombre del empleado.");
            sale = double.Parse(Interaction.InputBox("Introduzca la venta."));
            right = empresa.AnyadirVenta(name, sale);
            if (right)
                MessageBox.Show("Se ha añadido correctamente la venta.");
            else
                MessageBox.Show("No existe el con nombre " + name + " empleado en la empresa.");
        }

        private void BEliminarVentasEmpleado_Click(object sender, EventArgs e)
        {
            string name;
            name = Interaction.InputBox("Introduce el nombre del empleado.");
            if (empresa.EliminarVentas(name) == true)
            {
                MessageBox.Show("Las ventas del empleado " + name + " han sido eliminadas correctamente.");
            }
            else
                MessageBox.Show("El empleado con nombre " + name + " no se encuentra en la empresa.");
        }

        private void BMostrarEmpleadoMayorVentas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empresa.MostrarEmpleadoConMayorVentas());
        }

        private void BOrdEmpleadosVentas_Click(object sender, EventArgs e)
        {
            empresa.OrdenarEmpleadoVentas();
        }
    }
}
