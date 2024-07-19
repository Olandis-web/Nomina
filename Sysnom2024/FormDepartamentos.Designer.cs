namespace Sysnom2024
{
    partial class FormDepartamentos
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
            IDEmpleado = new Label();
            FechadePago = new Label();
            SalarioBase = new Label();
            TarifaHoraria = new Label();
            Incentivos = new Label();
            Deducciones = new Label();
            SueldoNeto = new Label();
            txtIDEmpleado = new TextBox();
            txtDeducciones = new TextBox();
            txtIncentivos = new TextBox();
            txtTarifaHoraria = new TextBox();
            txtSalarioBase = new TextBox();
            txtFechaDePago = new TextBox();
            txtSueldoNeto = new TextBox();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 38);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // IDEmpleado
            // 
            IDEmpleado.AutoSize = true;
            IDEmpleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            IDEmpleado.Location = new Point(31, 106);
            IDEmpleado.Name = "IDEmpleado";
            IDEmpleado.Size = new Size(108, 23);
            IDEmpleado.TabIndex = 1;
            IDEmpleado.Text = "IDEmpleado";
            // 
            // FechadePago
            // 
            FechadePago.AutoSize = true;
            FechadePago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FechadePago.Location = new Point(31, 182);
            FechadePago.Name = "FechadePago";
            FechadePago.Size = new Size(127, 23);
            FechadePago.TabIndex = 2;
            FechadePago.Text = "Fecha De Pago";
            // 
            // SalarioBase
            // 
            SalarioBase.AutoSize = true;
            SalarioBase.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SalarioBase.Location = new Point(31, 259);
            SalarioBase.Name = "SalarioBase";
            SalarioBase.Size = new Size(106, 23);
            SalarioBase.TabIndex = 3;
            SalarioBase.Text = "Salario Base";
            // 
            // TarifaHoraria
            // 
            TarifaHoraria.AutoSize = true;
            TarifaHoraria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TarifaHoraria.Location = new Point(31, 338);
            TarifaHoraria.Name = "TarifaHoraria";
            TarifaHoraria.Size = new Size(121, 23);
            TarifaHoraria.TabIndex = 4;
            TarifaHoraria.Text = "Tarifa Horaria";
            // 
            // Incentivos
            // 
            Incentivos.AutoSize = true;
            Incentivos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Incentivos.Location = new Point(369, 106);
            Incentivos.Name = "Incentivos";
            Incentivos.Size = new Size(90, 23);
            Incentivos.TabIndex = 5;
            Incentivos.Text = "Incentivos";
            // 
            // Deducciones
            // 
            Deducciones.AutoSize = true;
            Deducciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Deducciones.Location = new Point(369, 182);
            Deducciones.Name = "Deducciones";
            Deducciones.Size = new Size(110, 23);
            Deducciones.TabIndex = 6;
            Deducciones.Text = "Deducciones";
            // 
            // SueldoNeto
            // 
            SueldoNeto.AutoSize = true;
            SueldoNeto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SueldoNeto.Location = new Point(369, 259);
            SueldoNeto.Name = "SueldoNeto";
            SueldoNeto.Size = new Size(109, 23);
            SueldoNeto.TabIndex = 7;
            SueldoNeto.Text = "Sueldo Neto";
            // 
            // txtIDEmpleado
            // 
            txtIDEmpleado.Location = new Point(145, 102);
            txtIDEmpleado.Name = "txtIDEmpleado";
            txtIDEmpleado.Size = new Size(55, 27);
            txtIDEmpleado.TabIndex = 8;
            // 
            // txtDeducciones
            // 
            txtDeducciones.Location = new Point(485, 178);
            txtDeducciones.Name = "txtDeducciones";
            txtDeducciones.Size = new Size(125, 27);
            txtDeducciones.TabIndex = 9;
            // 
            // txtIncentivos
            // 
            txtIncentivos.Location = new Point(465, 102);
            txtIncentivos.Name = "txtIncentivos";
            txtIncentivos.Size = new Size(125, 27);
            txtIncentivos.TabIndex = 10;
            // 
            // txtTarifaHoraria
            // 
            txtTarifaHoraria.Location = new Point(158, 334);
            txtTarifaHoraria.Name = "txtTarifaHoraria";
            txtTarifaHoraria.Size = new Size(125, 27);
            txtTarifaHoraria.TabIndex = 11;
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Location = new Point(143, 255);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(125, 27);
            txtSalarioBase.TabIndex = 12;
            // 
            // txtFechaDePago
            // 
            txtFechaDePago.Location = new Point(164, 178);
            txtFechaDePago.Name = "txtFechaDePago";
            txtFechaDePago.Size = new Size(125, 27);
            txtFechaDePago.TabIndex = 13;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(484, 255);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.Size = new Size(125, 27);
            txtSueldoNeto.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(676, 102);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 46);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(676, 199);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 46);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(676, 294);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 46);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Silver;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(676, 392);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 46);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // FormDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(txtSueldoNeto);
            Controls.Add(txtFechaDePago);
            Controls.Add(txtSalarioBase);
            Controls.Add(txtTarifaHoraria);
            Controls.Add(txtIncentivos);
            Controls.Add(txtDeducciones);
            Controls.Add(txtIDEmpleado);
            Controls.Add(SueldoNeto);
            Controls.Add(Deducciones);
            Controls.Add(Incentivos);
            Controls.Add(TarifaHoraria);
            Controls.Add(SalarioBase);
            Controls.Add(FechadePago);
            Controls.Add(IDEmpleado);
            Controls.Add(label1);
            Name = "FormDepartamentos";
            Text = "FormDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IDEmpleado;
        private Label FechadePago;
        private Label SalarioBase;
        private Label TarifaHoraria;
        private Label Incentivos;
        private Label Deducciones;
        private Label SueldoNeto;
        private TextBox txtIDEmpleado;
        private TextBox txtDeducciones;
        private TextBox txtIncentivos;
        private TextBox txtTarifaHoraria;
        private TextBox txtSalarioBase;
        private TextBox txtFechaDePago;
        private TextBox txtSueldoNeto;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnActualizar;
        private Button btnSalir;
    }
}