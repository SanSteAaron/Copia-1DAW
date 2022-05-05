using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio802
{
    public class TCirculo : TFigura
    {
        private int mRadio;
        public int Radio
        {
            get { return mRadio; }
            set { mRadio = value; }
        }
        public TCirculo(int x, int y, string color, int radio) : base(x, y, color)
        {
            mRadio = radio;
        }

        public override string QuienSoy()
        {
            string texto = base.QuienSoy();
            texto += "Exactamente un circulo\n";
            texto += "De color " + Color + "\n";
            texto += "Y con un radio de " + Radio.ToString();
            return texto;
        }
    }
}
