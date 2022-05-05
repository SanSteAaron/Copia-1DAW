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
    public partial class FHexágono : Form
    {
        public FHexágono()
        {
            InitializeComponent();
        }

        public List<TFigura> listafiguras;

        private void BAñadirHexágono_Click(object sender, EventArgs e)
        {
            int x, y, lado;
            string color;
            x = int.Parse(TBPosiciónX.Text);
            y = int.Parse(TBPosiciónY.Text);
            lado = int.Parse(TBLado.Text);
            color = (TBColor.Text);
            THexágono hexágono = new THexágono(x, y, color, lado);
            listafiguras.Add(hexágono);
        }
    }
}
