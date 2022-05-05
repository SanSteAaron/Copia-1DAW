using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void mayor(int num1,int num2, out string res)
        {
            res = num1.ToString();
            if(num1 < num2)
            {
                res = num2.ToString();
            }
            if(num1 > num2)
            {
                res = num1.ToString();
            }
        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            int n1, n2;
            string nmayor;
            n1 = int.Parse(CNum1.Text);
            n2 = int.Parse(CNum2.Text);
            mayor(n1, n2, out nmayor);
            MessageBox.Show("El mayor es el número " + nmayor);
        }
    }
}
