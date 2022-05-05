using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio802
{
    public class TFigura
    {
        private int mPosicionX, mPosicionY;
        string mColor;

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public TFigura (int x, int y, string color)
        {
            mPosicionX = x;
            mPosicionY = y;
            mColor = color;
        }

        public virtual string QuienSoy()
        {
            return "Soy una figura\n";
        }
    }
}
