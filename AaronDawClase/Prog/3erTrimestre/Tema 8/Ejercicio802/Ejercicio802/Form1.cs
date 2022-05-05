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

namespace Ejercicio802
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TFigura> listafiguras = new List<TFigura>();

        void ObtenerPosiciónYColor(out int x,out int y,out string color)
        {
            x = int.Parse(Interaction.InputBox("Introduce la coordenada x:"));
            y = int.Parse(Interaction.InputBox("Introduce la coordenada y:"));
            color = (Interaction.InputBox("Introduce el color de la figura:"));
        }

        string MostrarDatosCirculos(List<TFigura> listaFiguras)
        {
            string texto = "Datos de los círculos:\n\n";
            foreach (TFigura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(TCirculo))
                {
                    texto += figura.QuienSoy() + "\n";
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
                    texto += figura.QuienSoy() + "\n";
                }
            }
            return texto;
        }

        private void BIntroducirCírculo_Click(object sender, EventArgs e)
        {
            int x, y, radio;
            string color;
            ObtenerPosiciónYColor(out x, out y, out color);
            radio = int.Parse(Interaction.InputBox("Introduce el radio del circulo:"));
            TCirculo circulo = new TCirculo(x, y, color, radio);
            listafiguras.Add(circulo);
        }

        private void BIntroducirCuadrado_Click(object sender, EventArgs e)
        {
            int x, y, lado;
            string color;
            ObtenerPosiciónYColor(out x, out y, out color);
            lado = int.Parse(Interaction.InputBox("Introduce el lado del cuadrado:"));
            TCuadrado cuadrado = new TCuadrado(x, y, color, lado);
            listafiguras.Add(cuadrado);
        }

        private void BMostrarListaFig_Click(object sender, EventArgs e)
        {
            string texto = "Esta es la lista de figuras: \n\n";
            foreach (TFigura figura in listafiguras)
            {
                texto += figura.QuienSoy() + "\n";
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
