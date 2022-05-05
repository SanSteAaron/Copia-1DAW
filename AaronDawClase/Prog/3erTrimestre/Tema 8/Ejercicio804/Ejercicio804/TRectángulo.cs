using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio804
{
    public class TRectángulo : TFigura
    {
        private int mLado1;
        private int mLado2;
        public int Lado1
        {
            get { return mLado1; }
            set { mLado1 = value; }
        }

        public int Lado2
        {
            get { return mLado2; }
            set { mLado2 = value; }
        }

        public TRectángulo(int x, int y, string color, int lado1, int lado2) : base(x, y, color)
        {
            mLado1 = lado1;
            mLado2 = lado2;
        }

        private double CalcularPerímetroRectángulo(int lado1, int lado2)
        {
            double resultado = 2*lado1 + 2*lado2;
            return resultado;
        }

        public override string QuienSoy()
        {
            string texto = base.QuienSoy();
            texto += "Exactamente un rectángulo \n";
            texto += "De color " + Color + "\n";
            texto += "Y con un lado de " + Lado1.ToString() + " y otro de " + Lado2.ToString() + "\n";
            texto += "Con un perímetro de " + CalcularPerímetroRectángulo(Lado1,Lado2);
            return texto;
        }
    }
}
