using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion.Informacion
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            if (cboInforme.SelectedIndex < 0)
            {
                errValidacion.SetError(cboInforme, "Seleccione un tipo de informe");
                valido = false;
            }
            else { errValidacion.SetError(cboInforme, ""); }

            if (dtpFechaInicio.Value > dtpFechaFinal.Value)
            {
                errValidacion.SetError(dtpFechaFinal, "La fecha final debe ser mayor a la fecha inicio");
                valido = false;
            }
            else { errValidacion.SetError(dtpFechaFinal, ""); }

            if (!rdbPantalla.Checked && !rdbPdf.Checked && !rdbExcel.Checked)
            {
                errValidacion.SetError(rdbPantalla, "Seleccione un formato de salida");
                valido = false;
            }
            else { errValidacion.SetError(rdbPantalla, ""); }

            if (valido)
            {
                MessageBox.Show("Informe generado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
