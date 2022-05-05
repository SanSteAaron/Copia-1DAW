using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio404
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void vabsoluto(int num, out int res)
        {
            res = num;
            if (num < 0)
            {
                res = -num;
            }
        }
        private void BPrimero_Click(object sender, EventArgs e)
        {
            int n, resabsoluto;
            n = int.Parse(CNum.Text);
            vabsoluto(n, out resabsoluto);
            MessageBox.Show("El valor absoluto de " + n.ToString() + " es " + resabsoluto.ToString());
        }
    }
}
