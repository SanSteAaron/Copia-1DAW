using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio307
{
    public partial class Ejercicio307 : Form
    {
        public Ejercicio307()
        {
            InitializeComponent();
        }

        private void BIntroducir_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(TNumero.Text);
            switch (num)
            {
                case 1:
                    MessageBox.Show("El número introducido es el 1");
                    break;
                case 2:
                    MessageBox.Show("El número introducido es el 2");
                    break;
                case 3:
                    MessageBox.Show("El número introducido es el 3");
                    break;
                case 4:
                    MessageBox.Show("El número introducido es el 4");
                    break;
                case 5:
                    MessageBox.Show("El número introducido es el 5");
                    break;
                default:
                    MessageBox.Show("El número introducido no se encuentra en el intervalo");
                    break;
            
            }   
        }
    }
}
