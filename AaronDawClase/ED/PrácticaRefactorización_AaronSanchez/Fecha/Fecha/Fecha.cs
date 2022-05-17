using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    public class Fecha
    {
        public int day;
        public int month;
        public int year;
        
        public Fecha()
        {
            day = 1;
            month = 1;
            year = 1;
        }
        
        public Fecha(int month, int year, int day)
        {
            if (year >= 1 && year <= 2500)
            {
                this.year = year;
            }
            else
            {
                this.year = 1;
            }
            if (month >= 1 && month <= 12)
                this.month = month;
            else
                this.month = 1;
            int diasMes = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diasMes = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diasMes = 30;
                    break;
                case 2: 
                    if (EsBisiesto() == true)
                        diasMes = 29;
                    else
                        diasMes = 28;
                    break;
            }
            if (day >= 1 && day <= diasMes)
                this.day = day;
            else
                this.day = 1;
        }
        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
            return bisiesto;
        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
