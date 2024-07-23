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
            FormEmpleado Empleados = new FormEmpleado();
            Empleados.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormPosicion posiciones = new FormPosicion();
            posiciones.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartamento Departamentos = new FormDepartamento();
            Departamentos.Show();
        }

        private void descuentosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProcesoDescuento Descuentos = new FormProcesoDescuento();
            Descuentos.Show();
        }

        private void horasExtrasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProcesoHoraExtra HorasExtras = new FormProcesoHoraExtra();
            HorasExtras.Show();
        }

        private void comisionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProcesoComision Comision = new FormProcesoComision();
            Comision.Show();
        }

        private void gestionDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios GestionUsuario = new FormGestionUsuarios();
            GestionUsuario.Show();
        }

        private void gestionDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionEmpresas GestionEmpresa = new FormGestionEmpresas();
            GestionEmpresa.Show();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaDescuento Consultadescuento = new FormConsultaDescuento();
            Consultadescuento.Show();
        }

        private void horasExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaHorasExtras Consultahoras = new FormConsultaHorasExtras();
            Consultahoras.Show();
        }

        private void comisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaComision Consultacomision = new FormConsultaComision();
            Consultacomision.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaEmpleado Consultaempleado = new FormConsultaEmpleado();
            Consultaempleado.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}