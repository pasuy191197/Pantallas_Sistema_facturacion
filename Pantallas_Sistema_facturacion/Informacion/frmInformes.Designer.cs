namespace Pantallas_Sistema_facturacion.Informacion
{
    partial class frmInformes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExcel = new System.Windows.Forms.RadioButton();
            this.rdbPdf = new System.Windows.Forms.RadioButton();
            this.rdbPantalla = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboInforme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pnlVistaPrevia = new System.Windows.Forms.Panel();
            this.errValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(211, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExcel);
            this.groupBox1.Controls.Add(this.rdbPdf);
            this.groupBox1.Controls.Add(this.rdbPantalla);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboInforme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 183);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Location = new System.Drawing.Point(378, 142);
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Size = new System.Drawing.Size(51, 17);
            this.rdbExcel.TabIndex = 38;
            this.rdbExcel.TabStop = true;
            this.rdbExcel.Text = "Excel";
            this.rdbExcel.UseVisualStyleBackColor = true;
            // 
            // rdbPdf
            // 
            this.rdbPdf.AutoSize = true;
            this.rdbPdf.Location = new System.Drawing.Point(297, 142);
            this.rdbPdf.Name = "rdbPdf";
            this.rdbPdf.Size = new System.Drawing.Size(46, 17);
            this.rdbPdf.TabIndex = 37;
            this.rdbPdf.TabStop = true;
            this.rdbPdf.Text = "PDF";
            this.rdbPdf.UseVisualStyleBackColor = true;
            // 
            // rdbPantalla
            // 
            this.rdbPantalla.AutoSize = true;
            this.rdbPantalla.Location = new System.Drawing.Point(179, 142);
            this.rdbPantalla.Name = "rdbPantalla";
            this.rdbPantalla.Size = new System.Drawing.Size(79, 17);
            this.rdbPantalla.TabIndex = 36;
            this.rdbPantalla.TabStop = true;
            this.rdbPantalla.Text = "En Pantalla";
            this.rdbPantalla.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(442, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "&Ordenar por:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(481, 78);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaFinal.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(363, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "&Fecha Final:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(234, 78);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(87, 20);
            this.dtpFechaInicio.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(25, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "&SELECCIONE INFORME";
            // 
            // cboInforme
            // 
            this.cboInforme.FormattingEnabled = true;
            this.cboInforme.Location = new System.Drawing.Point(208, 34);
            this.cboInforme.Name = "cboInforme";
            this.cboInforme.Size = new System.Drawing.Size(201, 21);
            this.cboInforme.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(115, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "&Fecha Inicio:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(401, 286);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 34);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValidar.Location = new System.Drawing.Point(220, 286);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(135, 34);
            this.btnValidar.TabIndex = 37;
            this.btnValidar.Text = "GENERAR INFORME";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // pnlVistaPrevia
            // 
            this.pnlVistaPrevia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlVistaPrevia.Location = new System.Drawing.Point(41, 354);
            this.pnlVistaPrevia.Name = "pnlVistaPrevia";
            this.pnlVistaPrevia.Size = new System.Drawing.Size(684, 140);
            this.pnlVistaPrevia.TabIndex = 39;
            // 
            // errValidacion
            // 
            this.errValidacion.ContainerControl = this;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 521);
            this.Controls.Add(this.pnlVistaPrevia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboInforme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbExcel;
        private System.Windows.Forms.RadioButton rdbPdf;
        private System.Windows.Forms.RadioButton rdbPantalla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Panel pnlVistaPrevia;
        private System.Windows.Forms.ErrorProvider errValidacion;
    }
}