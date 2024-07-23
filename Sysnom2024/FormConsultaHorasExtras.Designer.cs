namespace Sysnom2024
{
    partial class FormConsultaHorasExtras
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
            label8 = new Label();
            button1 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(755, 188);
            dataGridView1.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 215);
            label8.Name = "label8";
            label8.Size = new Size(252, 24);
            label8.TabIndex = 52;
            label8.Text = "Resultados de la busqueda";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(404, 154);
            button1.Name = "button1";
            button1.Size = new Size(93, 27);
            button1.TabIndex = 51;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(669, 27);
            button5.Name = "button5";
            button5.Size = new Size(93, 27);
            button5.TabIndex = 50;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 27);
            textBox1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(180, 24);
            label2.TabIndex = 48;
            label2.Text = "Digite su busqueda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 20);
            label1.Name = "label1";
            label1.Size = new Size(338, 34);
            label1.TabIndex = 47;
            label1.Text = "Consulta de Horas Extras";
            // 
            // FormConsultaHorasExtras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(771, 458);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConsultaHorasExtras";
            Text = "FormConsultaHorasExtras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label8;
        private Button button1;
        private Button button5;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}