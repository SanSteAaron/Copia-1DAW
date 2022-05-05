using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio804
{
    public class THexágono : TFigura
    {
        private int mLado;
        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }
        public THexágono(int x, int y, string color, int lado) : base(x, y, color)
        {
            mLado = lado;
        }

        private double CalcularPerímetroHexágono(int lado)
        {
            double resultado = 6 * lado;
            return resultado;
        }

        public override string QuienSoy()
        {
            string texto = base.QuienSoy();
            texto += "Exactamente un hexágono regular\n";
            texto += "De color " + Color + "\n";
            texto += "Y con un lado de " + Lado.ToString() + "\n";
            texto += "Con un perímetro de " + CalcularPerímetroHexágono(Lado);
            return texto;
        }
    }
}
