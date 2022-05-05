using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio802
{
    public class TCuadrado : TFigura
    {
        private int mLado;
        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }
        public TCuadrado(int x, int y, string color, int lado) : base(x, y, color)
        {
            mLado = lado;
        }

        public override string QuienSoy()
        {
            string texto = base.QuienSoy();
            texto += "Exactamente un cuadrado\n";
            texto += "De color " + Color + "\n";
            texto += "Y con un lado de " + Lado.ToString();
            return texto;
        }
    }
}
