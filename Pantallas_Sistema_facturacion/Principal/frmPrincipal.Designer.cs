namespace Pantallas_Sistema_facturacion.Principal
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mniPrincipal = new System.Windows.Forms.MenuStrip();
            this.pRINCIPALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tABLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEGURIDADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            this.mniPrincipal.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Controls.Add(this.mniPrincipal);
            this.pnlSuperior.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSuperior.Location = new System.Drawing.Point(1, -1);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(793, 56);
            this.pnlSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // mniPrincipal
            // 
            this.mniPrincipal.AutoSize = false;
            this.mniPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.mniPrincipal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRINCIPALToolStripMenuItem,
            this.tABLASToolStripMenuItem,
            this.fACTURACIÓNToolStripMenuItem,
            this.sEGURIDADToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.mniPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mniPrincipal.Location = new System.Drawing.Point(230, 0);
            this.mniPrincipal.Name = "mniPrincipal";
            this.mniPrincipal.Size = new System.Drawing.Size(563, 56);
            this.mniPrincipal.TabIndex = 1;
            this.mniPrincipal.Text = "menuStrip1";
            this.mniPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mniPrincipal_ItemClicked);
            // 
            // pRINCIPALToolStripMenuItem
            // 
            this.pRINCIPALToolStripMenuItem.Name = "pRINCIPALToolStripMenuItem";
            this.pRINCIPALToolStripMenuItem.Size = new System.Drawing.Size(97, 52);
            this.pRINCIPALToolStripMenuItem.Text = "PRINCIPAL";
            // 
            // tABLASToolStripMenuItem
            // 
            this.tABLASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.categoríasToolStripMenuItem});
            this.tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            this.tABLASToolStripMenuItem.Size = new System.Drawing.Size(75, 52);
            this.tABLASToolStripMenuItem.Text = "TABLAS";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.productosToolStripMenuItem.Text = "&Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.categoríasToolStripMenuItem.Text = "&Categorías";
            this.categoríasToolStripMenuItem.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // fACTURACIÓNToolStripMenuItem
            // 
            this.fACTURACIÓNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.fACTURACIÓNToolStripMenuItem.Name = "fACTURACIÓNToolStripMenuItem";
            this.fACTURACIÓNToolStripMenuItem.Size = new System.Drawing.Size(126, 52);
            this.fACTURACIÓNToolStripMenuItem.Text = "FACTURACIÓN";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.facturasToolStripMenuItem.Text = "&Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.informesToolStripMenuItem.Text = "&Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // sEGURIDADToolStripMenuItem
            // 
            this.sEGURIDADToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.sEGURIDADToolStripMenuItem.Name = "sEGURIDADToolStripMenuItem";
            this.sEGURIDADToolStripMenuItem.Size = new System.Drawing.Size(107, 52);
            this.sEGURIDADToolStripMenuItem.Text = "SEGURIDAD";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.empleadosToolStripMenuItem.Text = "&Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.rolesToolStripMenuItem.Text = "&Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.administraciónToolStripMenuItem.Text = "&Administración";
            this.administraciónToolStripMenuItem.Click += new System.EventHandler(this.administraciónToolStripMenuItem_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(72, 52);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.ayudaToolStripMenuItem1.Text = "&Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlContenedor.Location = new System.Drawing.Point(-8, 55);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(223, 394);
            this.pnlContenedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALIR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_Sistema_facturacion.Properties.Resources.salirPrincipal;
            this.pictureBox1.Location = new System.Drawing.Point(47, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 109);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mniPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Facturación";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.mniPrincipal.ResumeLayout(false);
            this.mniPrincipal.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mniPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem pRINCIPALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tABLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEGURIDADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}