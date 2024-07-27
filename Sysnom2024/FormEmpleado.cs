using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sysnom2024
{
    public partial class FormEmpleado : Form
    {
        SqlConnection conexion = new SqlConnection("integrated security=SSPI;data source=DESKTOP-JKG9C4V;" + "persist security info=False;initial catalog=SysNom2024");

        public FormEmpleado()
        {

            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            Llenarcombo();
            Llenarcombo2();
            CargardataGridView1();
            //Establecer Varibales para el incremento del id 
            int siguienteID = ObtenerSiguienteID();
            textBox1.Text = siguienteID.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Funcion vacia
        }

        //Dar ID automaticamente
        private int ObtenerSiguienteID()
        {
            int siguienteID = 0;
            try
            {
                conexion.Open();
                string query = "SELECT ISNULL(MAX(IDEmpleado), 0) + 1 FROM Empleados";
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


        private void Llenarcombo()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand("SP_CBDepartamentos", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable("Departamentos");
            adapter.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "NombreDepartamento";
            this.comboBox1.ValueMember = "IDDepartamento";


        }
        private void Llenarcombo2()
        {

            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand("SP_CBPosicion", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable("Posiciones");
            adapter.Fill(dt);
            this.comboBox2.DataSource = dt;
            this.comboBox2.DisplayMember = "NombrePosicion";
            this.comboBox2.ValueMember = "IDPosicion";



        }
        private void CargardataGridView1()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            DataTable dataTable = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter adapter = new SqlDataAdapter("SP_DGVEmpleados", conexion);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }


        //Declarar la variable Limpiar y hacer que limpie todos los texbox
        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
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

            cm.CommandText = "SP_InsertaEmpleado";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = textBox2.Text;

            cm.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar));
            cm.Parameters["@tel"].Value = textBox3.Text;

            cm.Parameters.Add(new SqlParameter("@dep", SqlDbType.VarChar));
            cm.Parameters["@dep"].Value = comboBox1.Text;

            cm.Parameters.Add(new SqlParameter("@sd", SqlDbType.Decimal));
            cm.Parameters["@sd"].Value = textBox4.Text;

            cm.Parameters.Add(new SqlParameter("@psc", SqlDbType.VarChar));
            cm.Parameters["@psc"].Value = comboBox2.Text;

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

                cm.CommandText = "SP_ActualizaEmpleado";
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
                cm.Parameters["@codigo"].Value = textBox1.Text;

                cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
                cm.Parameters["@nom"].Value = textBox2.Text;

                cm.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar));
                cm.Parameters["@tel"].Value = textBox3.Text;

                cm.Parameters.Add(new SqlParameter("@dep", SqlDbType.VarChar));
                cm.Parameters["@dep"].Value = comboBox1.Text;

                cm.Parameters.Add(new SqlParameter("@sd", SqlDbType.Decimal));
                cm.Parameters["@sd"].Value = textBox4.Text;

                cm.Parameters.Add(new SqlParameter("@psc", SqlDbType.VarChar));
                cm.Parameters["@psc"].Value = comboBox2.Text;

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
                cm.CommandText = "SP_EliminaEmpleado";
                cm.CommandType = CommandType.StoredProcedure;

                cm.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
                cm.Parameters["@codigo"].Value = textBox1.Text ;

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

            textBox1.Text = dataGridView1.CurrentRow.Cells["IDEmpleado"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Sueldo"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["Posicion"].Value.ToString();

            textBox1.Visible = true;
            label8.Visible = true;
        }
    }


}
