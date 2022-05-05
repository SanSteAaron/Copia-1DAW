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

namespace Ejercicio803
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TFigura> listafiguras = new List<TFigura>();

        string MostrarDatosCirculos(List<TFigura> listaFiguras)
        {
            string texto = "Datos de los círculos:\n\n";
            foreach (TFigura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(TCirculo))
                {
                    texto += figura.QuienSoy() + "\n\n";
                }
            }
            return texto;
        }

        string MostrarDatosCuadrados(List<TFigura> listaFiguras)
        {
            string texto = "Datos de los cuadrados:\n\n";
            foreach (TFigura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(TCuadrado))
                {
                    texto += figura.QuienSoy() + "\n\n";
                }
            }
            return texto;
        }

        private void BIntroducirCírculo_Click(object sender, EventArgs e)
        {
            FCirculo fCirculo = new FCirculo();

            fCirculo.listafiguras = listafiguras;
            fCirculo.ShowDialog();
        }

        private void BIntroducirCuadrado_Click(object sender, EventArgs e)
        {
            FCuadrado fCuadrado = new FCuadrado();

            fCuadrado.listafiguras = listafiguras;
            fCuadrado.ShowDialog();
        }

        private void BMostrarListaFig_Click(object sender, EventArgs e)
        {
            string texto = "Esta es la lista de figuras: \n\n";
            foreach (TFigura figura in listafiguras)
            {
                texto += figura.QuienSoy() + "\n\n";
            }
            MessageBox.Show(texto);
        }

        private void BMostrarListaCir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosCirculos(listafiguras));
        }

        private void BMostrarListaCua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosCuadrados(listafiguras));
        }
    }
}
