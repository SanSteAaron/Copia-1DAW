using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha fecha1 = new Fecha(12, 2012, 4, false);
            Console.WriteLine("Fecha 1: " + fecha1.ToString());
            if (fecha1.EsBisiesto())
                Console.WriteLine("El año " + fecha1.year + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha1.year + " no es bisiesto");

            Fecha fecha2 = new Fecha(10, 2013, 4, false);
            Console.WriteLine("Fecha 2: " + fecha2.ToString());
            if (fecha2.EsBisiesto())
                Console.WriteLine("El año " + fecha2.year + " es bisiesto");
            else
                Console.WriteLine("El año " + fecha2.year + " no es bisiesto");

            Fecha fecha3 = new Fecha(13, -4, 4, false);
            Console.WriteLine("Fecha 3: " + fecha3.ToString());

            Fecha fecha4 = new Fecha();
            fecha4.day = 67;
            fecha4.month = 80;
            fecha4.year = 3678;
            Console.WriteLine("Fecha 4: " + fecha4.ToString());
        }
    }
}