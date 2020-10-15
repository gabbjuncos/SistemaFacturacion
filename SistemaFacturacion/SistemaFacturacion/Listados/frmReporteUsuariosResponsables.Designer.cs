namespace SistemaFacturacion.Listados
{
    partial class frmReporteUsuariosResponsables
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptUsuarioResponsable = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboUsuarioResponsable = new System.Windows.Forms.ComboBox();
            this.lblUsuarioResponsable = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtUsuarioResponsableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPUsuarioResponsable = new SistemaFacturacion.Listados.DSPUsuarioResponsable();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarioResponsableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPUsuarioResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // rptUsuarioResponsable
            // 
            this.rptUsuarioResponsable.BackColor = System.Drawing.Color.OldLace;
            this.rptUsuarioResponsable.DocumentMapWidth = 64;
            reportDataSource1.Name = "ListadoUsuariosResponsables";
            reportDataSource1.Value = this.dtUsuarioResponsableBindingSource;
            this.rptUsuarioResponsable.LocalReport.DataSources.Add(reportDataSource1);
            this.rptUsuarioResponsable.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Listados.ReporteUsuariosResponsables.rdlc";
            this.rptUsuarioResponsable.Location = new System.Drawing.Point(38, 161);
            this.rptUsuarioResponsable.Name = "rptUsuarioResponsable";
            this.rptUsuarioResponsable.ServerReport.BearerToken = null;
            this.rptUsuarioResponsable.Size = new System.Drawing.Size(727, 242);
            this.rptUsuarioResponsable.TabIndex = 0;
            this.rptUsuarioResponsable.Load += new System.EventHandler(this.rptUsuarioResponsable_Load);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(135, 57);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(45, 21);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(67, 13);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha Inicial";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(50, 64);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(62, 13);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha Final";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.OldLace;
            this.btnFiltrar.Location = new System.Drawing.Point(364, 110);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboUsuarioResponsable
            // 
            this.cboUsuarioResponsable.BackColor = System.Drawing.Color.OldLace;
            this.cboUsuarioResponsable.FormattingEnabled = true;
            this.cboUsuarioResponsable.Location = new System.Drawing.Point(644, 21);
            this.cboUsuarioResponsable.Name = "cboUsuarioResponsable";
            this.cboUsuarioResponsable.Size = new System.Drawing.Size(121, 21);
            this.cboUsuarioResponsable.TabIndex = 6;
            // 
            // lblUsuarioResponsable
            // 
            this.lblUsuarioResponsable.AutoSize = true;
            this.lblUsuarioResponsable.Location = new System.Drawing.Point(489, 24);
            this.lblUsuarioResponsable.Name = "lblUsuarioResponsable";
            this.lblUsuarioResponsable.Size = new System.Drawing.Size(108, 13);
            this.lblUsuarioResponsable.TabIndex = 7;
            this.lblUsuarioResponsable.Text = "Usuario Responsable";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(135, 17);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 1;
            // 
            // dtUsuarioResponsableBindingSource
            // 
            this.dtUsuarioResponsableBindingSource.DataMember = "dtUsuarioResponsable";
            this.dtUsuarioResponsableBindingSource.DataSource = this.DSPUsuarioResponsable;
            // 
            // DSPUsuarioResponsable
            // 
            this.DSPUsuarioResponsable.DataSetName = "DSPUsuarioResponsable";
            this.DSPUsuarioResponsable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReporteUsuariosResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuarioResponsable);
            this.Controls.Add(this.cboUsuarioResponsable);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.rptUsuarioResponsable);
            this.Name = "frmReporteUsuariosResponsables";
            this.Text = "Listado de Facturaciones por Usuario";
            this.Load += new System.EventHandler(this.frmReporteUsuariosResponsables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarioResponsableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPUsuarioResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptUsuarioResponsable;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboUsuarioResponsable;
        private System.Windows.Forms.Label lblUsuarioResponsable;
        private System.Windows.Forms.BindingSource dtUsuarioResponsableBindingSource;
        private DSPUsuarioResponsable DSPUsuarioResponsable;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
    }
}