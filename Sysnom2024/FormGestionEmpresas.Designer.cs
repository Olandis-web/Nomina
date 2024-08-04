namespace Sysnom2024
{
    partial class FormGestionEmpresas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dataGridViewEmpresas = new DataGridView();
            ListaDeEmpresas = new Label();
            txtSitioWeb = new TextBox();
            txtRNC = new TextBox();
            txtNombre = new TextBox();
            txtIDEmpresa = new TextBox();
            Direccion = new Label();
            SitioWeb = new Label();
            Propietario = new Label();
            RNC = new Label();
            Nombre = new Label();
            IDEmpresa = new Label();
            GestionDeEmpresas = new Label();
            txtDireccion = new TextBox();
            txtPropietario = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(192, 0, 0);
            btnSalir.Location = new Point(694, 16);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 27);
            btnSalir.TabIndex = 59;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(686, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 42);
            btnEliminar.TabIndex = 58;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(686, 308);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(101, 42);
            btnActualizar.TabIndex = 57;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(686, 237);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 42);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(686, 153);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 42);
            btnNuevo.TabIndex = 55;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // dataGridViewEmpresas
            // 
            dataGridViewEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpresas.Location = new Point(32, 484);
            dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            dataGridViewEmpresas.RowHeadersWidth = 51;
            dataGridViewEmpresas.RowTemplate.Height = 29;
            dataGridViewEmpresas.Size = new Size(755, 194);
            dataGridViewEmpresas.TabIndex = 54;
            dataGridViewEmpresas.CellContentClick += dataGridViewEmpresas_CellContentClick;
            // 
            // ListaDeEmpresas
            // 
            ListaDeEmpresas.AutoSize = true;
            ListaDeEmpresas.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ListaDeEmpresas.Location = new Point(35, 445);
            ListaDeEmpresas.Name = "ListaDeEmpresas";
            ListaDeEmpresas.Size = new Size(177, 24);
            ListaDeEmpresas.TabIndex = 53;
            ListaDeEmpresas.Text = "Lista de Empresas";
            // 
            // txtSitioWeb
            // 
            txtSitioWeb.Location = new Point(160, 291);
            txtSitioWeb.Name = "txtSitioWeb";
            txtSitioWeb.Size = new Size(156, 27);
            txtSitioWeb.TabIndex = 50;
            txtSitioWeb.TextChanged += txtSitioWeb_TextChanged;
            // 
            // txtRNC
            // 
            txtRNC.Location = new Point(160, 184);
            txtRNC.Name = "txtRNC";
            txtRNC.Size = new Size(156, 27);
            txtRNC.TabIndex = 49;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 27);
            txtNombre.TabIndex = 48;
            // 
            // txtIDEmpresa
            // 
            txtIDEmpresa.Location = new Point(159, 84);
            txtIDEmpresa.Name = "txtIDEmpresa";
            txtIDEmpresa.Size = new Size(53, 27);
            txtIDEmpresa.TabIndex = 47;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Direccion.Location = new Point(35, 383);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(95, 24);
            Direccion.TabIndex = 46;
            Direccion.Text = "Direccion";
            // 
            // SitioWeb
            // 
            SitioWeb.AutoSize = true;
            SitioWeb.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SitioWeb.Location = new Point(32, 290);
            SitioWeb.Name = "SitioWeb";
            SitioWeb.Size = new Size(93, 24);
            SitioWeb.TabIndex = 45;
            SitioWeb.Text = "Sitio Web";
            // 
            // Propietario
            // 
            Propietario.AutoSize = true;
            Propietario.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Propietario.Location = new Point(35, 237);
            Propietario.Name = "Propietario";
            Propietario.Size = new Size(112, 24);
            Propietario.TabIndex = 44;
            Propietario.Text = "Propietario";
            // 
            // RNC
            // 
            RNC.AutoSize = true;
            RNC.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RNC.Location = new Point(35, 184);
            RNC.Name = "RNC";
            RNC.Size = new Size(49, 24);
            RNC.TabIndex = 43;
            RNC.Text = "RNC";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.Location = new Point(35, 134);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(83, 24);
            Nombre.TabIndex = 42;
            Nombre.Text = "Nombre";
            // 
            // IDEmpresa
            // 
            IDEmpresa.AutoSize = true;
            IDEmpresa.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IDEmpresa.Location = new Point(35, 87);
            IDEmpresa.Name = "IDEmpresa";
            IDEmpresa.Size = new Size(110, 24);
            IDEmpresa.TabIndex = 41;
            IDEmpresa.Text = "IDEmpresa";
            // 
            // GestionDeEmpresas
            // 
            GestionDeEmpresas.AutoSize = true;
            GestionDeEmpresas.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            GestionDeEmpresas.Location = new Point(275, 8);
            GestionDeEmpresas.Name = "GestionDeEmpresas";
            GestionDeEmpresas.Size = new Size(284, 34);
            GestionDeEmpresas.TabIndex = 40;
            GestionDeEmpresas.Text = "Gestion de Empresas";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 383);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(156, 27);
            txtDireccion.TabIndex = 60;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(160, 237);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(156, 27);
            txtPropietario.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 335);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 62;
            label1.Text = "Telefono";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 63;
            // 
            // FormGestionEmpresas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(830, 690);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtPropietario);
            Controls.Add(txtDireccion);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridViewEmpresas);
            Controls.Add(ListaDeEmpresas);
            Controls.Add(txtSitioWeb);
            Controls.Add(txtRNC);
            Controls.Add(txtNombre);
            Controls.Add(txtIDEmpresa);
            Controls.Add(Direccion);
            Controls.Add(SitioWeb);
            Controls.Add(Propietario);
            Controls.Add(RNC);
            Controls.Add(Nombre);
            Controls.Add(IDEmpresa);
            Controls.Add(GestionDeEmpresas);
            Name = "FormGestionEmpresas";
            Text = "FormGestionEmpresas";
            Load += FormGestionEmpresas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpresas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dataGridViewEmpresas;
        private Label ListaDeEmpresas;
        private TextBox txtSitioWeb;
        private TextBox txtRNC;
        private TextBox txtNombre;
        private TextBox txtIDEmpresa;
        private Label Direccion;
        private Label SitioWeb;
        private Label Propietario;
        private Label RNC;
        private Label Nombre;
        private Label IDEmpresa;
        private Label GestionDeEmpresas;
        private TextBox txtDireccion;
        private TextBox txtPropietario;
        private Label label1;
        private TextBox textBox1;
    }
}