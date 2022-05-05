using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio803
{
    public partial class FCuadrado : Form
    {
        public FCuadrado()
        {
            InitializeComponent();
        }

        public List<TFigura> listafiguras;

        private void BAñadirCuadrado_Click(object sender, EventArgs e)
        {
            int x, y, lado;
            string color;
            x = int.Parse(TBPosiciónX.Text);
            y = int.Parse(TBPosiciónY.Text);
            lado = int.Parse(TBLado.Text);
            color = (TBColor.Text);
            TCuadrado cuadrado = new TCuadrado(x, y, color, lado);
            listafiguras.Add(cuadrado);
        }
    }
}
