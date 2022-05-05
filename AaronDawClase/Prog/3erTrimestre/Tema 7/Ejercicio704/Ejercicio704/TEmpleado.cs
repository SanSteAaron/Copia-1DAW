using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio704
{
    class TEmpleado
    {
        private string mName;
        private int mAge;
        private List<double> mSales;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set
            {
                if (value >= 0 && value <= 100)
                    mAge = value;
            }
        }

        public TEmpleado()
        {
            mName = "";
            mAge = 0;
            mSales = new List<double>();
        }

        public void CumpleAnyos()
        {
            mAge = mAge + 1;
        }

        public void AnyadirVenta(double sale)
        {
            if (sale > 0)
                mSales.Add(sale);
        }

        private string MostrarVentas()
        {
            string texto;
            int i;

            if (mSales.Count > 0)
            {
                texto = "Las ventas son : ";
                for (i = 0; i < mSales.Count; i++)
                    texto = texto + mSales[i] + ", ";

                texto = texto + "\n";
            }
            else
                texto = "Empleado sin ventas.\n";

            return texto;
        }

        public string MostrarDatos()
        {
            string texto;

            texto = "Datos del empleado:\n";
            texto = texto + "Nombre: " + mName + "\n";
            texto = texto + "Edad: " + mAge + "\n";
            texto = texto + MostrarVentas();

            return texto;
        }
    }
}
