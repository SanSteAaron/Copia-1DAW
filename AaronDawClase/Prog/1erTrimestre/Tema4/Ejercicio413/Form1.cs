using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio413
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Bisiesto(int año)
        {
            bool res = false;
            int comprobante4 = año % 4;
            if (comprobante4 == 0)
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
        bool Validación(int day, int month, int año)
        {
            bool res = false;
            bool bis = Bisiesto(año);
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
        void Diadespués(ref int día,ref int mes,ref int año)
        {
            bool val = Validación(día, mes, año);
            bool bis = Bisiesto(año);
            if(val == true)
            {
                if (mes == 2)
                {
                    if (bis == true)
                    {
                        día++;
                        if(día == 30)
                        {
                            día = 1;
                            mes++;
                        }
                    }
                    else
                    {
                        día++;
                        if (día == 29)
                        {
                            día = 1;
                            mes++;
                        }
                    }
                }
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10|| mes == 12)
                {
                    día++;
                    if(mes == 12 && día == 32)
                    {
                        día = 1;
                        mes = 1;
                        año++;
                    }
                   if(mes != 12 && día == 32)
                    {
                        día = 1;
                        mes++;
                    }
                }
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    día++;
                    if (día == 31)
                    {
                        día = 1;
                        mes++;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int day, month, year;
            day = int.Parse(CDay.Text);
            month = int.Parse(CMonth.Text);
            year = int.Parse(CYear.Text);
            bool val = Validación(day, month, year);
            if (val == true)
            {
                Diadespués(ref day, ref month, ref year);
                MessageBox.Show("La fecha siguiente es " + day.ToString() + "/" + month.ToString() + "/" + year.ToString());
            }
            else
                MessageBox.Show("La fecha no es válida");
        }
    }
}
