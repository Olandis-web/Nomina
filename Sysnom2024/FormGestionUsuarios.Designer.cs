namespace Sysnom2024
{
    partial class FormGestionUsuarios
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
            dataGridViewUsuario = new DataGridView();
            label8 = new Label();
            comboBoxRol = new ComboBox();
            txtUserName = new TextBox();
            txtNombre = new TextBox();
            txtIDEmpleado = new TextBox();
            Rol = new Label();
            Clave = new Label();
            UserName = new Label();
            Nombre = new Label();
            IDEmpleado = new Label();
            label1 = new Label();
            txtClave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(192, 0, 0);
            btnSalir.Location = new Point(672, 16);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(93, 27);
            btnSalir.TabIndex = 59;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(663, 313);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 42);
            btnEliminar.TabIndex = 58;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(663, 245);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(101, 42);
            btnActualizar.TabIndex = 57;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(663, 174);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 42);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(663, 90);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 42);
            btnNuevo.TabIndex = 55;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuario
            // 
            dataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuario.Location = new Point(9, 460);
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.RowHeadersWidth = 51;
            dataGridViewUsuario.RowTemplate.Height = 29;
            dataGridViewUsuario.Size = new Size(755, 188);
            dataGridViewUsuario.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 421);
            label8.Name = "label8";
            label8.Size = new Size(166, 24);
            label8.TabIndex = 53;
            label8.Text = "Lista de Usuarios";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(138, 336);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(151, 28);
            comboBoxRol.TabIndex = 52;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(138, 211);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(156, 27);
            txtUserName.TabIndex = 49;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 153);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 27);
            txtNombre.TabIndex = 48;
            // 
            // txtIDEmpleado
            // 
            txtIDEmpleado.Location = new Point(138, 98);
            txtIDEmpleado.Name = "txtIDEmpleado";
            txtIDEmpleado.Size = new Size(53, 27);
            txtIDEmpleado.TabIndex = 47;
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Rol.Location = new Point(13, 335);
            Rol.Name = "Rol";
            Rol.Size = new Size(40, 24);
            Rol.TabIndex = 46;
            Rol.Text = "Rol";
            // 
            // Clave
            // 
            Clave.AutoSize = true;
            Clave.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clave.Location = new Point(13, 266);
            Clave.Name = "Clave";
            Clave.Size = new Size(60, 24);
            Clave.TabIndex = 44;
            Clave.Text = "Clave";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.Location = new Point(13, 210);
            UserName.Name = "UserName";
            UserName.Size = new Size(106, 24);
            UserName.TabIndex = 43;
            UserName.Text = "UserName";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.Location = new Point(13, 153);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(83, 24);
            Nombre.TabIndex = 42;
            Nombre.Text = "Nombre";
            // 
            // IDEmpleado
            // 
            IDEmpleado.AutoSize = true;
            IDEmpleado.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IDEmpleado.Location = new Point(13, 97);
            IDEmpleado.Name = "IDEmpleado";
            IDEmpleado.Size = new Size(119, 24);
            IDEmpleado.TabIndex = 41;
            IDEmpleado.Text = "IDEmpleado";
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(273, 16);
            label1.Name = "label1";
            label1.Size = new Size(269, 34);
            label1.TabIndex = 40;
            label1.Text = "Gestion de Usuarios";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(138, 267);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(156, 27);
            txtClave.TabIndex = 60;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 664);
            Controls.Add(txtClave);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridViewUsuario);
            Controls.Add(label8);
            Controls.Add(comboBoxRol);
            Controls.Add(txtUserName);
            Controls.Add(txtNombre);
            Controls.Add(txtIDEmpleado);
            Controls.Add(Rol);
            Controls.Add(Clave);
            Controls.Add(UserName);
            Controls.Add(Nombre);
            Controls.Add(IDEmpleado);
            Controls.Add(label1);
            Name = "FormGestionUsuarios";
            Text = "FormGestionUsuarios";
            Load += FormGestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dataGridViewUsuario;
        private Label label8;
        private ComboBox comboBoxRol;
        private TextBox txtUserName;
        private TextBox txtNombre;
        private TextBox txtIDEmpleado;
        private Label Rol;
        private Label Clave;
        private Label UserName;
        private Label Nombre;
        private Label IDEmpleado;
        private Label label1;
        private TextBox txtClave;
    }
}