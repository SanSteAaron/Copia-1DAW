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

namespace Ejercicio706
{
    public partial class FGestionAlumnos : Form
    {
        public FGestionAlumnos()
        {
            InitializeComponent();
        }

        public TListaAlumnos listaAlumnos;
        public TListaCursos listaCursos;

        private void BIntroducirAlumno_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del alumno:"));
            string dni = (Interaction.InputBox("Introduce el DNI del alumno:"));
            int phone = int.Parse(Interaction.InputBox("Introduce el número de teléfono:"));
            string cursocode = (Interaction.InputBox("Introduce el código del curso al que pertenece:"));
            int existe = listaCursos.Buscar_Curso(cursocode);
            if ( existe < 0)
            {
                MessageBox.Show("El curso introducido no existe, no se ha añadido el alumno.");
            }
            else
            {
                listaAlumnos.Añadir_Alumno(name, dni, phone, cursocode);
            }
        }

        private void BEliminarAlumno_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del alumno:"));
            if (listaAlumnos.Eliminar_Alumno(name) == true)
            {
                MessageBox.Show("El alumno ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("El alumno no esta registrado en el instituto.");
            }
        }

        private void BMostrarListaAlumnos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.Mostrar_Lista_Alumnos());
        }

        private void BOrdenarAlumnos_Click(object sender, EventArgs e)
        {
            listaAlumnos.Ordenar_Lista_Alumnos();
        }

        private void BMostrarListaAlumnosCurso2_Click(object sender, EventArgs e)
        {
            string cursocode = (Interaction.InputBox("Introduce el código del curso:"));
            if (listaCursos.Buscar_Curso(cursocode) >= 0)
                MessageBox.Show(listaAlumnos.Mostrar_Alumnos_Curso(cursocode));
            else
                MessageBox.Show("El curso introducido no existe.");
        }

        private void BMostrarDatosAlumno_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce elnombre del alumno:"));
            MessageBox.Show(listaAlumnos.Mostrar_Alumno(name));
        }

        private void BAñadirNotas_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del alumno:"));
            double grade = double.Parse(Interaction.InputBox("Introduce la nota:"));
            if (listaAlumnos.Añadir_Notas_Alumno(name,grade) == true)
            {
                MessageBox.Show("La nota ha sido introducida correctamente.");
            }
            else
            {
                MessageBox.Show("El alumno no esta registrado en el instituto.");
            }
        }

        private void BEliminarNotas_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del alumno:"));
            if (listaAlumnos.Eliminar_Notas_Alumno(name) == true)
            {
                MessageBox.Show("Se han borrado correctamente las notas del alumno.");
            }
            else
            {
                MessageBox.Show("El alumno no esta registrado en el instituto.");
            }
        }

        private void BMostrarAprobados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.Mostrar_Alumnos_Aprobados());
        }

        private void BMostrarSuspendidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.Mostrar_Alumnos_Suspendidos());
        }
    }
}
