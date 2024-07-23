namespace Sysnom2024
{
    partial class FormEmpleado
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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(673, 16);
            button5.Name = "button5";
            button5.Size = new Size(93, 27);
            button5.TabIndex = 39;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(665, 376);
            button4.Name = "button4";
            button4.Size = new Size(101, 42);
            button4.TabIndex = 38;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(665, 308);
            button3.Name = "button3";
            button3.Size = new Size(101, 42);
            button3.TabIndex = 37;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(665, 237);
            button2.Name = "button2";
            button2.Size = new Size(101, 42);
            button2.TabIndex = 36;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(665, 153);
            button1.Name = "button1";
            button1.Size = new Size(101, 42);
            button1.TabIndex = 35;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 484);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(755, 188);
            dataGridView1.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 445);
            label8.Name = "label8";
            label8.Size = new Size(186, 24);
            label8.TabIndex = 33;
            label8.Text = "Lista de Empleados";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(139, 384);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 267);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 31;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 327);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(156, 27);
            textBox4.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 27);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 27);
            textBox1.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 383);
            label7.Name = "label7";
            label7.Size = new Size(84, 24);
            label7.TabIndex = 26;
            label7.Text = "Posicion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 326);
            label6.Name = "label6";
            label6.Size = new Size(72, 24);
            label6.TabIndex = 25;
            label6.Text = "Sueldo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 266);
            label5.Name = "label5";
            label5.Size = new Size(140, 24);
            label5.TabIndex = 24;
            label5.Text = "Departamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 210);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 23;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 153);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 22;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 97);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 21;
            label2.Text = "IDEmpleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(386, 34);
            label1.TabIndex = 20;
            label1.Text = "Mantenimiento de Empleados";
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(775, 682);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            Load += FormEmpleado_Load;
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
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}