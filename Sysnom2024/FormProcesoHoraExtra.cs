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
    public partial class FormProcesoHoraExtra : Form
    {
        SqlConnection conexion = new SqlConnection("integrated security=SSPI;data source=DESKTOP-JKG9C4V;" + "persist security info=False;initial catalog=SysNom2024");
        public FormProcesoHoraExtra()
        {
            InitializeComponent();
        }

        private void FormProcesoHoraExtra_Load(object sender, EventArgs e)
        {
            Llenarcombo();
            CargardataGridView1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Llenarcombo()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand("SP_CBEstadoAprobacion", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable("EstadoAprobacion");
            adapter.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "EstadoAprobacion";
            this.comboBox1.ValueMember = "IDEstadoAprobacion";


        }
        private void CargardataGridView1()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            DataTable dataTable = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter adapter = new SqlDataAdapter("SP_DGVHoraExtra", conexion);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;

            cm.CommandText = "SP_InsertaHoraExtras";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@nomempleado", SqlDbType.VarChar));
            cm.Parameters["@nomempleado"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
            cm.Parameters["@fecha"].Value = dateTimePicker1.Text;

            cm.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal));
            cm.Parameters["@total"].Value = textBox2.Text;

            cm.Parameters.Add(new SqlParameter("@tarifa", SqlDbType.Decimal));
            cm.Parameters["@tarifa"].Value = textBox3.Text;

            cm.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar));
            cm.Parameters["@estado"].Value = comboBox1.Text;

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

            cm.CommandText = "SP_ActualizaHoraExtras";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int));
            cm.Parameters["@Codigo"].Value = textBox4.Text;

            cm.Parameters.Add(new SqlParameter("@nomempleado", SqlDbType.VarChar));
            cm.Parameters["@nomempleado"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@fecha", SqlDbType.VarChar));
            cm.Parameters["@fecha"].Value = dateTimePicker1.Text;

            cm.Parameters.Add(new SqlParameter("@total", SqlDbType.Decimal));
            cm.Parameters["@total"].Value = textBox2.Text;

            cm.Parameters.Add(new SqlParameter("@tarifa", SqlDbType.Decimal));
            cm.Parameters["@tarifa"].Value = textBox3.Text;

            cm.Parameters.Add(new SqlParameter("@estado", SqlDbType.VarChar));
            cm.Parameters["@estado"].Value = comboBox1.Text;

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
            cm.CommandText = "SP_EliminaHoraExtras";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int));
            cm.Parameters["@Codigo"].Value = textBox4.Text;

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
            textBox4.Text = dataGridView1.CurrentRow.Cells["IDHoraExtra"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["NombreEmpleado"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["TotalHorasextras"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["TarifaPago"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["EstadoAprobacion"].Value.ToString();

            textBox1.Visible = true;
            label8.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string buscar = textBox1.Text.Trim();
            conexion.Open();
            string query = "SELECT * FROM [Horas extras] WHERE NombreEmpleado LIKE @Buscar ";
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
