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
    public partial class FCursos : Form
    {
        public FCursos()
        {
            InitializeComponent();
        }
        DataSet dsCurso;
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
                TBCódigo.Text = "Introduce aquí el código";
                TBNombre.Text = "Introduce aquí el nombre";

            }
            else
            {
                DataRow dRegistro;

                dRegistro = dsCurso.Tables["Cursos"].Rows[pos];

                TBCódigo.Text = dRegistro["Codigo"].ToString();
                TBNombre.Text = dRegistro["Nombre"].ToString();
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

            DataRow dRegistro = dsCurso.Tables["Cursos"].Rows[pos];

            if (TBCódigo.Text != dRegistro["Codigo"].ToString() || TBNombre.Text != dRegistro["Nombre"].ToString())
            {
                DialogResult comprobar = MessageBox.Show("Se han realizado cambios en el registro, ¿desea guardar los cambios?", "Aviso", MessageBoxButtons.YesNo);

                if (comprobar == DialogResult.Yes)
                {
                    dRegistro["Codigo"] = TBCódigo.Text;
                    dRegistro["Nombre"] = TBNombre.Text;

                    dsCurso.Tables["Cursos"].Rows.Add(dRegistro);

                    da.Update(dsCurso, "Cursos");

                    maxRegistros++;
                    pos = maxRegistros - 1;
                    MessageBox.Show("Se han guardado los datos del registro correctamente");
                }
            }
        }

        private void FCursos_Load(object sender, EventArgs e)
        {
            string cadena = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\Instituto.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection con = new SqlConnection(cadena);

            con.Open();

            string cadenaSQL = "SELECT * From Cursos";
            da = new SqlDataAdapter(cadenaSQL, con);
            dsCurso = new DataSet();
            da.Fill(dsCurso, "Cursos");

            pos = 0;

            maxRegistros = dsCurso.Tables["Cursos"].Rows.Count;

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
            TBCódigo.Clear();
            TBNombre.Clear();
            BotonPulsado = true;
            BAñadir.Enabled = false;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataRow dRegistro = dsCurso.Tables["Cursos"].NewRow();

            dRegistro["Codigo"] = TBCódigo.Text;
            dRegistro["Nombre"] = TBNombre.Text;

            dsCurso.Tables["Cursos"].Rows.Add(dRegistro);

            da.Update(dsCurso, "Cursos");

            maxRegistros++;
            pos = maxRegistros - 1;
            BotonPulsado = false;
            BAñadir.Enabled = true;
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataRow dRegistro = dsCurso.Tables["Cursos"].Rows[pos];

            dRegistro["Codigo"] = TBCódigo.Text;
            dRegistro["Nombre"] = TBNombre.Text;

            da.Update(dsCurso, "Cursos");
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DialogResult comprobar = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo);
            if (comprobar == DialogResult.Yes)
            {
                dsCurso.Tables["Cursos"].Rows[pos].Delete();

                maxRegistros--;

                pos = 0;
                mostrarRegistro(pos);

                da.Update(dsCurso, "Cursos");
                MessageBox.Show("Se ha eliminado correctamente el registro.");
            }
            else
            {
                MessageBox.Show("No se ha eliminado el registro.");
            }
        }

        private void TBCódigo_TextChanged(object sender, EventArgs e)
        {
            if (TBCódigo.Text == "" || TBNombre.Text == "" || !BotonPulsado)
            {
                BGuardar.Enabled = false;
            }
            else
                BGuardar.Enabled = true;
        }
    }
}
