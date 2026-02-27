using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                errValidacion.SetError(txtNombreEmpleado, "El nombre del empleado es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtNombreEmpleado, ""); }

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

            if (cboRolEmpleado.SelectedIndex < 0)
            {
                errValidacion.SetError(cboRolEmpleado, "Seleccione un rol para el empleado");
                valido = false;
            }
            else { errValidacion.SetError(cboRolEmpleado, ""); }

            if (valido)
            {
                MessageBox.Show("Empleado guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}