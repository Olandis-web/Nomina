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

namespace Sysnom2024
{
        public partial class FormGestionUsuarios : Form
        {
            private readonly SqlConnection conexion = new SqlConnection("Integrated security=SSPI;data source=DESKTOP-JKG9C4V\\SQLEXPRESS\\SQLEXPRESS;persist security info=False;initial catalog=SysNom2024");

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
                using (SqlCommand cm = new SqlCommand("SP_CBRol", conexion))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable("Rol");
                    adapter.Fill(dt);
                    comboBoxRol.DataSource = dt;
                    comboBoxRol.DisplayMember = "Nombre";
                    comboBoxRol.ValueMember = "Rol";
                }
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
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InsertaGestiondesuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDEmpleado", Convert.ToInt32(txtIDEmpleado.Text));
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
                        cmd.Parameters.AddWithValue("@Rol", comboBoxRol.SelectedValue);

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        MessageBox.Show("Registro Guardado Satisfactoriamente");
                        btnGuardar.Enabled = false;
                        Limpiar();
                        CargarDataGridViewUsuario();
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
                    using (SqlCommand cmd = new SqlCommand("SP_ActualizaGestiondeusuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDEmpleado", Convert.ToInt32(txtIDEmpleado.Text));
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
                        cmd.Parameters.AddWithValue("@Rol", comboBoxRol.SelectedValue);

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        MessageBox.Show("Registro Actualizado Satisfactoriamente");
                        Limpiar();
                        CargarDataGridViewUsuario();
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
                    using (SqlCommand cmd = new SqlCommand("SP_EliminaGestiondeusuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDEmpleado", Convert.ToInt32(txtIDEmpleado.Text));

                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        MessageBox.Show("Registro Eliminado Satisfactoriamente");
                        Limpiar();
                        CargarDataGridViewUsuario();
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
                txtIDEmpleado.Text = "";
                txtNombre.Text = "";
                txtUserName.Text = "";
                txtClave.Text = "";
                comboBoxRol.SelectedIndex = -1;
            }
        }
    }
