using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio804
{
    public partial class FCirculo : Form
    {
        public FCirculo()
        {
            InitializeComponent();
        }

        public List<TFigura> listafiguras;

        private void BAñadirCirculo_Click(object sender, EventArgs e)
        {
            int x, y, radio;
            string color;
            x = int.Parse(TBPosicionX.Text);
            y = int.Parse(TBPosicionY.Text);
            radio = int.Parse(TBRadio.Text);
            color = (TBColor.Text);
            TCirculo circulo = new TCirculo(x, y, color, radio);
            listafiguras.Add(circulo);
        }
    }
}
