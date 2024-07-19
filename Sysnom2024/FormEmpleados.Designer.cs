namespace Sysnom2024
{
    partial class FormEmpleados
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
            Empleados = new Label();
            IDEmpleados = new Label();
            Nombre = new Label();
            FechaRegistro = new Label();
            Posicion = new Label();
            Sueldo = new Label();
            Departamento = new Label();
            Telefono = new Label();
            txtTelefono = new TextBox();
            txtIDEmpleados = new TextBox();
            txtSueldo = new TextBox();
            txtPosicion = new TextBox();
            txtNombre = new TextBox();
            txtFechaRegistro = new TextBox();
            btnSalir = new Button();
            btnNuevo = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            comboBoxDepartamento = new ComboBox();
            SuspendLayout();
            // 
            // Empleados
            // 
            Empleados.AutoSize = true;
            Empleados.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Empleados.Location = new Point(306, 9);
            Empleados.Name = "Empleados";
            Empleados.Size = new Size(159, 38);
            Empleados.TabIndex = 0;
            Empleados.Text = "Empleados";
            Empleados.Click += label1_Click;
            // 
            // IDEmpleados
            // 
            IDEmpleados.AutoSize = true;
            IDEmpleados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            IDEmpleados.Location = new Point(12, 105);
            IDEmpleados.Name = "IDEmpleados";
            IDEmpleados.Size = new Size(115, 23);
            IDEmpleados.TabIndex = 1;
            IDEmpleados.Text = "IDEmpleados";
            IDEmpleados.Click += label2_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.Location = new Point(12, 180);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(76, 23);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            Nombre.Click += label3_Click;
            // 
            // FechaRegistro
            // 
            FechaRegistro.AutoSize = true;
            FechaRegistro.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FechaRegistro.Location = new Point(391, 332);
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Size = new Size(127, 23);
            FechaRegistro.TabIndex = 3;
            FechaRegistro.Text = "Fecha Registro";
            // 
            // Posicion
            // 
            Posicion.AutoSize = true;
            Posicion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Posicion.Location = new Point(391, 231);
            Posicion.Name = "Posicion";
            Posicion.Size = new Size(74, 23);
            Posicion.TabIndex = 4;
            Posicion.Text = "Posicion";
            // 
            // Sueldo
            // 
            Sueldo.AutoSize = true;
            Sueldo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Sueldo.Location = new Point(12, 348);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(65, 23);
            Sueldo.TabIndex = 5;
            Sueldo.Text = "Sueldo";
            // 
            // Departamento
            // 
            Departamento.AutoSize = true;
            Departamento.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Departamento.Location = new Point(391, 122);
            Departamento.Name = "Departamento";
            Departamento.Size = new Size(127, 23);
            Departamento.TabIndex = 6;
            Departamento.Text = "Departamento";
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Telefono.Location = new Point(12, 258);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(78, 23);
            Telefono.TabIndex = 7;
            Telefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(96, 258);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(182, 27);
            txtTelefono.TabIndex = 8;
            // 
            // txtIDEmpleados
            // 
            txtIDEmpleados.Location = new Point(133, 105);
            txtIDEmpleados.Name = "txtIDEmpleados";
            txtIDEmpleados.Size = new Size(41, 27);
            txtIDEmpleados.TabIndex = 9;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(83, 348);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 11;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(471, 231);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(125, 27);
            txtPosicion.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 180);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 27);
            txtNombre.TabIndex = 13;
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Location = new Point(524, 332);
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.Size = new Size(125, 27);
            txtFechaRegistro.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Silver;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(690, 379);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 46);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(690, 180);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(80, 46);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(690, 276);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(80, 46);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(690, 82);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 46);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Location = new Point(514, 122);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(151, 28);
            comboBoxDepartamento.TabIndex = 19;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxDepartamento);
            Controls.Add(btnGuardar);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(btnSalir);
            Controls.Add(txtFechaRegistro);
            Controls.Add(txtNombre);
            Controls.Add(txtPosicion);
            Controls.Add(txtSueldo);
            Controls.Add(txtIDEmpleados);
            Controls.Add(txtTelefono);
            Controls.Add(Telefono);
            Controls.Add(Departamento);
            Controls.Add(Sueldo);
            Controls.Add(Posicion);
            Controls.Add(FechaRegistro);
            Controls.Add(Nombre);
            Controls.Add(IDEmpleados);
            Controls.Add(Empleados);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            Load += FormEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Empleados;
        private Label IDEmpleados;
        private Label Nombre;
        private Label FechaRegistro;
        private Label Posicion;
        private Label Sueldo;
        private Label Departamento;
        private Label Telefono;
        private TextBox txtTelefono;
        private TextBox txtIDEmpleados;
        private TextBox txtSueldo;
        private TextBox txtPosicion;
        private TextBox txtNombre;
        private TextBox txtFechaRegistro;
        private Button btnSalir;
        private Button btnNuevo;
        private Button btnActualizar;
        private Button btnGuardar;
        private ComboBox comboBoxDepartamento;
    }
}