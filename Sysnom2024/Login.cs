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
    public partial class Login : Form
    {
        SqlConnection conexion = new SqlConnection("integrated security=SSPI;data source=DESKTOP-JKG9C4V;" + "persist security info=False;initial catalog=SysNom2024");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "Select * from [Gestión de usuario] where Usuario ='" + textBox1.Text + "' and Clave = '" + textBox2.Text + "'";
            SqlCommand cm = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = cm.ExecuteReader();

            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido");

                FormMenu menu = new FormMenu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrectos");
                Limpiar();
            }
            conexion.Close();
        }

        public void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

    }
}
