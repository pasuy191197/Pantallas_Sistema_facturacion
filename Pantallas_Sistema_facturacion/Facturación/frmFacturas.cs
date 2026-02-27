using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Facturación
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNroFactura.Text))
            {
                errValidacion.SetError(txtNroFactura, "El número de factura es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtNroFactura, ""); }

            if (cboCliente.SelectedIndex < 0)
            {
                errValidacion.SetError(cboCliente, "Seleccione un cliente");
                valido = false;
            }
            else { errValidacion.SetError(cboCliente, ""); }

            if (cboEmpleado.SelectedIndex < 0)
            {
                errValidacion.SetError(cboEmpleado, "Seleccione un empleado");
                valido = false;
            }
            else { errValidacion.SetError(cboEmpleado, ""); }

            if (cboEstadoFactura.SelectedIndex < 0)
            {
                errValidacion.SetError(cboEstadoFactura, "Seleccione el estado de la factura");
                valido = false;
            }
            else { errValidacion.SetError(cboEstadoFactura, ""); }

            if (string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                errValidacion.SetError(txtDescuento, "El descuento es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtDescuento, ""); }

            if (valido)
            {
                MessageBox.Show("Factura guardada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}