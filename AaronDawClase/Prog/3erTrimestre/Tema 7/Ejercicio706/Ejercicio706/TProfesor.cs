using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio706
{
    class TProfesor
    {
        private string mName;
        private string mDNI;
        private int mPhone;
        private string mTutorCode;
        private List<string> mSubjects;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string DNI
        {
            get { return mDNI; }
            set { mDNI = value; }
        }

        public int Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public string TutorCode
        {
            get { return mTutorCode; }
            set { mTutorCode = value; }
        }

        public TProfesor()
        {
            mName = "";
            mDNI = "";
            mPhone = 0;
            mTutorCode = "";
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
            texto = texto + "Nombre: " + mName + "\n";
            texto = texto + "DNI: " + mDNI + "\n";
            texto = texto + "Teléfono: " + mPhone.ToString() + "\n";
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
