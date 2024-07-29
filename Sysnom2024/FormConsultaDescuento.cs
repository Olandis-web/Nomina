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

namespace Sysnom2024
{
    public partial class FormConsultaDescuento : Form
    {
        SqlConnection conexion = new SqlConnection("Integrated security=SSPI;data source=DESKTOP-JKG9C4V\\SQLEXPRESS;" + "persist security info=False;initial catalog=SysNom2024");
        public FormConsultaDescuento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormConsultaDescuento_Load(object sender, EventArgs e)
        {
            Llenargrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscar = textBox1.Text.Trim();
            conexion.Open();
            string query = "SELECT * FROM Descuentos WHERE NombreDescuento LIKE @Buscar ";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Buscar", "%" + buscar + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        public void Llenargrid()
        {
            //SqlConnection dataconnection = new Sqlconnection(ConfigurationSettings.AppSettings["conexion"].ToString());
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexion;
            SqlDataAdapter da = new SqlDataAdapter("SP_DGVDescuentos", conexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["NombreDescuento"].Value.ToString();

            textBox1.Visible = true;
            label8.Visible = true;
        }
    }
}
