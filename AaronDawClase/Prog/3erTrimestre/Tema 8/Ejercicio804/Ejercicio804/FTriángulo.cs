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
    public partial class FTriángulo : Form
    {
        public FTriángulo()
        {
            InitializeComponent();
        }

        public List<TFigura> listafiguras;

        private void BAñadirTriángulo_Click_1(object sender, EventArgs e)
        {
            int x, y, lado;
            string color;
            x = int.Parse(TBPosiciónX.Text);
            y = int.Parse(TBPosiciónY.Text);
            lado = int.Parse(TBLado.Text);
            color = (TBColor.Text);
            TTriángulo triángulo = new TTriángulo(x, y, color, lado);
            listafiguras.Add(triángulo);
        }
    }
}
