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

namespace Ejercicio805
{
    public partial class FGestionProfesores : Form
    {
        public FGestionProfesores()
        {
            InitializeComponent();
        }

        public TListaPersonas listaPersonas;
        public TListaCursos listaCursos;

        private void BIntroducirProfesor_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del profesor:"));
            string dni = (Interaction.InputBox("Introduce el DNI del profesor:"));
            int phone = int.Parse(Interaction.InputBox("Introduce el número de teléfono:"));
            string tutorcode = (Interaction.InputBox("Introduce el código del curso del que es tutor."));
            if (listaCursos.Buscar_Curso(tutorcode) >= 0)
            {
                listaPersonas.Añadir_Profesor(name, dni, phone, tutorcode);
            }
            else
            {
                MessageBox.Show("El curso introducido no existe, no se ha añadido el profesor.");
            }
        }

        private void BEliminarProfesor_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del profesor:"));
            if (listaPersonas.Eliminar_Profesor(name) == true)
            {
                MessageBox.Show("El profesor ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("El profesor no esta registrado en el instituto.");
            }
        }

        private void BMostrarListaProfesores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaPersonas.Mostrar_Lista_Profesores());
        }

        private void BOrdenarProfesores_Click(object sender, EventArgs e)
        {
            listaPersonas.Ordenar_Lista_Profesores();
        }

        private void BMostrarDatosProfesor_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del profesor:"));
            MessageBox.Show(listaPersonas.Mostrar_Profesor(name));
        }

        private void BAñadirAsignatura_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del profesor:"));
            string subject = (Interaction.InputBox("Introduce la asignatura:"));
            if (listaPersonas.Añadir_Asignaturas_Profesor(name, subject) == true)
            {
                MessageBox.Show("La asignatura ha sido introducida correctamente.");
            }
            else
            {
                MessageBox.Show("El profesor no esta registrado en el instituto.");
            }
        }

        private void BEliminarAsignaturas_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del profesor:"));
            if (listaPersonas.Eliminar_Asignaturas_Profesor(name) == true)
            {
                MessageBox.Show("Se han borrado correctamente las asignaturas del profesor.");
            }
            else
            {
                MessageBox.Show("El profesor no esta registrado en el instituto.");
            }
        }

        private void BMostrarListaProfesoresAsignatura_Click(object sender, EventArgs e)
        {
            string subject = (Interaction.InputBox("Introduce la asignatura:"));
            MessageBox.Show(listaPersonas.Mostrar_Profesores_Asignatura(subject));
        }
    }
}
