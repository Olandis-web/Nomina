using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormProcesoDescuento : Form
    {
        SqlConnection conexion = new SqlConnection("integrated security=SSPI;data source=DESKTOP-JKG9C4V;" + "persist security info=False;initial catalog=SysNom2024");
        public FormProcesoDescuento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProcesoDescuento_Load(object sender, EventArgs e)
        {
            Llenarcombo();
            CargardataGridView1();
        }
        private void Llenarcombo()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand("SP_CBDescuento", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable("Descuentos");
            adapter.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "NombreDescuento";

        }
        private void CargardataGridView1()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            DataTable dataTable = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter adapter = new SqlDataAdapter("SP_DGVDescuentos", conexion);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_InsertaDescuentos";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Nomempleado", SqlDbType.VarChar));
            cm.Parameters["@Nomempleado"].Value = textBox2.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = comboBox1.Text;

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

            cm.CommandText = "SP_ActualizaDescuentos";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int));
            cm.Parameters["@Codigo"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@nomempleado", SqlDbType.VarChar));
            cm.Parameters["@nomempleado"].Value = textBox2.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = comboBox1.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Satisfactoriamente");
            conexion.Close();
            button3.Enabled = false;
            Limpiar();
            CargardataGridView1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            cm.CommandText = "SP_EliminaDescuentos";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int));
            cm.Parameters["@Codigo"].Value = textBox1.Text;

            conexion.Open();
            cm.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado Satisfactoriamente");
            conexion.Close();
            button4.Enabled = false;
            Limpiar();
            CargardataGridView1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["IDDescuento"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["NombreEmpleado"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["NombreDescuento"].Value.ToString();

            textBox1.Visible = true;
            label8.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string buscar = textBox2.Text.Trim();
            conexion.Open();
            string query = "SELECT * FROM Descuentos WHERE NombreEmpleado LIKE @Buscar ";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Buscar", "%" + buscar + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conexion.Close();
        }
    }
}
