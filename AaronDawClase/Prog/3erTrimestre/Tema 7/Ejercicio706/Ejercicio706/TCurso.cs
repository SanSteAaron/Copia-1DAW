using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio706
{
    class TCurso
    {
        private string mName;
        private string mCode;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Code
        {
            get { return mCode; }
            set { mCode = value; }
        }

        public TCurso()
        {
            mName = "";
            mCode = "";
        }

        public string Mostrar_Datos()
        {
            string texto;

            texto = "Datos del curso:\n";
            texto = texto + "Nombre: " + mName + "\n";
            texto = texto + "Código: " + mCode + "\n";

            return texto;
        }
    }
}
