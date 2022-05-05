using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio706
{
    class TAlumno
    {
        private string mName;
        private string mDNI;
        private int mPhone;
        private string mCursoCode;
        private List<double> mGrades;

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

        public string CursoCode
        {
            get { return mCursoCode; }
            set { mCursoCode = value; }
        }

        public TAlumno()
        {
            mName = "";
            mDNI = "";
            mPhone = 0;
            mCursoCode = "";
            mGrades = new List<double>();
        }

        private string Mostrar_Notas()
        {
            string texto;
            int i;
            if (mGrades.Count > 0)
            {
                texto = "Las notas son: ";
                for (i = 0; i < mGrades.Count; i++)
                    texto = texto + mGrades[i] + ", ";

                texto = texto + "\n";
            }
            else
                texto = "Alumno sin notas.\n";
            return texto;
        }

        public double Nota_Media()
        {
            double notamedia = 0;
            if(mGrades.Count > 0)
            {
                double notatotal = 0;
                foreach(double nota in mGrades)
                {
                    notatotal += nota;
                }
                notamedia = notatotal / mGrades.Count;
            }
            return notamedia;
        }

        public void Añadir_Nota(double grade)
        {
                mGrades.Add(grade);
        }

        public string Mostrar_Datos()
        {
            string texto;

            texto = "Datos del Alumno:\n";
            texto = texto + "Nombre: " + mName + "\n";
            texto = texto + "DNI: " + mDNI + "\n";
            texto = texto + "Teléfono: " + mPhone.ToString() + "\n";
            texto = texto + "Código del cuerso: " + mCursoCode + "\n";
            texto = texto + Mostrar_Notas();

            return texto;
        }

        public void Eliminar_Notas()
        {
            mGrades.Clear();
        }
    }
}
