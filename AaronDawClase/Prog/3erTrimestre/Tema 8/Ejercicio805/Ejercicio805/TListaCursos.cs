using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio805
{
    public class TListaCursos
    {
        private List<TCurso> listaCursos;

        public TListaCursos()
        {
            listaCursos = new List<TCurso>();
        }

        public void Añadir_Curso(string name,string code)
        {
            TCurso curso = new TCurso();
            curso.Name = name;
            curso.Code = code;
            listaCursos.Add(curso);
        }

        public string Mostrar_Lista_Cursos()
        {
            string texto = "Lista de Cursos:\n";
            foreach (TCurso curso in listaCursos)
            {
                texto = texto + curso.Mostrar_Datos();
            }
            return texto;
        }

        public int Buscar_Curso(string code)
        {
            int pos = -1, i;
            bool encontrado = false;
            TCurso curso;
            i = 0;
            while (i < listaCursos.Count && !encontrado)
            {
                curso = listaCursos[i];
                if (curso.Code == code)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }
            return pos;
        }

        public bool Eliminar_Curso(string code)
        {
            int pos;
            TCurso curso;
            bool encontrado = false;
            pos = Buscar_Curso(code);
            if (pos >= 0)
            {
                curso = listaCursos[pos];
                listaCursos.Remove(curso);
                encontrado = true;
            }
            return encontrado;
        }

    }
}
