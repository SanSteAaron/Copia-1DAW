using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio805
{
    abstract class TPersona
    {
        string mName;
        string mDNI;
        int mPhone;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string DNI
        {
            get { return mDNI; }
            set { mDNI = value; }
        }

        public int Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public TPersona(string name,string dni,int phone)
        {
            mName = name;
            mDNI = dni;
            mPhone = phone;
        }

        public TPersona()
        {
            mName = "";
            mDNI = "";
            mPhone = 0;
        }
    }
}
