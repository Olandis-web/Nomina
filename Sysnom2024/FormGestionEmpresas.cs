using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sysnom2024
{
    public partial class FormGestionEmpresas : Form
    {
        SqlConnection conexion = new SqlConnection("Integrated security=SSPI;data source=DESKTOP-JKG9C4V\\SQLEXPRESS;persist security info=False;initial catalog=SysNom2024");

        public FormGestionEmpresas()
        {
            InitializeComponent();
        }

        private void FormGestionEmpresas_Load(object sender, EventArgs e)
        {
            CargarDataGridViewEmpresas();
        }

        private void CargarDataGridViewEmpresas()
        {
            DataTable dataTable = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter adapter = new SqlDataAdapter("SP_DGVEmpresa", conexion);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dataTable);
            dataGridViewEmpresas.DataSource = dataTable;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_InsertaGestiondeempresa";
            cm.CommandType = CommandType.StoredProcedure;


            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.VarChar));
            cm.Parameters["@RNC"].Value = txtRNC.Text;

            cm.Parameters.Add(new SqlParameter("@prt", SqlDbType.VarChar));
            cm.Parameters["@prt"].Value = txtPropietario.Text;

            cm.Parameters.Add(new SqlParameter("@sw", SqlDbType.VarChar));
            cm.Parameters["@sw"].Value = txtSitioWeb.Text;

            cm.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar));
            cm.Parameters["@tel"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@dir", SqlDbType.VarChar));
            cm.Parameters["@dir"].Value = txtDireccion.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");
            conexion.Close();
            btnGuardar.Enabled = false;
            Limpiar();
            CargarDataGridViewEmpresas();



        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_ActualizaGestiondeempresa";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cm.Parameters["@Codigo"].Value = txtIDEmpresa.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.VarChar));
            cm.Parameters["@RNC"].Value = txtRNC.Text;

            cm.Parameters.Add(new SqlParameter("@prt", SqlDbType.VarChar));
            cm.Parameters["@prt"].Value = txtPropietario.Text;

            cm.Parameters.Add(new SqlParameter("@sw", SqlDbType.VarChar));
            cm.Parameters["@sw"].Value = txtSitioWeb.Text;

            cm.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar));
            cm.Parameters["@tel"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@dir", SqlDbType.VarChar));
            cm.Parameters["@dir"].Value = txtDireccion.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            conexion.Close();
            btnActualizar.Enabled = false;
            Limpiar();
            CargarDataGridViewEmpresas();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_EliminaGestiondeempresa";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int));
            cm.Parameters["@Codigo"].Value = txtIDEmpresa.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado Satisfactoriamente");
            conexion.Close();
            btnEliminar.Enabled = false;
            Limpiar();
            CargarDataGridViewEmpresas();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtIDEmpresa.Clear();
            txtNombre.Clear();
            txtRNC.Clear();
            txtPropietario.Clear();
            txtSitioWeb.Clear();
            textBox1.Clear();
            txtDireccion.Clear();
        }

        private void txtSitioWeb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEmpresa.Text = dataGridViewEmpresas.CurrentRow.Cells["IDEmpresa"].Value.ToString();
            txtNombre.Text = dataGridViewEmpresas.CurrentRow.Cells["Nombre"].Value.ToString();
            txtRNC.Text = dataGridViewEmpresas.CurrentRow.Cells["RNC"].Value.ToString();
            txtPropietario.Text = dataGridViewEmpresas.CurrentRow.Cells["Propietario"].Value.ToString();
            txtSitioWeb.Text = dataGridViewEmpresas.CurrentRow.Cells["SitioWeb"].Value.ToString();
            textBox1.Text = dataGridViewEmpresas.CurrentRow.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = dataGridViewEmpresas.CurrentRow.Cells["Direccion"].Value.ToString();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_InsertaGestiondeempresa";
            cm.CommandType = CommandType.StoredProcedure;


            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.VarChar));
            cm.Parameters["@RNC"].Value = txtRNC.Text;

            cm.Parameters.Add(new SqlParameter("@prt", SqlDbType.VarChar));
            cm.Parameters["@prt"].Value = txtPropietario.Text;

            cm.Parameters.Add(new SqlParameter("@sw", SqlDbType.VarChar));
            cm.Parameters["@sw"].Value = txtSitioWeb.Text;

            cm.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar));
            cm.Parameters["@tel"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@dir", SqlDbType.VarChar));
            cm.Parameters["@dir"].Value = txtDireccion.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");
            conexion.Close();
            btnGuardar.Enabled = false;
            Limpiar();
            CargarDataGridViewEmpresas();



        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_ActualizaGestiondeempresa";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar));
            cm.Parameters["@Codigo"].Value = txtIDEmpresa.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@RNC", SqlDbType.VarChar));
            cm.Parameters["@RNC"].Value = txtRNC.Text;

            cm.Parameters.Add(new SqlParameter("@prt", SqlDbType.VarChar));
            cm.Parameters["@prt"].Value = txtPropietario.Text;

            cm.Parameters.Add(new SqlParameter("@sw", SqlDbType.VarChar));
            cm.Parameters["@sw"].Value = txtSitioWeb.Text;

            cm.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar));
            cm.Parameters["@tel"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@dir", SqlDbType.VarChar));
            cm.Parameters["@dir"].Value = txtDireccion.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            conexion.Close();
            btnActualizar.Enabled = false;
            Limpiar();
            CargarDataGridViewEmpresas();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_EliminaGestiondeempresa";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int));
            cm.Parameters["@Codigo"].Value = txtIDEmpresa.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado Satisfactoriamente");
            conexion.Close();
            btnEliminar.Enabled = false;
            Limpiar();
            CargarDataGridViewEmpresas();

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
        }
    }
}

