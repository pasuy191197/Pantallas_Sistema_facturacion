using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Seguridad
{
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (cboEmpleado.SelectedIndex < 0)
            {
                errValidacion.SetError(cboEmpleado, "Seleccione un empleado");
                valido = false;
            }
            else { errValidacion.SetError(cboEmpleado, ""); }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errValidacion.SetError(textBox1, "El usuario es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(textBox1, ""); }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errValidacion.SetError(textBox2, "La clave es obligatoria");
                valido = false;
            }
            else { errValidacion.SetError(textBox2, ""); }

            if (valido)
            {
                MessageBox.Show("Usuario del sistema guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}