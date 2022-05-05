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

namespace Ejercicio701
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TPersona per = new TPersona();

        private void B_Introducir_datos_Click(object sender, EventArgs e)
        {
            string sexo;
            DialogResult casado;

            per.Name = Interaction.InputBox("Introduzca el nombre: ");
            per.Age = int.Parse(Interaction.InputBox("Introduzca la edad: "));
            per.Phone = Interaction.InputBox("Introduzca el teléfono: ");

            do
            {
                sexo = Interaction.InputBox("Introduzca el sexo (M - Maculino / F - Femenino): ");
            } while (sexo != "M" && sexo != "F");

            if (sexo == "M")
                per.Sex = 'M';
            else
                per.Sex = 'F';

            casado = MessageBox.Show("¿Está casado?", "Casado", MessageBoxButtons.YesNo);
            if (casado == DialogResult.Yes)
                per.Married = true;
            else
                per.Married = false;
        }

        private void B_Mostrar_datos_Click(object sender, EventArgs e)
        {
            string texto;
            texto = per.Mostrar_Datos();
            MessageBox.Show(texto);
        }
    }
}
