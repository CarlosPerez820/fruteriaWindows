using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_Fruteria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;

            personalizarDesing();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           // conexion cn = new conexion();
           // cn.pruebaConexion();
        }
    
        private void personalizarDesing()
        {
            panelSubProduct.Visible = false;
        }

        private void SubMenu()
        {
            if (panelSubProduct.Visible == true)
            {
                panelSubProduct.Visible = false;
            }
            else if (panelSubProduct.Visible == false)
            {
                panelSubProduct.Visible = true;
            }

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            SubMenu();
        }
        private void abrirFirmulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelPrincipalWin.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelPrincipalWin.Controls.Add(formulario);
                panelPrincipalWin.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            abrirFirmulario<categorias>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFirmulario<clientes>();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            abrirFirmulario<gastos>();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            abrirFirmulario<dashboard>();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            abrirFirmulario<nuevoProducto>();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFirmulario<ventas>();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            abrirFirmulario<corteCaja>();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFirmulario<inventario>();
        }


    }
}
