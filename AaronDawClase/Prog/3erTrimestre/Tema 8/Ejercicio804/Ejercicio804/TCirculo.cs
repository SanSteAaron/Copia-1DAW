using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio804
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

        private double CalcularPerímetroCirculo(int radio)
        {
            double resultado = 2 * 3.14 * radio;
            return resultado;
        }

        public override string QuienSoy()
        {
            string texto = base.QuienSoy();
            texto += "Exactamente un circulo\n";
            texto += "De color " + Color + "\n";
            texto += "Y con un radio de " + Radio.ToString() + "\n";
            texto += "Con un perímetro de " + CalcularPerímetroCirculo(Radio);
            return texto;
        }
    }
}
