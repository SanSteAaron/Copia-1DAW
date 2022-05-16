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


namespace Ejercicio902
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
            string cadena = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\Instituto.mdf; Integrated Security = True; Connect Timeout = 30";
            
            SqlConnection con = new SqlConnection(cadena);

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
            if(pos == 0)
            {
                MessageBox.Show("Ya se encuentra en la primera posición.");
            }
            else
            {
                pos--;
                mostrarRegistro(pos);
            }         
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if(pos == maxRegistros -1)
            {

            }
            else
            {
                pos++;
                mostrarRegistro(pos);
            }
        }

        private void BÚltimo_Click(object sender, EventArgs e)
        {
            pos = maxRegistros - 1;
            mostrarRegistro(pos);
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            TBDni.Clear();
            TBNombre.Clear();
            TBApellidos.Clear();
            TBTelefono.Clear();
            TBEmail.Clear();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            
            DataRow dRegistro = dsProfesores.Tables["Profesores"].NewRow();

             dRegistro["DNI"] = TBDni.Text;
             dRegistro["Nombre"] = TBNombre.Text;
             dRegistro["Apellido"] = TBApellidos.Text;
             dRegistro["Tlf"] = TBTelefono.Text;
             dRegistro["EMail"] = TBEmail.Text;
            
            dsProfesores.Tables["Profesores"].Rows.Add(dRegistro);
            
            da.Update(dsProfesores, "Profesores");
            
            maxRegistros++;
            pos = maxRegistros - 1;
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            
            DataRow dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];
            
            dRegistro["DNI"] = TBDni.Text;
            dRegistro["Nombre"] = TBNombre.Text;
            dRegistro["Apellido"] = TBApellidos.Text;
            dRegistro["Tlf"] = TBTelefono.Text;
            dRegistro["EMail"] = TBEmail.Text;

            da.Update(dsProfesores, "Profesores");
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            
            dsProfesores.Tables["Profesores"].Rows[pos].Delete();
            
            maxRegistros--;
            
            pos = 0;
            mostrarRegistro(pos);
            
            da.Update(dsProfesores, "Profesores");
        }
    }
}
