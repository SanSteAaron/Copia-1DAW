using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio804
{
    public class TTriángulo : TFigura
    {
        private int mLado;
        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }
        public TTriángulo(int x, int y, string color, int lado) : base(x, y, color)
        {
            mLado = lado;
        }

        private double CalcularPerímetroTriángulo(int lado)
        {
            double resultado = 3 * lado;
            return resultado;
        }

        public override string QuienSoy()
        {
            string texto = base.QuienSoy();
            texto += "Exactamente un triángulo equilátero\n";
            texto += "De color " + Color + "\n";
            texto += "Y con un lado de " + Lado.ToString() + "\n";
            texto += "Con un perímetro de " + CalcularPerímetroTriángulo(Lado);
            return texto;
        }
    }
}
