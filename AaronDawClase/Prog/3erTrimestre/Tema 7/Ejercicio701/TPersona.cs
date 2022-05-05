using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio701
{
    class TPersona
    {
        private string MName;
        private int MAge;
        private string MPhone;
        private char MSex;
        private bool MMarried;

        public string Name
        {
            get { return MName; }
            set { MName = value; }
        }

        public int Age
        {
            get { return MAge; }
            set
            {
                if (value >= 0 && value <= 100)
                    MAge = value;
            }
        }

        public string Phone
        {
            get { return MPhone; }
            set { MPhone = value; }
        }

        public char Sex
        {
            get { return MSex; }
            set
            {
                if (value == 'M' || value == 'F')
                    MSex = value;
            }

        }

        public bool Married
        {
            get { return MMarried; }
            set { MMarried = value; }
        }

        public TPersona()
        {
            MName = "";
            MAge = 0;
        }

        public string Mostrar_Datos()
        {
            string texto;

            texto = "Datos:\n";
            texto = texto + "Nombre: " + MName + "\n";
            texto = texto + "Edad: " + MAge + "\n";
            texto = texto + "Teléfono: " + MPhone + "\n";

            if (MSex == 'M')
                texto = texto + "Sexo: Masculino\n";
            else
                texto = texto + "Sexo: Femenino\n";

            if (MMarried)
                texto = texto + "Casado\n";
            else
                texto = texto + "Soltero\n";

            return texto;
        }
    }
}
