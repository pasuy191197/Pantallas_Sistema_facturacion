namespace Pantallas_Sistema_facturacion.Informacion
{
    partial class frmAcercaDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesarrollador = new System.Windows.Forms.Label();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.lblDescripcionTitulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlInfo.Controls.Add(this.lblTitulo);
            this.pnlInfo.Controls.Add(this.lblVersion);
            this.pnlInfo.Controls.Add(this.lblDesarrollador);
            this.pnlInfo.Controls.Add(this.lblInstitucion);
            this.pnlInfo.Controls.Add(this.lblDescripcionTitulo);
            this.pnlInfo.Controls.Add(this.txtDescripcion);
            this.pnlInfo.Controls.Add(this.btnAceptar);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(500, 380);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(80, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(373, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ACERCA DEL SISTEMA DE FACTURACIÓN";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVersion.Location = new System.Drawing.Point(20, 70);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(98, 19);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Versión: 1.0.0";
            // 
            // lblDesarrollador
            // 
            this.lblDesarrollador.AutoSize = true;
            this.lblDesarrollador.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDesarrollador.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDesarrollador.Location = new System.Drawing.Point(20, 100);
            this.lblDesarrollador.Name = "lblDesarrollador";
            this.lblDesarrollador.Size = new System.Drawing.Size(344, 19);
            this.lblDesarrollador.TabIndex = 2;
            this.lblDesarrollador.Text = "Desarrollado por: Jonathan David Pasuy Gonzalez";
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstitucion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInstitucion.Location = new System.Drawing.Point(20, 130);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(310, 19);
            this.lblInstitucion.TabIndex = 3;
            this.lblInstitucion.Text = "Institución Universitaria Pascual Bravo - 2026";
            // 
            // lblDescripcionTitulo
            // 
            this.lblDescripcionTitulo.AutoSize = true;
            this.lblDescripcionTitulo.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDescripcionTitulo.Location = new System.Drawing.Point(20, 170);
            this.lblDescripcionTitulo.Name = "lblDescripcionTitulo";
            this.lblDescripcionTitulo.Size = new System.Drawing.Size(91, 19);
            this.lblDescripcionTitulo.TabIndex = 4;
            this.lblDescripcionTitulo.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(20, 195);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(460, 100);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Text = resources.GetString("txtDescripcion.Text");
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(195, 320);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 34);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de - Sistema de Facturación";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesarrollador;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.Label lblDescripcionTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;

        private System.Windows.Forms.Label label1;
    }
}