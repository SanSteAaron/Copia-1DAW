using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio704
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

        public bool cumpleanyos(string name)
        {
            int pos;
            TEmpleado empl;
            bool encontrado = false;
            pos = BuscarEmpleado(name);
            if (pos >= 0)
            {
                empl = mList[pos];
                empl.CumpleAnyos();
                encontrado = true;
            }
            return encontrado;
        }
    }
}
