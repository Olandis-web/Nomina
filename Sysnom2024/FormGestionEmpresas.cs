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
        private readonly SqlConnection conexion = new SqlConnection("Integrated security=SSPI;data source=MSI\\SQLEXPRESS;persist security info=False;initial catalog=SysNom2024");

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
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_InsertaGestiondeempresa", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDEmpresa", Convert.ToInt32(txtIDEmpresa.Text));
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@RNC", txtRNC.Text);
                    cmd.Parameters.AddWithValue("@Propietario", txtPropietario.Text);
                    cmd.Parameters.AddWithValue("@SitioWeb", txtSitioWeb.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Registro Guardado Satisfactoriamente");
                    btnGuardar.Enabled = false;
                    Limpiar();
                    CargarDataGridViewEmpresas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_ActualizaGestiondeempresa", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDEmpresa", Convert.ToInt32(txtIDEmpresa.Text));
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@RNC", txtRNC.Text);
                    cmd.Parameters.AddWithValue("@Propietario", txtPropietario.Text);
                    cmd.Parameters.AddWithValue("@SitioWeb", txtSitioWeb.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Registro Actualizado Satisfactoriamente");
                    Limpiar();
                    CargarDataGridViewEmpresas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_EliminaGestiondeempresa", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDEmpresa", Convert.ToInt32(txtIDEmpresa.Text));

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Registro Eliminado Satisfactoriamente");
                    Limpiar();
                    CargarDataGridViewEmpresas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtIDEmpresa.Text = "";
            txtNombre.Text = "";
            txtRNC.Text = "";
            txtPropietario.Text = "";
            txtSitioWeb.Text = "";
            txtDireccion.Text = "";
        }
    }
}

