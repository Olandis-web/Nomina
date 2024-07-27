using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sysnom2024
{
    public partial class FormDepartamento : Form
    {
        SqlConnection conexion = new SqlConnection("integrated security=SSPI;data source=DESKTOP-HVC9RKQ;" + "persist security info=False;initial catalog=SysNom2024");
        public FormDepartamento()
        {
            InitializeComponent();
        }

        private void FormDepartamento_Load(object sender, EventArgs e)
        {
            CargardataGridView1();
            //Establecer Varibales para el incremento del id 
            int siguienteID = ObtenerSiguienteID();
            textBox1.Text = siguienteID.ToString();
        }

        //Dar ID automaticamente
        private int ObtenerSiguienteID()
        {
            int siguienteID = 0;
            try
            {
                conexion.Open();
                string query = "SELECT ISNULL(MAX(IDDepartamento), 0) + 1 FROM Departamentos";
                SqlCommand cmd = new SqlCommand(query, conexion);
                siguienteID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return siguienteID;
        }

        private void CargardataGridView1()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            DataTable dataTable = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter adapter = new SqlDataAdapter("SP_DGVDepartamentos", conexion);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        //Declarar la variable Limpiar y hacer que limpie todos los texbox
        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.Text = ObtenerSiguienteID().ToString();
        }

        //Proceso de guardar y actualizar
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_InsertaDepartamento";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = textBox2.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Guardado Satisfactoriamente");
            conexion.Close();
            button2.Enabled = false;
            Limpiar();
            CargardataGridView1();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_ActualizaDepartamento";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            cm.Parameters["@codigo"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = textBox2.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            conexion.Close();
            button2.Enabled = false;
            Limpiar();
            CargardataGridView1();
        }

        //Proceso de eliminar y salir
        private void button4_Click(object sender, EventArgs e)
        {

            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            cm.CommandText = "SP_EliminaDepartamento";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            cm.Parameters["@codigo"].Value = textBox1.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado Satisfactoriamente");
            conexion.Close();
            button2.Enabled = false;
            Limpiar();
            CargardataGridView1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //llenado del dataGridWie
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["IDDepartamento"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            
            textBox1.Visible = true;
            label5.Visible = true;
        }
    }
}
