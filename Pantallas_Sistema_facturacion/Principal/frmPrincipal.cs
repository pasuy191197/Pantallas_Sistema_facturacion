using System;
using System.Windows.Forms;
using Pantallas_Sistema_facturacion.Clientes;
using Pantallas_Sistema_facturacion.Productos;
using Pantallas_Sistema_facturacion.Categorias;
using Pantallas_Sistema_facturacion.Facturación;
using Pantallas_Sistema_facturacion.Informacion;
using Pantallas_Sistema_facturacion.Roles;
using Pantallas_Sistema_facturacion.Seguridad;

namespace Pantallas_Sistema_facturacion.Principal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // ── Método para cargar formularios en el panel ──
        private void AbrirFormulario(Form formulario)
        {
            formulario.ShowDialog();
        }

        // ── TABLAS ──────────────────────────────────────────────────
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmClientes());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProductos());
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCategoriaProductos());
        }

        // ── FACTURACIÓN ─────────────────────────────────────────────
        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFacturas());
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInformes());
        }

        // ── SEGURIDAD ───────────────────────────────────────────────
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEmpleados());
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRolEmpleados());
        }

        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAdminSeguridad());
        }

        // ── AYUDA ───────────────────────────────────────────────────
        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            ayuda.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acerca = new frmAcercaDe();
            acerca.ShowDialog();
        }

        // ── Eventos existentes ──────────────────────────────────────
        private void mniPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}