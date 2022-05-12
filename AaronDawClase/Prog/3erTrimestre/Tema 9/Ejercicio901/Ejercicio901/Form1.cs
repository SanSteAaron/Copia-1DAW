using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ejercicio901
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet dsProfesores;
        SqlDataAdapter da;
        private int pos;
        private int maxRegistros;
        private void mostrarRegistro(int pos)
        {
            DataRow dRegistro;
            
            dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];
           
            TBDni.Text = dRegistro["DNI"].ToString();
            TBNombre.Text = dRegistro["Nombre"].ToString();
            TBApellidos.Text = dRegistro["Apellido"].ToString();
            TBTelefono.Text = dRegistro["Tlf"].ToString();
            TBEmail.Text = dRegistro["EMail"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cadenaConexión = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sanchez22014\\Desktop\\AaronDawClase\\Prog\\3erTrimestre\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cadenaConexión);

            con.Open();

            string cadenaSQL = "SELECT * From Profesores";
            da = new SqlDataAdapter(cadenaSQL, con);
            dsProfesores = new DataSet();
            da.Fill(dsProfesores, "Profesores");

            pos = 0;
            mostrarRegistro(pos);

            maxRegistros = dsProfesores.Tables["Profesores"].Rows.Count;


            con.Close();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            mostrarRegistro(pos);
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            mostrarRegistro(pos);
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            pos++;
            mostrarRegistro(pos);
        }

        private void BÚltimo_Click(object sender, EventArgs e)
        {
            pos = maxRegistros - 1;
            mostrarRegistro(pos);
        }
    }
}
