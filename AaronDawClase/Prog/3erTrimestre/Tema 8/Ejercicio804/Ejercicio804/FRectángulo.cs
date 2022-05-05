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
    public partial class FRectángulo : Form
    {
        public FRectángulo()
        {
            InitializeComponent();
        }

        public List<TFigura> listafiguras;

        private void BAñadirRectángulo_Click(object sender, EventArgs e)
        {
            int x, y, bas, altura;
            string color;
            x = int.Parse(TBPosiciónX.Text);
            y = int.Parse(TBPosiciónY.Text);
            bas = int.Parse(TBBase.Text);
            altura = int.Parse(TBAltura.Text);
            color = (TBColor.Text);
            TRectángulo rectángulo = new TRectángulo(x, y, color, bas, altura);
            listafiguras.Add(rectángulo);
        }
    }
}
