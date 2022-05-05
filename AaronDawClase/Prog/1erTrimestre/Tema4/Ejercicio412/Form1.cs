using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio412
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool bisiesto(int año)
        {
            bool res = false;
            int comprobante4 = año % 4;
            if(comprobante4 == 0)
            {
                res = true;
                int comprobante100 = año % 100;
                int comprobante400 = año % 400;
                if (comprobante100 == 0 && comprobante400 == 0)
                {
                    res = false;
                }
            }
            return res;
        }
        bool validación(int day, int month, int año)
        {
            bool res = false;
            bool bis = bisiesto(año);
            if (month >= 1 && month <= 12)
            {
                if (month == 2)
                {
                    if (bis == true)
                    {
                        if (day <= 29 && day >= 1)
                        {
                            res = true;
                        }
                    }
                    else
                    {
                        if (day >= 1 && day <= 28)
                        {
                            res = true;
                        }
                    }
                }
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day >= 1 && day <= 31)
                    {
                        res = true;
                    }
                }
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day >= 1 && day <= 30)
                    {
                        res = true;
                    }
                }
            }
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int year, dia, mes;
            year = int.Parse(CYear.Text);
            dia = int.Parse(CDay.Text);
            mes = int.Parse(CMonth.Text);
            bool valido = validación(dia, mes, year);
            if (valido == true)
            {
                MessageBox.Show("La fecha introducida es válida");
            }
            else
                MessageBox.Show("La fecha introducida no es válida");
        }
    }
}
