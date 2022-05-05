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

namespace Ejercicio801
{
    public partial class FCreadorFiguras : Form
    {
        public FCreadorFiguras()
        {
            InitializeComponent();
        }

        private void BIntroducirCirculo_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Interaction.InputBox("Introduce la coordenada x:"));
            int y = int.Parse(Interaction.InputBox("Introduce la coordenada y:"));
            string color = (Interaction.InputBox("Introduce el color de la figura:"));
            int radio = int.Parse(Interaction.InputBox("Introduce el radio del circulo:"));
            TCirculo circulo = new TCirculo(x,y,color,radio);
            MessageBox.Show(circulo.QuienSoy());
        }

        private void BIntroducirCuadrado_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Interaction.InputBox("Introduce la coordenada x:"));
            int y = int.Parse(Interaction.InputBox("Introduce la coordenada y:"));
            string color = (Interaction.InputBox("Introduce el color de la figura:"));
            int lado = int.Parse(Interaction.InputBox("Introduce el lado del circulo:"));
            TCuadrado cuadrado = new TCuadrado(x,y,color,lado);
            MessageBox.Show(cuadrado.QuienSoy());
        }
    }
}
