using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio407
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mcdivisor(int num1, int num2)
        {
            int res = 1;
            for(int i = num2; i > 1; i--)
            {
                int comprobar1 = num2 % i;
                if(comprobar1 == 0)
                {
                    int comprobar2 = num1 % i;
                    if(comprobar2 == 0)
                    {
                        res = i;
                        i = 1;
                    }
                }
            }
            return res;
        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            int n1, n2, mcd;
            n1 = int.Parse(CNum1.Text);
            n2 = int.Parse(CNum2.Text);
            mcd = mcdivisor(n1, n2);
            MessageBox.Show("El máximo común divisor es " + mcd.ToString());
        }
    }
}
