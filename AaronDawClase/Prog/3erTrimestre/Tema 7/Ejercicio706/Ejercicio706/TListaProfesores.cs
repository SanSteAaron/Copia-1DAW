using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio706
{
    public class TListaProfesores
    {
        private List<TProfesor> listaProfesores;

        public TListaProfesores()
        {
            listaProfesores = new List<TProfesor>();
        }

        public void Añadir_Profesor(string name, string dni, int phone, string tutorCode)
        {
            TProfesor profesor = new TProfesor();
            profesor.Name = name;
            profesor.DNI = dni;
            profesor.Phone = phone;
            profesor.TutorCode = tutorCode;
            listaProfesores.Add(profesor);
        }

        public string Mostrar_Lista_Profesores()
        {
            string texto = "Lista de Profesores:\n";
            foreach (TProfesor profesor in listaProfesores)
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
            while (i < listaProfesores.Count && !encontrado)
            {
                profesor = listaProfesores[i];
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
                profesor = listaProfesores[pos];
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
                profesor = listaProfesores[pos];
                listaProfesores.Remove(profesor);
                encontrado = true;
            }
            return encontrado;
        }

        public void Ordenar_Lista_Profesores()
        {
            for (int i = 0; i < listaProfesores.Count(); i++)
            {
                for (int j = i + 1; j < listaProfesores.Count(); j++)
                {
                    if (string.Compare(listaProfesores[i].Name, listaProfesores[j].Name) > 0)
                    {
                        TProfesor aux = listaProfesores[i];
                        listaProfesores[i] = listaProfesores[j];
                        listaProfesores[j] = aux;
                    }
                }
            }
        }

        public string Mostrar_Profesores_Asignatura(string subject)
        {
            string texto = "Los profesores que imparten la asignatura de " + subject + "son:\n";
            foreach (TProfesor profesor in listaProfesores)
            {
                if (profesor.Comprobar_Asignatura(subject) == true)
                {
                    texto += profesor.Mostrar_Datos() + "\n";
                }
            }
            return texto;
        }

        public bool Añadir_Asignaturas_Profesor(string name,string subject)
        {
            int pos;
            TProfesor profesor;
            bool encontrado = false;
            pos = Buscar_Profesores(name);
            if (pos >= 0)
            {
                profesor = listaProfesores[pos];
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
                profesor = listaProfesores[pos];
                profesor.Eliminar_Asignaturas();
                encontrado = true;
            }
            return encontrado;
        }
    }
}
