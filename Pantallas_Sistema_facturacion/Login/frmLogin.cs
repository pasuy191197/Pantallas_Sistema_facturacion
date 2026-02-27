using Pantallas_Sistema_facturacion.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            errValidacion.SetError(txtClave, "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errValidacion.SetError(txtUsuario, "Ingrese el usuario");
                valido = false;
            }
            else { errValidacion.SetError(txtUsuario, ""); }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                errValidacion.SetError(txtClave, "Ingrese la contraseña");
                valido = false;
            }
            else { errValidacion.SetError(txtClave, ""); }

            if (valido)
            {
                if (txtUsuario.Text == "admin" && txtClave.Text == "123")
                {
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    errValidacion.SetError(txtClave, "Usuario o contraseña incorrectos");
                    MessageBox.Show("Credenciales incorrectas.", "Error de acceso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}

