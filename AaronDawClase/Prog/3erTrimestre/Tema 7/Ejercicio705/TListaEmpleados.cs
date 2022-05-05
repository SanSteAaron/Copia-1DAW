using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio705
{
    class TListaEmpleados
    {
        private List<TEmpleado> mList;

        public TListaEmpleados()
        {
            mList = new List<TEmpleado>();
        }

        public void AnyadirEmpleado(string name, int age)
        {
            TEmpleado empl = new TEmpleado();
            empl.Name = name;
            empl.Age = age;
            mList.Add(empl);
        }

        public string MostrarListaEmpleados()
        {
            string texto = "Lista de Empleados:\n";
            foreach (TEmpleado empl in mList)
            {
                texto = texto + empl.MostrarDatos();
            }
            return texto;
        }

        private int BuscarEmpleado(string name)
        {
            int pos = -1, i;
            bool encontrado = false;
            TEmpleado empl;
            i = 0;
            while (i < mList.Count && !encontrado)
            {
                empl = mList[i];
                if (empl.Name == name)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }
            return pos;
        }

        public string MostrarDatosEmpleados(string name)
        {
            int pos;
            TEmpleado empl;
            string texto = "";
            pos = BuscarEmpleado(name);
            if (pos >= 0)
            {
                empl = mList[pos];
                texto = empl.MostrarDatos();
            }
            else
                texto = "El empleado introducido no se encuentra en la empresa.";
            return texto;
        }

        public bool AnyadirVenta(string name, double sale)
        {
            int pos;
            TEmpleado empl;
            bool encontrado = false;
            pos = BuscarEmpleado(name);
            if (pos >= 0)
            {
                empl = mList[pos];
                empl.AnyadirVenta(sale);
                encontrado = true;
            }
            return encontrado;
        }

        public bool EliminarVentas(string name)
        {
            int pos;
            TEmpleado empl;
            bool encontrado = false;
            pos = BuscarEmpleado(name);
            if (pos >= 0)
            {
                empl = mList[pos];
                empl.EliminarVentas();
                encontrado = true;
            }
            return encontrado;
        }

        public void OrdenarEmpleadoVentas()
        {
            for (int i = 0; i < mList.Count(); i++)
            {
                for (int j = i + 1; j < mList.Count(); j++)
                {
                    if (mList[i].SumaVentas() < mList[j].SumaVentas())
                    {
                        TEmpleado aux = mList[i];
                        mList[i] = mList[j];
                        mList[j] = aux;
                    }
                }
            }
        }

        public string MostrarEmpleadoConMayorVentas()
        {
            string texto = "El empleado con mayores ventas es: ";
            TEmpleado mayorventas = mList[0];
            for (int i = 1; i < mList.Count(); i++)
            {
                if(mayorventas.SumaVentas() < mList[i].SumaVentas())
                {
                    mayorventas = mList[i];
                }
            }
            texto += "\n" + mayorventas.MostrarDatos();
            return texto;
        }
        public bool EliminarEmpleado(string name)
        {
            int pos;
            TEmpleado empl;
            bool encontrado = false;
            pos = BuscarEmpleado(name);
            if (pos >= 0)
            {
                empl = mList[pos];
                mList.Remove(empl);
                encontrado = true;
            }
            return encontrado;
        }

        public void OrdenarListaEmpleados ()
        {
            for(int i = 0; i < mList.Count(); i++)
            {
                for(int j = i + 1;j < mList.Count();j++)
                {
                    if(string.Compare(mList[i].Name, mList[j].Name) > 0)
                    {
                        TEmpleado aux = mList[i];
                        mList[i] = mList[j];
                        mList[j] = aux;
                    }
                }
            }
        }
    }
}
