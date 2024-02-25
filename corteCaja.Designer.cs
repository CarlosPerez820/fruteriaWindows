namespace Sistema_Fruteria
{
    partial class corteCaja
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
            dataGridView1 = new DataGridView();
            panel11 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            label5 = new Label();
            panel8 = new Panel();
            label6 = new Label();
            panel9 = new Panel();
            label7 = new Label();
            panel10 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            panel5 = new Panel();
            dateTimePicker3 = new DateTimePicker();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            panelTitulo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel11.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(990, 53);
            panelTitulo.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(407, 4);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 0;
            label1.Text = "Corte de Caja";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 555);
            panel1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(990, 268);
            dataGridView1.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(192, 255, 255);
            panel11.Controls.Add(label9);
            panel11.Controls.Add(label8);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 420);
            panel11.Name = "panel11";
            panel11.Size = new Size(990, 135);
            panel11.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(255, 128, 128);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 241F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 0);
            tableLayoutPanel2.Controls.Add(panel8, 1, 0);
            tableLayoutPanel2.Controls.Add(panel9, 2, 0);
            tableLayoutPanel2.Controls.Add(panel10, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 103);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(990, 49);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 192, 255);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(248, 43);
            panel7.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 10);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 0;
            label5.Text = "Total Vendido";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 255, 255);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(257, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(248, 43);
            panel8.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 10);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 1;
            label6.Text = "Total Vendido";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(255, 192, 255);
            panel9.Controls.Add(label7);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(511, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(235, 43);
            panel9.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 10);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 2;
            label7.Text = "Total Vendido";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(255, 192, 192);
            panel10.Controls.Add(button2);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(752, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(235, 43);
            panel10.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(79, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 36);
            button2.TabIndex = 1;
            button2.Text = "Generar PDF";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 255);
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 52);
            panel6.Name = "panel6";
            panel6.Size = new Size(990, 51);
            panel6.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(831, 6);
            button1.Name = "button1";
            button1.Size = new Size(114, 42);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 255, 255);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.9854F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.0146F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 258F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(990, 52);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(255, 224, 192);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 46);
            panel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(80, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 14);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 0;
            label2.Text = "Fecha";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Controls.Add(comboBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(236, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 46);
            panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(68, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 23);
            comboBox1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(509, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 46);
            panel4.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(90, 14);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(129, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(34, 13);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 2;
            label3.Text = "Inicio:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 192, 255);
            panel5.Controls.Add(dateTimePicker3);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(767, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 46);
            panel5.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(49, 14);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(129, 23);
            dateTimePicker3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 13);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 3;
            label4.Text = "Fin:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 25);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 0;
            label8.Text = "Productos Vendidos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(779, 25);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 1;
            label9.Text = "Ventas por categoria";
            // 
            // corteCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 608);
            Controls.Add(panel1);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "corteCaja";
            Text = "corteCaja";
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel10;
        private Button button2;
        private Panel panel11;
        private DataGridView dataGridView1;
        private Label label9;
        private Label label8;
    }
}