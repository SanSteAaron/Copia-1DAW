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

namespace Ejercicio702
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<TPersona> personas = new List<TPersona>();

        private void BIntroducir_Persona_Click(object sender, EventArgs e)
        {
            TPersona per = new TPersona();
            DialogResult persona;
            do
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
                personas.Add(per);
                persona = MessageBox.Show("¿Quieres seguir introduciendo datos?", "Introducir persona", MessageBoxButtons.YesNo);
            }
            while (persona == DialogResult.Yes);
        }

        private void BMostrar_Datos_Click(object sender, EventArgs e)
        {
            string texto = "Lista de personas:" + "\n" + "\n";
            foreach(TPersona per in personas)
            {
                texto += per.Mostrar_Datos() + "\n";
            }
            MessageBox.Show(texto);
        }
    }
}
