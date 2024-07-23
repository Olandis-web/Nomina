namespace Sysnom2024
{
    partial class FormProcesoDescuento
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(681, 16);
            button5.Name = "button5";
            button5.Size = new Size(93, 27);
            button5.TabIndex = 95;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(679, 180);
            button4.Name = "button4";
            button4.Size = new Size(101, 42);
            button4.TabIndex = 94;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(556, 180);
            button3.Name = "button3";
            button3.Size = new Size(101, 42);
            button3.TabIndex = 93;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(679, 90);
            button2.Name = "button2";
            button2.Size = new Size(101, 42);
            button2.TabIndex = 92;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(556, 90);
            button1.Name = "button1";
            button1.Size = new Size(101, 42);
            button1.TabIndex = 91;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(755, 188);
            dataGridView1.TabIndex = 90;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 286);
            label8.Name = "label8";
            label8.Size = new Size(189, 24);
            label8.TabIndex = 89;
            label8.Text = "Lista de Comisiones";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 85;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 27);
            textBox1.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 210);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 81;
            label4.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 153);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 80;
            label3.Text = "ID Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 97);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 79;
            label2.Text = "IDDescuento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 34);
            label1.TabIndex = 78;
            label1.Text = "Proceso de Descuento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 96;
            // 
            // FormProcesoDescuento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(797, 528);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProcesoDescuento";
            Text = "FormProcesoDescuento";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
    }
}