using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio805
{
    public class TListaPersonas
    {
        private List<TPersona> mListaPersonas;
        private List<TAlumno> mListaAlumnos;
        private List<TProfesor> mListaProfesores;
        public TListaPersonas()
        {
            mListaPersonas = new List<TPersona>();
            mListaAlumnos = new List<TAlumno>();
            mListaProfesores = new List<TProfesor>();
        }

        public void Añadir_Alumno(string nombre, string dni, int phone, string codCurso)
        {
            TAlumno alumno = new TAlumno(nombre, dni, phone, codCurso);
            mListaPersonas.Add(alumno);
            mListaAlumnos.Add(alumno);
        }

        public string Mostrar_Lista_Alumnos()
        {
            string texto = "Lista de Alumnos:\n";
            foreach (TAlumno alumno in mListaAlumnos)
            {
                texto = texto + alumno.Mostrar_Datos();
            }
            return texto;
        }

        public int Buscar_Alumno(string name)
        {
            int pos = -1, i;
            bool encontrado = false;
            TAlumno alumno;
            i = 0;
            while (i < mListaAlumnos.Count() && !encontrado)
            {
                alumno = mListaAlumnos[i];
                if (alumno.Name == name)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }
            return pos;
        }

        public string Mostrar_Alumno(string name)
        {
            int pos;
            TAlumno alumno;
            string texto = "El alumno no esta registrado en el instituto.";
            pos = Buscar_Alumno(name);
            if (pos >= 0)
            {
                alumno = mListaAlumnos[pos];
                texto = alumno.Mostrar_Datos();
            }
            return texto;
        }

        public bool Eliminar_Alumno(string name)
        {
            int pos;
            TAlumno alumno;
            bool encontrado = false;
            pos = Buscar_Alumno(name);
            if (pos >= 0)
            {
                alumno = mListaAlumnos[pos];
                mListaAlumnos.Remove(alumno);
                encontrado = true;
            }
            return encontrado;
        }

        public void Ordenar_Lista_Alumnos()
        {
            for (int i = 0; i < mListaAlumnos.Count(); i++)
            {
                for (int j = i + 1; j < mListaAlumnos.Count(); j++)
                {
                    if (string.Compare(mListaAlumnos[i].Name, mListaAlumnos[j].Name) > 0)
                    {
                        TAlumno aux = mListaAlumnos[i];
                        mListaAlumnos[i] = mListaAlumnos[j];
                        mListaAlumnos[j] = aux;
                    }
                }
            }
        }

        public string Mostrar_Alumnos_Curso(string cursocode)
        {
            string texto = "Los alumnos del curso " + cursocode + "son\n";
            foreach (TAlumno alumno in mListaAlumnos)
            {
                if (alumno.CursoCode == cursocode)
                {
                    texto += alumno.Mostrar_Datos();
                }
            }
            return texto;
        }

        public bool Añadir_Notas_Alumno(string name, double grade)
        {
            int pos;
            TAlumno alumno;
            bool encontrado = false;
            pos = Buscar_Alumno(name);
            if (pos >= 0)
            {
                alumno = mListaAlumnos[pos];
                alumno.Añadir_Nota(grade);
                encontrado = true;
            }
            return encontrado;
        }

        public bool Eliminar_Notas_Alumno(string name)
        {
            int pos;
            TAlumno alumno;
            bool encontrado = false;
            pos = Buscar_Alumno(name);
            if (pos >= 0)
            {
                alumno = mListaAlumnos[pos];
                alumno.Eliminar_Notas();
                encontrado = true;
            }
            return encontrado;
        }

        public string Mostrar_Alumnos_Aprobados()
        {
            string texto = "Los alumnos aprobados son:\n";
            foreach (TAlumno alumno in mListaAlumnos)
            {
                if (alumno.Nota_Media() >= 5)
                {
                    texto += alumno.Mostrar_Datos() + "\n";
                }
            }
            return texto;
        }

        public string Mostrar_Alumnos_Suspendidos()
        {
            string texto = "Los alumnos suspendidos son:\n";
            foreach (TAlumno alumno in mListaAlumnos)
            {
                if (alumno.Nota_Media() < 5)
                {
                    texto += alumno.Mostrar_Datos() + "\n";
                }
            }
            return texto;
        }

        public void Añadir_Profesor(string nombre, string dni, int phone, string tutorcode)
        {
            TProfesor profesor = new TProfesor(nombre, dni, phone, tutorcode);
            mListaPersonas.Add(profesor);
            mListaProfesores.Add(profesor);
        }

        public string Mostrar_Lista_Profesores()
        {
            string texto = "Lista de Profesores:\n";
            foreach (TProfesor profesor in mListaProfesores)
            {
                texto = texto + profesor.Mostrar_Datos();
            }
            return texto;
        }

        private int Buscar_Profesores(string name)
        {
            int pos = -1, i;
            bool encontrado = false;
            TProfesor profesor;
            i = 0;
            while (i < mListaProfesores.Count && !encontrado)
            {
                profesor = mListaProfesores[i];
                if (profesor.Name == name)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }
            return pos;
        }

        public string Mostrar_Profesor(string name)
        {
            int pos;
            TProfesor profesor;
            string texto = "El alumno no esta registrado en el instituto.";
            pos = Buscar_Profesores(name);
            if (pos >= 0)
            {
                profesor = mListaProfesores[pos];
                texto = profesor.Mostrar_Datos();
            }
            return texto;
        }

        public bool Eliminar_Profesor(string name)
        {
            int pos;
            TProfesor profesor;
            bool encontrado = false;
            pos = Buscar_Profesores(name);
            if (pos >= 0)
            {
                profesor = mListaProfesores[pos];
                mListaProfesores.Remove(profesor);
                encontrado = true;
            }
            return encontrado;
        }

        public void Ordenar_Lista_Profesores()
        {
            for (int i = 0; i < mListaProfesores.Count(); i++)
            {
                for (int j = i + 1; j < mListaProfesores.Count(); j++)
                {
                    if (string.Compare(mListaProfesores[i].Name, mListaProfesores[j].Name) > 0)
                    {
                        TProfesor aux = mListaProfesores[i];
                        mListaProfesores[i] = mListaProfesores[j];
                        mListaProfesores[j] = aux;
                    }
                }
            }
        }

        public string Mostrar_Profesores_Asignatura(string subject)
        {
            string texto = "Los profesores que imparten la asignatura de " + subject + "son:\n";
            foreach (TProfesor profesor in mListaProfesores)
            {
                if (profesor.Comprobar_Asignatura(subject) == true)
                {
                    texto += profesor.Mostrar_Datos() + "\n";
                }
            }
            return texto;
        }

        public bool Añadir_Asignaturas_Profesor(string name, string subject)
        {
            int pos;
            TProfesor profesor;
            bool encontrado = false;
            pos = Buscar_Profesores(name);
            if (pos >= 0)
            {
                profesor = mListaProfesores[pos];
                profesor.Añadir_Asignatura(subject);
                encontrado = true;
            }
            return encontrado;
        }

        public bool Eliminar_Asignaturas_Profesor(string name)
        {
            int pos;
            TProfesor profesor;
            bool encontrado = false;
            pos = Buscar_Profesores(name);
            if (pos >= 0)
            {
                profesor = mListaProfesores[pos];
                profesor.Eliminar_Asignaturas();
                encontrado = true;
            }
            return encontrado;
        }
    }
}
