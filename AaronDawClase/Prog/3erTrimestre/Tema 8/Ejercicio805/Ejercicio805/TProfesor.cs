using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio805
{
    class TProfesor : TPersona
    {
        private string mTutorCode;
        private List<string> mSubjects;

        public string TutorCode
        {
            get { return mTutorCode; }
            set { mTutorCode = value; }
        }

        public TProfesor(string name, string dni, int phone,string tutorcode) : base (name,dni,phone)
        {
            mTutorCode = tutorcode;
            mSubjects = new List<string>();
        }

        private string Mostrar_Asignaturas()
        {
            string texto;
            int i;
            if (mSubjects.Count > 0)
            {
                texto = "Las asignaturasque imparte son: ";
                for (i = 0; i < mSubjects.Count; i++)
                    texto = texto + mSubjects[i] + ", ";

                texto = texto + "\n";
            }
            else
                texto = "Profesor sin asignaturas.\n";
            return texto;
        }

        public bool Comprobar_Asignatura(string asignatura)
        {
            int i = 0;
            bool comprobar = false;
            while (i < mSubjects.Count && comprobar)
            {
                string subject = mSubjects[i];
                if( subject == asignatura)
                {
                    comprobar = true;
                }
            }
            return comprobar;
        }

        public void Añadir_Asignatura(string subject)
        {
            mSubjects.Add(subject);
        }

        public string Mostrar_Datos()
        {
            string texto;

            texto = "Datos del Profesor:\n";
            texto = texto + "Nombre: " + Name + "\n";
            texto = texto + "DNI: " + DNI + "\n";
            texto = texto + "Teléfono: " + Phone.ToString() + "\n";
            texto = texto + "Código del curso del que es tutor: " + mTutorCode + "\n";
            texto = texto + Mostrar_Asignaturas();

            return texto;
        }

        public void Eliminar_Asignaturas()
        {
            mSubjects.Clear();
        }
    }
}
