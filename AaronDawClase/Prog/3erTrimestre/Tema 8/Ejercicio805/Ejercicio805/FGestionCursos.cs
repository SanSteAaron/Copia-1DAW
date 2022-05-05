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
    public partial class FGestionCursos : Form
    {
        public FGestionCursos()
        {
            InitializeComponent();
        }

        public TListaCursos listaCursos;
        public TListaPersonas listaPersonas;

        private void BAñadirCurso_Click(object sender, EventArgs e)
        {
            string name = (Interaction.InputBox("Introduce el nombre del curso:"));
            string code = (Interaction.InputBox("Introduce el código del curso:"));
            listaCursos.Añadir_Curso(name, code);
        }

        private void BEliminarCurso_Click(object sender, EventArgs e)
        {
            string code = (Interaction.InputBox("Introduce el código del curso:"));
            if (listaCursos.Eliminar_Curso(code) == true)
            {
                MessageBox.Show("El curso ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("El curso no esta registrado en el instituto.");
            }
        }

        private void BMostrarListaCursos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaCursos.Mostrar_Lista_Cursos());
        }

        private void BMostrarListaAlumnosCurso_Click(object sender, EventArgs e)
        {
            string code = (Interaction.InputBox("Introduce el código del curso:"));
            MessageBox.Show(listaPersonas.Mostrar_Alumnos_Curso(code));
        }
    }
}
