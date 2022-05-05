using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio317
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BMúltiplos_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 3; i <= 100; i = i + 3)
                MessageBox.Show(i.ToString());
        }
    }
}
