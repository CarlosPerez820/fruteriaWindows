namespace Sistema_Fruteria
{
    partial class clientes
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
            panelTitulo = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panelTabla = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelFormularios = new TableLayoutPanel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            textBox4 = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            textBox5 = new TextBox();
            label6 = new Label();
            panelTitulo.SuspendLayout();
            panel1.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panelFormularios.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(990, 53);
            panelTitulo.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(377, 4);
            label1.Name = "label1";
            label1.Size = new Size(246, 45);
            label1.TabIndex = 0;
            label1.Text = "Lista de clientes";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(panelTabla);
            panel1.Controls.Add(panelFormularios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 555);
            panel1.TabIndex = 21;
            // 
            // panelTabla
            // 
            panelTabla.BackColor = SystemColors.Info;
            panelTabla.ColumnCount = 2;
            panelTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.93939F));
            panelTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.060606F));
            panelTabla.Controls.Add(dataGridView1, 0, 0);
            panelTabla.Controls.Add(panel4, 1, 0);
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 100);
            panelTabla.Name = "panelTabla";
            panelTabla.Padding = new Padding(20);
            panelTabla.RowCount = 1;
            panelTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelTabla.Size = new Size(990, 455);
            panelTabla.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(23, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(696, 409);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(725, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 409);
            panel4.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(54, 164);
            button3.Name = "button3";
            button3.Size = new Size(140, 48);
            button3.TabIndex = 2;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(54, 258);
            button2.Name = "button2";
            button2.Size = new Size(140, 48);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(54, 64);
            button1.Name = "button1";
            button1.Size = new Size(140, 48);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = SystemColors.ButtonHighlight;
            panelFormularios.ColumnCount = 4;
            panelFormularios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            panelFormularios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            panelFormularios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            panelFormularios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29F));
            panelFormularios.Controls.Add(panel2, 0, 0);
            panelFormularios.Controls.Add(panel3, 1, 0);
            panelFormularios.Controls.Add(panel5, 2, 0);
            panelFormularios.Controls.Add(panel6, 3, 0);
            panelFormularios.Dock = DockStyle.Top;
            panelFormularios.Location = new Point(0, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.RowCount = 1;
            panelFormularios.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelFormularios.Size = new Size(990, 100);
            panelFormularios.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 94);
            panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 32);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 27);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(151, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 94);
            panel3.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 31);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 4;
            label4.Text = "Nombre:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(428, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 94);
            panel5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(123, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 26);
            label5.Name = "label5";
            label5.Size = new Size(119, 32);
            label5.TabIndex = 6;
            label5.Text = "Dirección:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 192, 128);
            panel6.Controls.Add(textBox5);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(705, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(282, 94);
            panel6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(123, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(145, 23);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 22);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 8;
            label6.Text = "Telefono:";
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 608);
            Controls.Add(panel1);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientes";
            Text = "clientes";
            Load += clientes_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panel1.ResumeLayout(false);
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitulo;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel panelTabla;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel panelFormularios;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Panel panel3;
        private TextBox textBox3;
        private Label label4;
        private Panel panel5;
        private TextBox textBox4;
        private Label label5;
        private Panel panel6;
        private TextBox textBox5;
        private Label label6;
    }
}