using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Roles
{
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                errValidacion.SetError(txtNombreRol, "El nombre del rol es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtNombreRol, ""); }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errValidacion.SetError(textBox1, "La descripción del rol es obligatoria");
                valido = false;
            }
            else { errValidacion.SetError(textBox1, ""); }

            if (valido)
            {
                MessageBox.Show("Rol guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}