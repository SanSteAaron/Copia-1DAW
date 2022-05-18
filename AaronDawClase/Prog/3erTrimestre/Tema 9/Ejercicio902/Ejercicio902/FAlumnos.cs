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
    public partial class FAlumnos : Form
    {
        public FAlumnos()
        {
            InitializeComponent();
        }

        DataSet dsAlumnos;
        SqlDataAdapter da;
        private int pos;
        private int maxRegistros;
        bool BotonPulsado = false;

        private void mostrarRegistro(int pos)
        {
            if (maxRegistros == 0)
            {
                BAnterior.Enabled = false;
                BEliminar.Enabled = false;
                BSiguiente.Enabled = false;
                BPrimero.Enabled = false;
                BÚltimo.Enabled = false;
                TBDni.Text = "Introduce aquí tu dni";
                TBNombre.Text = "Introduce aquí tu nombre";
                TBDirección.Text = "Introduce aquí tu dirección";
                TBApellidos.Text = "Introduce aquí tus apellidos";
                TBTelefono.Text = "Introduce aquí tu teléfono";
                TBEmail.Text = "Introduce aquí tu email";

            }
            else
            {
                DataRow dRegistro;

                dRegistro = dsAlumnos.Tables["Alumnos"].Rows[pos];

                TBDni.Text = dRegistro["DNI"].ToString();
                TBNombre.Text = dRegistro["Nombre"].ToString();
                TBDirección.Text = dRegistro["Direccion"].ToString();
                TBApellidos.Text = dRegistro["Apellido"].ToString();
                TBTelefono.Text = dRegistro["Tlf"].ToString();
                TBEmail.Text = dRegistro["EMail"].ToString();
                if (pos == 0)
                {
                    BAnterior.Enabled = false;
                    BPrimero.Enabled = false;
                }
                else
                {
                    BAnterior.Enabled = true;
                    BPrimero.Enabled = true;
                }
                if (pos == maxRegistros - 1)
                {
                    BÚltimo.Enabled = false;
                    BSiguiente.Enabled = false;
                }
                else
                {
                    BÚltimo.Enabled = true;
                    BSiguiente.Enabled = true;
                }
            }

        }

        private void FGuardarRegistro()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataRow dRegistro = dsAlumnos.Tables["Alumnos"].Rows[pos];

            if (TBDni.Text != dRegistro["DNI"].ToString() || TBNombre.Text != dRegistro["Nombre"].ToString() || TBApellidos.Text != dRegistro["Apellido"].ToString() || TBTelefono.Text != dRegistro["Tlf"].ToString() || TBEmail.Text != dRegistro["EMail"].ToString() || TBDirección.Text != dRegistro["Direccion"].ToString())
            {
                DialogResult comprobar = MessageBox.Show("Se han realizado cambios en el registro, ¿desea guardar los cambios?", "Aviso", MessageBoxButtons.YesNo);

                if (comprobar == DialogResult.Yes)
                {
                    dRegistro["DNI"] = TBDni.Text;
                    dRegistro["Nombre"] = TBNombre.Text;
                    dRegistro["Direccion"] = TBDirección.Text;
                    dRegistro["Apellido"] = TBApellidos.Text;
                    dRegistro["Tlf"] = TBTelefono.Text;
                    dRegistro["EMail"] = TBEmail.Text;

                    dsAlumnos.Tables["Alumnos"].Rows.Add(dRegistro);

                    da.Update(dsAlumnos, "Alumnos");

                    maxRegistros++;
                    pos = maxRegistros - 1;
                    MessageBox.Show("Se han guardado los datos del registro correctamente");
                }
            }
        }

        private void FAlumnos_Load(object sender, EventArgs e)
        {
            string cadena = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\Instituto.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection con = new SqlConnection(cadena);

            con.Open();

            string cadenaSQL = "SELECT * From Alumnos";
            da = new SqlDataAdapter(cadenaSQL, con);
            dsAlumnos = new DataSet();
            da.Fill(dsAlumnos, "Alumnos");

            pos = 0;

            maxRegistros = dsAlumnos.Tables["Alumnos"].Rows.Count;

            mostrarRegistro(pos);
            con.Close();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            FGuardarRegistro();
            pos = 0;
            mostrarRegistro(pos);
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            FGuardarRegistro();
            pos--;
            mostrarRegistro(pos);
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            FGuardarRegistro();
            pos++;
            mostrarRegistro(pos);
        }

        private void BÚltimo_Click(object sender, EventArgs e)
        {
            FGuardarRegistro();
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
            BotonPulsado = true;
            BAñadir.Enabled = false;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataRow dRegistro = dsAlumnos.Tables["Alumnos"].NewRow();

            dRegistro["DNI"] = TBDni.Text;
            dRegistro["Nombre"] = TBNombre.Text;
            dRegistro["Direccion"] = TBDirección.Text;
            dRegistro["Apellido"] = TBApellidos.Text;
            dRegistro["Tlf"] = TBTelefono.Text;
            dRegistro["EMail"] = TBEmail.Text;

            dsAlumnos.Tables["Alumnos"].Rows.Add(dRegistro);

            da.Update(dsAlumnos, "Alumnos");

            maxRegistros++;
            pos = maxRegistros - 1;
            BotonPulsado = false;
            BAñadir.Enabled = true;
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataRow dRegistro = dsAlumnos.Tables["Alumnos"].Rows[pos];

            dRegistro["DNI"] = TBDni.Text;
            dRegistro["Nombre"] = TBNombre.Text;
            dRegistro["Direccion"] = TBDirección.Text;
            dRegistro["Apellido"] = TBApellidos.Text;
            dRegistro["Tlf"] = TBTelefono.Text;
            dRegistro["EMail"] = TBEmail.Text;

            da.Update(dsAlumnos, "Alumnos");
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DialogResult comprobar = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo);
            if (comprobar == DialogResult.Yes)
            {
                dsAlumnos.Tables["Alumnos"].Rows[pos].Delete();

                maxRegistros--;

                pos = 0;
                mostrarRegistro(pos);

                da.Update(dsAlumnos, "Alumnos");
                MessageBox.Show("Se ha eliminado correctamente el registro.");
            }
            else
            {
                MessageBox.Show("No se ha eliminado el registro.");
            }
        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {
            if (TBDni.Text == "" || TBNombre.Text == "" || TBApellidos.Text == "" || TBTelefono.Text == "" || TBEmail.Text == "" || !BotonPulsado)
            {
                BGuardar.Enabled = false;
            }
            else
                BGuardar.Enabled = true;
        }
    }
}
