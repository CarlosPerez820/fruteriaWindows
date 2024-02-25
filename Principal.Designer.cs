namespace Sistema_Fruteria
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panelMenu = new Panel();
            btnCorte = new Button();
            btnGastos = new Button();
            btnCategorias = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            panelSubProduct = new Panel();
            btnNuevo = new Button();
            btnInventario = new Button();
            btnDashboard = new Button();
            panelIMG = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipalWin = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btnProductos = new Button();
            panelMenu.SuspendLayout();
            panelSubProduct.SuspendLayout();
            panelIMG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipalWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btnCorte);
            panelMenu.Controls.Add(btnGastos);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(panelSubProduct);
            panelMenu.Controls.Add(btnInventario);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelIMG);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(190, 609);
            panelMenu.TabIndex = 0;
            // 
            // btnCorte
            // 
            btnCorte.Dock = DockStyle.Top;
            btnCorte.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCorte.Location = new Point(0, 561);
            btnCorte.Name = "btnCorte";
            btnCorte.Padding = new Padding(10, 0, 0, 0);
            btnCorte.Size = new Size(173, 55);
            btnCorte.TabIndex = 9;
            btnCorte.Text = "Corte";
            btnCorte.TextAlign = ContentAlignment.MiddleLeft;
            btnCorte.UseVisualStyleBackColor = true;
            btnCorte.Click += btnCorte_Click;
            // 
            // btnGastos
            // 
            btnGastos.Dock = DockStyle.Top;
            btnGastos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGastos.Location = new Point(0, 506);
            btnGastos.Name = "btnGastos";
            btnGastos.Padding = new Padding(10, 0, 0, 0);
            btnGastos.Size = new Size(173, 55);
            btnGastos.TabIndex = 8;
            btnGastos.Text = "Gastos";
            btnGastos.TextAlign = ContentAlignment.MiddleLeft;
            btnGastos.UseVisualStyleBackColor = true;
            btnGastos.Click += btnGastos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Dock = DockStyle.Top;
            btnCategorias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategorias.Location = new Point(0, 451);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Padding = new Padding(10, 0, 0, 0);
            btnCategorias.Size = new Size(173, 55);
            btnCategorias.TabIndex = 7;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.Location = new Point(0, 396);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 0, 0);
            btnClientes.Size = new Size(173, 55);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.Location = new Point(0, 341);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 0, 0);
            btnVentas.Size = new Size(173, 55);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // panelSubProduct
            // 
            panelSubProduct.BackColor = Color.DimGray;
            panelSubProduct.Controls.Add(btnProductos);
            panelSubProduct.Controls.Add(btnNuevo);
            panelSubProduct.Dock = DockStyle.Top;
            panelSubProduct.Location = new Point(0, 231);
            panelSubProduct.Name = "panelSubProduct";
            panelSubProduct.Size = new Size(173, 110);
            panelSubProduct.TabIndex = 4;
            // 
            // btnNuevo
            // 
            btnNuevo.Dock = DockStyle.Top;
            btnNuevo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(0, 0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(25, 0, 0, 0);
            btnNuevo.Size = new Size(173, 55);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo Producto";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInventario.Location = new Point(0, 176);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(10, 0, 0, 0);
            btnInventario.Size = new Size(173, 55);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.Location = new Point(0, 121);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(173, 55);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelIMG
            // 
            panelIMG.Controls.Add(pictureBox1);
            panelIMG.Dock = DockStyle.Top;
            panelIMG.Location = new Point(0, 0);
            panelIMG.Name = "panelIMG";
            panelIMG.Size = new Size(173, 121);
            panelIMG.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipalWin
            // 
            panelPrincipalWin.AutoScroll = true;
            panelPrincipalWin.BackColor = Color.Transparent;
            panelPrincipalWin.Controls.Add(label1);
            panelPrincipalWin.Controls.Add(label2);
            panelPrincipalWin.Controls.Add(pictureBox2);
            panelPrincipalWin.Dock = DockStyle.Fill;
            panelPrincipalWin.Location = new Point(190, 0);
            panelPrincipalWin.Name = "panelPrincipalWin";
            panelPrincipalWin.Size = new Size(990, 609);
            panelPrincipalWin.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(92, 492);
            label1.Name = "label1";
            label1.Size = new Size(760, 43);
            label1.TabIndex = 8;
            label1.Text = "Bienvenido a tu sistema  para fruteria";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(342, 21);
            label2.Name = "label2";
            label2.Size = new Size(330, 43);
            label2.TabIndex = 7;
            label2.Text = "Fruteria Atlixco";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(267, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(474, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.Location = new Point(0, 55);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(25, 0, 0, 0);
            btnProductos.Size = new Size(173, 55);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Lista Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(165, 214, 167);
            ClientSize = new Size(1180, 609);
            Controls.Add(panelPrincipalWin);
            Controls.Add(panelMenu);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            panelMenu.ResumeLayout(false);
            panelSubProduct.ResumeLayout(false);
            panelIMG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipalWin.ResumeLayout(false);
            panelPrincipalWin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnDashboard;
        private Panel panelIMG;
        private PictureBox pictureBox1;
        private Button btnInventario;
        private Panel panelSubProduct;
        private Button btnNuevo;
        private Button btnVentas;
        private Button btnGastos;
        private Button btnCategorias;
        private Button btnClientes;
        private Panel panelPrincipalWin;
        private Button btnCorte;
        public PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Button btnProductos;
    }
}