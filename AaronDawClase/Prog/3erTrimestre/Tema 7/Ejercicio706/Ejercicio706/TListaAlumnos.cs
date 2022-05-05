using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio706
{
    public class TListaAlumnos
    {
        private List<TAlumno> listaAlumnos;

        public TListaAlumnos()
        {
            listaAlumnos = new List<TAlumno>();
        }

        public void Añadir_Alumno(string name, string dni,int phone,string cursocode)
        {
            TAlumno alumno = new TAlumno();
            alumno.Name = name;
            alumno.DNI = dni;
            alumno.Phone = phone;
            alumno.CursoCode = cursocode;
            listaAlumnos.Add(alumno);
        }

        public string Mostrar_Lista_Alumnos()
        {
            string texto = "Lista de Alumnos:\n";
            foreach (TAlumno alumno in listaAlumnos)
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
            while (i < listaAlumnos.Count && !encontrado)
            {
                alumno = listaAlumnos[i];
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
                alumno = listaAlumnos[pos];
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
                alumno = listaAlumnos[pos];
                listaAlumnos.Remove(alumno);
                encontrado = true;
            }
            return encontrado;
        } 

        public void Ordenar_Lista_Alumnos()
        {
            for (int i = 0; i < listaAlumnos.Count(); i++)
            {
                for (int j = i + 1; j < listaAlumnos.Count(); j++)
                {
                    if (string.Compare(listaAlumnos[i].Name, listaAlumnos[j].Name) > 0)
                    {
                        TAlumno aux = listaAlumnos[i];
                        listaAlumnos[i] = listaAlumnos[j];
                        listaAlumnos[j] = aux;
                    }
                }
            }
        }

        public string Mostrar_Alumnos_Curso(string cursocode)
        {
            string texto = "Los alumnos del curso " + cursocode + "son\n";
            foreach(TAlumno alumno in listaAlumnos)
            {
                if (alumno.CursoCode == cursocode)
                {
                    texto += alumno.Mostrar_Datos();
                }
            }
            return texto;
        }

        public bool Añadir_Notas_Alumno (string name, double grade)
        {
            int pos;
            TAlumno alumno;
            bool encontrado = false;
            pos = Buscar_Alumno(name);
            if (pos >= 0)
            {
                alumno = listaAlumnos[pos];
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
                alumno = listaAlumnos[pos];
                alumno.Eliminar_Notas();
                encontrado = true;
            }
            return encontrado;
        } 

        public string Mostrar_Alumnos_Aprobados()
        {
            string texto = "Los alumnos aprobados son:\n";
            foreach(TAlumno alumno in listaAlumnos)
            {
                if(alumno.Nota_Media() >= 5)
                {
                    texto += alumno.Mostrar_Datos() + "\n";
                }
            }
            return texto;
        }

        public string Mostrar_Alumnos_Suspendidos()
        {
            string texto = "Los alumnos suspendidos son:\n";
            foreach (TAlumno alumno in listaAlumnos)
            {
                if (alumno.Nota_Media() < 5)
                {
                    texto += alumno.Mostrar_Datos() + "\n";
                }
            }
            return texto;
        }
    }
}
