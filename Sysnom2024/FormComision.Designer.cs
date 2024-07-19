namespace Sysnom2024
{
    partial class FormComision
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
            MetodoDePago = new Label();
            Fecha = new Label();
            EstadoDePago = new Label();
            MontoDeLaComision = new Label();
            txtIDEmpleado = new TextBox();
            txtFecha = new TextBox();
            txtMontoDeLacomision = new TextBox();
            txtEstadoDePago = new TextBox();
            txtMetodoDePago = new TextBox();
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
            label1.Location = new Point(321, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 0;
            label1.Text = "Comision";
            // 
            // IDEmpleado
            // 
            IDEmpleado.AutoSize = true;
            IDEmpleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            IDEmpleado.Location = new Point(12, 109);
            IDEmpleado.Name = "IDEmpleado";
            IDEmpleado.Size = new Size(108, 23);
            IDEmpleado.TabIndex = 1;
            IDEmpleado.Text = "IDEmpleado";
            // 
            // MetodoDePago
            // 
            MetodoDePago.AutoSize = true;
            MetodoDePago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MetodoDePago.Location = new Point(331, 259);
            MetodoDePago.Name = "MetodoDePago";
            MetodoDePago.Size = new Size(145, 23);
            MetodoDePago.TabIndex = 2;
            MetodoDePago.Text = "Metodo De Pago";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Fecha.Location = new Point(12, 212);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(55, 23);
            Fecha.TabIndex = 3;
            Fecha.Text = "Fecha";
            // 
            // EstadoDePago
            // 
            EstadoDePago.AutoSize = true;
            EstadoDePago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EstadoDePago.Location = new Point(331, 135);
            EstadoDePago.Name = "EstadoDePago";
            EstadoDePago.Size = new Size(135, 23);
            EstadoDePago.TabIndex = 4;
            EstadoDePago.Text = "Estado De Pago";
            // 
            // MontoDeLaComision
            // 
            MontoDeLaComision.AutoSize = true;
            MontoDeLaComision.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MontoDeLaComision.Location = new Point(12, 314);
            MontoDeLaComision.Name = "MontoDeLaComision";
            MontoDeLaComision.Size = new Size(192, 23);
            MontoDeLaComision.TabIndex = 5;
            MontoDeLaComision.Text = "Monto De La Comision";
            // 
            // txtIDEmpleado
            // 
            txtIDEmpleado.Location = new Point(126, 105);
            txtIDEmpleado.Name = "txtIDEmpleado";
            txtIDEmpleado.Size = new Size(125, 27);
            txtIDEmpleado.TabIndex = 6;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(73, 208);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 7;
            // 
            // txtMontoDeLacomision
            // 
            txtMontoDeLacomision.Location = new Point(210, 310);
            txtMontoDeLacomision.Name = "txtMontoDeLacomision";
            txtMontoDeLacomision.Size = new Size(125, 27);
            txtMontoDeLacomision.TabIndex = 8;
            // 
            // txtEstadoDePago
            // 
            txtEstadoDePago.Location = new Point(472, 131);
            txtEstadoDePago.Name = "txtEstadoDePago";
            txtEstadoDePago.Size = new Size(125, 27);
            txtEstadoDePago.TabIndex = 9;
            // 
            // txtMetodoDePago
            // 
            txtMetodoDePago.Location = new Point(482, 255);
            txtMetodoDePago.Name = "txtMetodoDePago";
            txtMetodoDePago.Size = new Size(125, 27);
            txtMetodoDePago.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(663, 47);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 52);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(663, 147);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(95, 52);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(663, 245);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(95, 52);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Silver;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(663, 344);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 52);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // FormComision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtMetodoDePago);
            Controls.Add(txtEstadoDePago);
            Controls.Add(txtMontoDeLacomision);
            Controls.Add(txtFecha);
            Controls.Add(txtIDEmpleado);
            Controls.Add(MontoDeLaComision);
            Controls.Add(EstadoDePago);
            Controls.Add(Fecha);
            Controls.Add(MetodoDePago);
            Controls.Add(IDEmpleado);
            Controls.Add(label1);
            Name = "FormComision";
            Text = "FormComision";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IDEmpleado;
        private Label MetodoDePago;
        private Label Fecha;
        private Label EstadoDePago;
        private Label MontoDeLaComision;
        private TextBox txtIDEmpleado;
        private TextBox txtFecha;
        private TextBox txtMontoDeLacomision;
        private TextBox txtEstadoDePago;
        private TextBox txtMetodoDePago;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnNuevo;
        private Button btnSalir;
    }
}