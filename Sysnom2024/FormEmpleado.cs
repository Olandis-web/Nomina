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
    public partial class FormEmpleado : Form
    {
        SqlConnection conexion = new SqlConnection("integrated security=SSPI;data source=DESKTOP-JKG9C4V\\SQLEXPRESS;" + "persist security info=False;initial catalog=SysNom2024");

        public FormEmpleado()
        {
            
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            Llenarcombo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
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
    }
    

}
