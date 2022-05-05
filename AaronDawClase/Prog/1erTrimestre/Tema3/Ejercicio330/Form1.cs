using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio330
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            string password, user;
            int i;
            for(i = 1; i<=5; i++)
            {
                user = Interaction.InputBox("Introduzca el nombre de usuario");
                password = Interaction.InputBox("Introduzca la contraseña");
                if(password == "1234" && user == "root")
                {
                    MessageBox.Show("Bienvenido al sistema");
                    i = 7;
                }
                if(password == "1234" && user != "root")
                {
                    MessageBox.Show("El nombre de usuario es incorrecto");
                }
                if (password != "1234" && user == "root")
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
                if (password != "1234" && user != "root")
                {
                    MessageBox.Show("La contraseña y el nombre de usuario son incorrectos");
                }
            }
            if (i == 6)
            {
                MessageBox.Show("Se ha agotado el número de intentos");
            }
        }
    }
}
