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
    public partial class FGestionDelInstituto : Form
    {
        public FGestionDelInstituto()
        {
            InitializeComponent();
        }

        TListaCursos listaCursos = new TListaCursos();
        TListaAlumnos listaAlumnos = new TListaAlumnos();
        TListaProfesores listaProfesores = new TListaProfesores();

        private void BGestiónCursos_Click(object sender, EventArgs e)
        {
            FGestionCursos fcursos = new FGestionCursos();

            fcursos.listaCursos = listaCursos;
            fcursos.listaAlumnos = listaAlumnos;
            fcursos.ShowDialog();
        }

        private void BGestiónAlumnos_Click(object sender, EventArgs e)
        {
            FGestionAlumnos falumnos = new FGestionAlumnos();

            falumnos.listaAlumnos = listaAlumnos;
            falumnos.listaCursos = listaCursos;
            falumnos.ShowDialog();
        }

        private void BGestiónProfesores_Click(object sender, EventArgs e)
        {
            FGestionProfesores fprofesores = new FGestionProfesores();

            fprofesores.listaProfesores = listaProfesores;
            fprofesores.listaCursos = listaCursos;
            fprofesores.ShowDialog();
        }
    }
}
