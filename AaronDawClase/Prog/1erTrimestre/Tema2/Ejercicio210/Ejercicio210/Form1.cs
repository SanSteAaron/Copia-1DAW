using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPaE_Click(object sender, EventArgs e)
        {
            double euros, pesetas;
            pesetas = double.Parse(TPesetas.Text);
            euros = pesetas * 0.0060;
            TEuros.Text = euros.ToString();
        }

        private void BEaP_Click(object sender, EventArgs e)
        {
            double euros, pesetas;
            euros = double.Parse(TEuros.Text);
            pesetas = euros * 166.386;
            TPesetas.Text = pesetas.ToString();
        }
    }
}
