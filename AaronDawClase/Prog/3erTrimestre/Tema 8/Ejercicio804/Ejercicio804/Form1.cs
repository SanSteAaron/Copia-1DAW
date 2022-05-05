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

namespace Ejercicio804
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

        string MostrarDatosTriángulos(List<TFigura> listaFiguras)
        {
            string texto = "Datos de los triángulos:\n\n";
            foreach (TFigura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(TTriángulo))
                {
                    texto += figura.QuienSoy() + "\n\n";
                }
            }
            return texto;
        }

        string MostrarDatosRectángulos(List<TFigura> listaFiguras)
        {
            string texto = "Datos de los rectángulos:\n\n";
            foreach (TFigura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(TRectángulo))
                {
                    texto += figura.QuienSoy() + "\n\n";
                }
            }
            return texto;
        }

        string MostrarDatosHexágonos(List<TFigura> listaFiguras)
        {
            string texto = "Datos de los hexágonos:\n\n";
            foreach (TFigura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(THexágono))
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

        private void BMostrarTriangulos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosTriángulos(listafiguras));
        }

        private void BMostrarRectangulos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosRectángulos(listafiguras));
        }

        private void BMostrarHexagonos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarDatosHexágonos(listafiguras));
        }

        private void BIntroducirTriangulo_Click(object sender, EventArgs e)
        {
            FTriángulo fTriángulo = new FTriángulo();

            fTriángulo.listafiguras = listafiguras;
            fTriángulo.ShowDialog();
        }

        private void BIntroducirRectangulo_Click(object sender, EventArgs e)
        {
            FRectángulo fRectángulo = new FRectángulo();

            fRectángulo.listafiguras = listafiguras;
            fRectángulo.ShowDialog();
        }

        private void BIntroducirHexa_Click(object sender, EventArgs e)
        {
            FHexágono fHexágono = new FHexágono();

            fHexágono.listafiguras = listafiguras;
            fHexágono.ShowDialog();
        }
    }
}
