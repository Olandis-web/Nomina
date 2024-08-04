using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sysnom2024
{
    public partial class FormGestionUsuarios : Form
    {
        SqlConnection conexion = new SqlConnection("Integrated security=SSPI;data source=DESKTOP-JKG9C4V\\SQLEXPRESS;persist security info=False;initial catalog=SysNom2024");

        public FormGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarComboBoxRoles();
            CargarDataGridViewUsuario();
        }

        private void CargarComboBoxRoles()
        {
            SqlCommand cm = new SqlCommand("SP_CBRol", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable("Rol");
            adapter.Fill(dt);
            comboBoxRol.DataSource = dt;
            comboBoxRol.DisplayMember = "Rol";
            comboBoxRol.ValueMember = "IDRol";
        }

        private void CargarDataGridViewUsuario()
        {
            DataTable dataTable = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter adapter = new SqlDataAdapter("SP_DGVUsuario", conexion);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dataTable);
            dataGridViewUsuario.DataSource = dataTable; ;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_InsertaGestiondeusuario";
            cm.CommandType = CommandType.StoredProcedure;


            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@usr", SqlDbType.VarChar));
            cm.Parameters["@usr"].Value = txtUserName.Text;

            cm.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar));
            cm.Parameters["@clave"].Value = txtClave.Text;

            cm.Parameters.Add(new SqlParameter("@rol", SqlDbType.VarChar));
            cm.Parameters["@rol"].Value = comboBoxRol.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");
            conexion.Close();
            btnGuardar.Enabled = false;
            Limpiar();
            CargarDataGridViewUsuario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_ActualizacionGestiondeusuario";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar));
            cm.Parameters["@codigo"].Value = txtIDEmpleado.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@usr", SqlDbType.VarChar));
            cm.Parameters["@usr"].Value = txtUserName.Text;

            cm.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar));
            cm.Parameters["@clave"].Value = txtClave.Text;

            cm.Parameters.Add(new SqlParameter("@rol", SqlDbType.VarChar));
            cm.Parameters["@rol"].Value = comboBoxRol.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            conexion.Close();
            btnActualizar.Enabled = false;
            Limpiar();
            CargarDataGridViewUsuario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_EliminaGestiondeusuario";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            cm.Parameters["@codigo"].Value = txtIDEmpleado.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado Satisfactoriamente");
            conexion.Close();
            btnEliminar.Enabled = false;
            Limpiar();
            CargarDataGridViewUsuario();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtIDEmpleado.Clear();
            txtNombre.Clear();
            txtUserName.Clear();
            txtClave.Clear();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_InsertaGestiondeusuario";
            cm.CommandType = CommandType.StoredProcedure;


            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@usr", SqlDbType.VarChar));
            cm.Parameters["@usr"].Value = txtUserName.Text;

            cm.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar));
            cm.Parameters["@clave"].Value = txtClave.Text;

            cm.Parameters.Add(new SqlParameter("@rol", SqlDbType.VarChar));
            cm.Parameters["@rol"].Value = comboBoxRol.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");
            conexion.Close();
            btnGuardar.Enabled = false;
            Limpiar();
            CargarDataGridViewUsuario();

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_ActualizacionGestiondeusuario";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar));
            cm.Parameters["@codigo"].Value = txtIDEmpleado.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = txtNombre.Text;

            cm.Parameters.Add(new SqlParameter("@usr", SqlDbType.VarChar));
            cm.Parameters["@usr"].Value = txtUserName.Text;

            cm.Parameters.Add(new SqlParameter("@clave", SqlDbType.VarChar));
            cm.Parameters["@clave"].Value = txtClave.Text;

            cm.Parameters.Add(new SqlParameter("@rol", SqlDbType.VarChar));
            cm.Parameters["@rol"].Value = comboBoxRol.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            conexion.Close();
            btnActualizar.Enabled = false;
            Limpiar();
            CargarDataGridViewUsuario();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_EliminaGestiondeusuario";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            cm.Parameters["@codigo"].Value = txtIDEmpleado.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado Satisfactoriamente");
            conexion.Close();
            btnEliminar.Enabled = false;
            Limpiar();
            CargarDataGridViewUsuario();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEmpleado.Text = dataGridViewUsuario.CurrentRow.Cells["IDUsuario"].Value.ToString();
            txtNombre.Text = dataGridViewUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
            txtUserName.Text = dataGridViewUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
            txtClave.Text = dataGridViewUsuario.CurrentRow.Cells["Clave"].Value.ToString();
            comboBoxRol.Text = dataGridViewUsuario.CurrentRow.Cells["Rol"].Value.ToString();

        }
    }
}
