using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Categorias
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                errValidacion.SetError(txtNombreCategoria, "El nombre de la categoría es obligatorio");
                valido = false;
            }
            else { errValidacion.SetError(txtNombreCategoria, ""); }

            if (valido)
            {
                MessageBox.Show("Categoría guardada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
