using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio703
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TFecha> listaFechas = new List<TFecha>();

        bool FechaMasActual(TFecha fecha1, TFecha fecha2)
        {
            bool mas = false;

            if (fecha1.Year > fecha2.Year)
                mas = true;
            else
                if (fecha1.Year == fecha2.Year && fecha1.Month > fecha2.Month)
                mas = true;
            else
                    if (fecha1.Year == fecha2.Year && fecha1.Month == fecha2.Month && fecha1.Day > fecha2.Day)
                mas = true;

            return mas;
        }
        private void BIntroducirFechas_Click(object sender, EventArgs e)
        {
            TFecha fecha = new TFecha();
            int day, month, year;
            bool correcta;

            day = int.Parse(Interaction.InputBox("Introduzca el día: "));
            month = int.Parse(Interaction.InputBox("Introduzca el mes: "));
            year = int.Parse(Interaction.InputBox("Introduzca el año: "));

            correcta = fecha.darValores(day, month, year);

            if (correcta)
                listaFechas.Add(fecha);
            else
                MessageBox.Show("La fecha es incorrecta.");
        }

        private void BMostrarFechas_Click(object sender, EventArgs e)
        {
            int i;
            string texto = "Las fechas son: \n";

            foreach (TFecha fecha in listaFechas)
            {
                texto = texto + fecha.mostrarFecha() + "\n\n";
            }

            MessageBox.Show(texto);
        }

        private void BOrdenarFechas_Click(object sender, EventArgs e)
        {
            int i, j;
            TFecha aux;

            for (i = 0; i < listaFechas.Count - 1; i++)
                for (j = i + 1; j < listaFechas.Count; j++)
                {
                    if (FechaMasActual(listaFechas[i], listaFechas[j]))
                    {
                        aux = listaFechas[i];
                        listaFechas[i] = listaFechas[j];
                        listaFechas[j] = aux;
                    }
                }
        }
    }
}
