using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio410
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Calculo(int num, out int res2, out int res5, out int res7)
        {
            res2 = num;
            res5 = num;
            res7 = num;
            for(int i = 1;i<7;i++)
            {
                if(i<2)
                    res2 = res2 * num;
                if(i<5)
                    res5 = res5 * num;
                if(i<7)
                    res7 = res7 * num;
            }

        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            int n, result2, result5, result7;
            n = int.Parse(CNúm.Text);
            Calculo(n, out result2, out result5, out result7);
            MessageBox.Show("El resultado es:" + "\n" + "Elevado a 2 sería " + result2.ToString() + "\n" + "Elevado a 5 sería " + result5.ToString() + "\n" + "Elevado a 7 sería" + result7.ToString());
        }
    }
}
