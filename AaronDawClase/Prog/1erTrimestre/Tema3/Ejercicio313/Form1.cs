using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio313
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFor_Click(object sender, EventArgs e)
        {
            int num, i;
            num = int.Parse(textBox1.Text);
            for (i = 2; i <= num; i = i + 2)
                MessageBox.Show(i.ToString());
        }

        private void BWhile_Click(object sender, EventArgs e)
        {
            int num, i;
            num = int.Parse(textBox1.Text);
            i = 2;
            while ( i <= num)
            {
                MessageBox.Show(i.ToString());
                i = i + 2;
            }
        }

        private void BDo_Click(object sender, EventArgs e)
        {
            int num, i;
            num = int.Parse(textBox1.Text);
            i = 2;
            do
            {
                MessageBox.Show(i.ToString());
                i = i + 2;
            } while (i <= num);
        }
    }
}
