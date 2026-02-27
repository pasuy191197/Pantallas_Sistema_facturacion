using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Productos
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                errValidacion.SetError(txtNombreProducto, "El nombre del producto es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtNombreProducto, ""); }

            if (cboCategoria.SelectedIndex < 0)
            {
                errValidacion.SetError(cboCategoria, "Seleccione una categoría");
                valido = false;
            }
            else { errValidacion.SetError(cboCategoria, ""); }

            if (string.IsNullOrWhiteSpace(txtCodigoRef.Text))
            {
                errValidacion.SetError(txtCodigoRef, "El código de referencia es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtCodigoRef, ""); }

            if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                errValidacion.SetError(txtPrecioCompra, "El precio de compra es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtPrecioCompra, ""); }

            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                errValidacion.SetError(txtPrecioVenta, "El precio de venta es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtPrecioVenta, ""); }

            if (valido)
            {
                MessageBox.Show("Producto guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {

        }
    }
}