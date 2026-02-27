using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Clientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                errValidacion.SetError(txtNombreCliente, "El nombre del cliente es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtNombreCliente, ""); }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                errValidacion.SetError(txtDocumento, "El documento es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtDocumento, ""); }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errValidacion.SetError(txtDireccion, "La dirección es obligatoria");
                valido = false;
            }
            else { errValidacion.SetError(txtDireccion, ""); }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errValidacion.SetError(txtTelefono, "El teléfono es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtTelefono, ""); }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errValidacion.SetError(txtEmail, "El email es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtEmail, ""); }

            if (valido)
            {
                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
        }
    }
}