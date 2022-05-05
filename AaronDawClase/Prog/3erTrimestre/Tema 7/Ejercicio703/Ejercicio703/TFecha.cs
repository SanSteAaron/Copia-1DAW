using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio703
{
    class TFecha
    {
        private int mDay;
        private int mMonth;
        private int mYear;

        public int Day
        {
            get { return mDay; }
        }

        public int Month
        {
            get { return mMonth; }
        }

        public int Year
        {
            get { return mYear; }
        }

        public TFecha()
        {
            mDay = -1;
            mMonth = -1;
            mYear = -1;
        }

        private bool bisiesto(int year)
        {
            bool res;

            res = false;

            if (year % 4 == 0)
            {
                res = true;

                if (year % 100 == 0 && year % 400 != 0)
                    res = false;
            }

            return res;
        }

        private bool fechaValida(int day, int month, int year)
        {
            bool res = true;

            if (year < 0 || year > 2020)
                res = false;
            else
                if (month < 1 || month > 12)
                res = false;
            else
            {
                if (day < 1 || day > 31)   
                    res = false;
                else
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 30)
                        res = false;
                }
                else
                {
                    if (month == 2)
                    {
                        if (bisiesto(year))
                        {
                            if (day > 29)
                                res = false;
                        }
                        else
                        {
                            if (day > 28)
                                res = false;
                        }
                    }
                }
            }

            return res;
        }

        public bool darValores(int day, int month, int year)
        {
            bool correcta;

            correcta = fechaValida(day, month, year);

            if (correcta)
            {
                mDay = day;
                mMonth = month;
                mYear = year;
            }

            return correcta;
        }

        public string mostrarFecha()
        {
            return mDay + "/" + mMonth + "/" + mYear;
        }
    }
}
