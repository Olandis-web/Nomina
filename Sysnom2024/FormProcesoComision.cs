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
    public partial class FormProcesoComision : Form
    {
        SqlConnection conexion = new SqlConnection("integrated security=SSPI;data source=DESKTOP-JKG9C4V;" + "persist security info=False;initial catalog=SysNom2024");

        public FormProcesoComision()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProcesoComision_Load(object sender, EventArgs e)
        {
            Llenarcombo();
            Llenarcombo2();
            CargardataGridView1();
        }

        private void Llenarcombo()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand("SP_CBEstadoPago", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable("Comision");
            adapter.Fill(dt);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "EstadoPago";
            this.comboBox1.ValueMember = "IDEstadoPago";


        }
        private void Llenarcombo2()
        {

            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            SqlCommand cm = new SqlCommand("SP_CBMetodoPago", conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable("Comision");
            adapter.Fill(dt);
            this.comboBox2.DataSource = dt;
            this.comboBox2.DisplayMember = "MetodoPago";
            this.comboBox2.ValueMember = "IDMetodoPago";
        }
        private void CargardataGridView1()
        {
            //SqlConnection dataConnection = new SqlConnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            DataTable dataTable = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter adapter = new SqlDataAdapter("SP_DGVComision", conexion);
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

            cm.CommandText = "SP_InsertaComision";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = textBox2.Text;

            cm.Parameters.Add(new SqlParameter("@monto", SqlDbType.Decimal));
            cm.Parameters["@monto"].Value = textBox3.Text;

            cm.Parameters.Add(new SqlParameter("@estadopago", SqlDbType.VarChar));
            cm.Parameters["@estadopago"].Value = comboBox1.Text;

            cm.Parameters.Add(new SqlParameter("@metodo", SqlDbType.VarChar));
            cm.Parameters["@metodo"].Value = comboBox2.Text;

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

            cm.CommandText = "SP_ActualizaComision";
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int));
            cm.Parameters["@Codigo"].Value = textBox1.Text;

            cm.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
            cm.Parameters["@nom"].Value = textBox2.Text;

            cm.Parameters.Add(new SqlParameter("@monto", SqlDbType.VarChar));
            cm.Parameters["@monto"].Value = textBox3.Text;

            cm.Parameters.Add(new SqlParameter("@estadopago", SqlDbType.VarChar));
            cm.Parameters["@estadopago"].Value = comboBox1.Text;

            cm.Parameters.Add(new SqlParameter("@metodo", SqlDbType.VarChar));
            cm.Parameters["@metodo"].Value = comboBox2.Text;

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
            cm.CommandText = "SP_EliminaComision";
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
            textBox1.Text = dataGridView1.CurrentRow.Cells["IDComision"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["NombreEmpleado"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["MontoComision"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["EstadoPago"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["MetodoPago"].Value.ToString();

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
            string buscar = textBox2.Text.Trim();
            conexion.Open();
            string query = "SELECT * FROM Comision WHERE NombreEmpleado LIKE @Buscar ";
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
