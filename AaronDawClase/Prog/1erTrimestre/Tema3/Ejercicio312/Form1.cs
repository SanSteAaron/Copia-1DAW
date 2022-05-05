using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio312
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
            for (i = 1; i <= num; i++)
                MessageBox.Show(i.ToString());
        }

        private void BWhile_Click(object sender, EventArgs e)
        {
            int i, num;
            num = int.Parse(textBox1.Text);
            i = 1;
            while (i <= num)
            {
                MessageBox.Show(i.ToString());
                i++;
            }
        }

        private void BDo_Click(object sender, EventArgs e)
        {
            int i, num;
            num = int.Parse(textBox1.Text);
            i = 1;
            do
            {
                MessageBox.Show(i.ToString());
                i++;
            } while (i <= num);
        }
    }
}
