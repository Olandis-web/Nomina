namespace Sysnom2024
{
    partial class FormPosiciones
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
            SueldoDePosicion = new Label();
            NombreDePosicion = new Label();
            CodigoDePosicion = new Label();
            txtCodigoDePosicion = new TextBox();
            txtNombreDePosicion = new TextBox();
            txtSueldoDePosicion = new TextBox();
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
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 0;
            label1.Text = "Posiciones";
            // 
            // SueldoDePosicion
            // 
            SueldoDePosicion.AutoSize = true;
            SueldoDePosicion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SueldoDePosicion.Location = new Point(106, 336);
            SueldoDePosicion.Name = "SueldoDePosicion";
            SueldoDePosicion.Size = new Size(161, 23);
            SueldoDePosicion.TabIndex = 1;
            SueldoDePosicion.Text = "Sueldo De Posicion";
            // 
            // NombreDePosicion
            // 
            NombreDePosicion.AutoSize = true;
            NombreDePosicion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NombreDePosicion.Location = new Point(106, 222);
            NombreDePosicion.Name = "NombreDePosicion";
            NombreDePosicion.Size = new Size(172, 23);
            NombreDePosicion.TabIndex = 2;
            NombreDePosicion.Text = "Nombre De Posicion";
            // 
            // CodigoDePosicion
            // 
            CodigoDePosicion.AutoSize = true;
            CodigoDePosicion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CodigoDePosicion.Location = new Point(106, 108);
            CodigoDePosicion.Name = "CodigoDePosicion";
            CodigoDePosicion.Size = new Size(164, 23);
            CodigoDePosicion.TabIndex = 3;
            CodigoDePosicion.Text = "Codigo De Posicion";
            // 
            // txtCodigoDePosicion
            // 
            txtCodigoDePosicion.Location = new Point(303, 108);
            txtCodigoDePosicion.Name = "txtCodigoDePosicion";
            txtCodigoDePosicion.Size = new Size(170, 27);
            txtCodigoDePosicion.TabIndex = 4;
            // 
            // txtNombreDePosicion
            // 
            txtNombreDePosicion.Location = new Point(303, 222);
            txtNombreDePosicion.Name = "txtNombreDePosicion";
            txtNombreDePosicion.Size = new Size(163, 27);
            txtNombreDePosicion.TabIndex = 5;
            // 
            // txtSueldoDePosicion
            // 
            txtSueldoDePosicion.Location = new Point(303, 336);
            txtSueldoDePosicion.Name = "txtSueldoDePosicion";
            txtSueldoDePosicion.Size = new Size(163, 27);
            txtSueldoDePosicion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(620, 83);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 48);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Silver;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(620, 183);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 49);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(620, 282);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 47);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Silver;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(620, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 44);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // FormPosiciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(txtSueldoDePosicion);
            Controls.Add(txtNombreDePosicion);
            Controls.Add(txtCodigoDePosicion);
            Controls.Add(CodigoDePosicion);
            Controls.Add(NombreDePosicion);
            Controls.Add(SueldoDePosicion);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "FormPosiciones";
            Text = "FormPosiciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label SueldoDePosicion;
        private Label NombreDePosicion;
        private Label CodigoDePosicion;
        private TextBox txtCodigoDePosicion;
        private TextBox txtNombreDePosicion;
        private TextBox txtSueldoDePosicion;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnActualizar;
        private Button btnSalir;
    }
}