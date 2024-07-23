namespace Sysnom2024
{
    partial class FormPosicion
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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(748, 188);
            dataGridView1.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 278);
            label5.Name = "label5";
            label5.Size = new Size(181, 24);
            label5.TabIndex = 39;
            label5.Text = "Lista de Posiciones";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(657, 17);
            button5.Name = "button5";
            button5.Size = new Size(93, 27);
            button5.TabIndex = 38;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(657, 197);
            button4.Name = "button4";
            button4.Size = new Size(101, 42);
            button4.TabIndex = 37;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(534, 197);
            button3.Name = "button3";
            button3.Size = new Size(101, 42);
            button3.TabIndex = 36;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(657, 122);
            button2.Name = "button2";
            button2.Size = new Size(101, 42);
            button2.TabIndex = 35;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(534, 122);
            button1.Name = "button1";
            button1.Size = new Size(101, 42);
            button1.TabIndex = 34;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 27);
            textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(53, 27);
            textBox1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 211);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 30;
            label4.Text = "Sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 154);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 29;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 24);
            label2.TabIndex = 28;
            label2.Text = "IDPosicion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(382, 34);
            label1.TabIndex = 27;
            label1.Text = "Mantenimiento de Posiciones";
            // 
            // FormPosicion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(779, 510);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPosicion";
            Text = "FormPosicion";
            Load += FormPosicion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}