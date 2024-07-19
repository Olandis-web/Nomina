namespace Sysnom2024
{
    partial class FormGestionUsuario
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
            label1 = new Label();
            Codigo = new Label();
            Nombre = new Label();
            Usuario = new Label();
            Clave = new Label();
            Rol = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            txtRol = new TextBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 38);
            label1.TabIndex = 0;
            label1.Text = "Gestion De Usuario";
            // 
            // Codigo
            // 
            Codigo.AutoSize = true;
            Codigo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Codigo.Location = new Point(143, 93);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(68, 23);
            Codigo.TabIndex = 1;
            Codigo.Text = "Codigo";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.Location = new Point(143, 164);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(76, 23);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Usuario.Location = new Point(143, 237);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(70, 23);
            Usuario.TabIndex = 3;
            Usuario.Text = "Usuario";
            // 
            // Clave
            // 
            Clave.AutoSize = true;
            Clave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Clave.Location = new Point(143, 313);
            Clave.Name = "Clave";
            Clave.Size = new Size(53, 23);
            Clave.TabIndex = 4;
            Clave.Text = "Clave";
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Rol.Location = new Point(143, 386);
            Rol.Name = "Rol";
            Rol.Size = new Size(36, 23);
            Rol.TabIndex = 5;
            Rol.Text = "Rol";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(217, 89);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(225, 160);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(219, 233);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 8;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(202, 309);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 9;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(185, 382);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(125, 27);
            txtRol.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(621, 60);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 56);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(621, 164);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 56);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(621, 268);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(92, 56);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Silver;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(621, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(92, 56);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // FormGestionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtRol);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(Rol);
            Controls.Add(Clave);
            Controls.Add(Usuario);
            Controls.Add(Nombre);
            Controls.Add(Codigo);
            Controls.Add(label1);
            Name = "FormGestionUsuario";
            Text = "FormGestionUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Codigo;
        private Label Nombre;
        private Label Usuario;
        private Label Clave;
        private Label Rol;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private TextBox txtRol;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnNuevo;
        private Button btnSalir;
    }
}