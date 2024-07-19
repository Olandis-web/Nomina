namespace Sysnom2024
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados Empleados = new FormEmpleados();
            Empleados.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormPosiciones posiciones = new FormPosiciones();
            posiciones.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartamentos Departamentos = new FormDepartamentos();
            Departamentos.Show();
        }

        private void descuentosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormDescuentos Descuentos = new FormDescuentos();
            Descuentos.Show();
        }

        private void horasExtrasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHorasExtras HorasExtras = new FormHorasExtras();
            HorasExtras.Show();
        }

        private void comisionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormComision Comision = new FormComision();
            Comision.Show();
        }

        private void gestionDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionUsuario GestionUsuario = new FormGestionUsuario();
            GestionUsuario.Show();
        }

        private void gestionDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionEmpresa GestionEmpresa = new FormGestionEmpresa();   
            GestionEmpresa.Show();
        }
    }
}