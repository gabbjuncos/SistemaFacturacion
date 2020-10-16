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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteUsuariosResponsables));
            this.dtUsuarioResponsableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPUsuarioResponsable = new SistemaFacturacion.Listados.DSPUsuarioResponsable();
            this.rptUsuarioResponsable = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboUsuarioResponsable = new System.Windows.Forms.ComboBox();
            this.lblUsuarioResponsable = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuarioResponsableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPUsuarioResponsable)).BeginInit();
            this.SuspendLayout();
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
            this.rptUsuarioResponsable.Size = new System.Drawing.Size(1312, 542);
            this.rptUsuarioResponsable.TabIndex = 0;
            this.rptUsuarioResponsable.Load += new System.EventHandler(this.rptUsuarioResponsable_Load);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Location = new System.Drawing.Point(408, 52);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(258, 12);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(102, 18);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha Inicial";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(258, 54);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(95, 18);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha Final";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.OldLace;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(615, 98);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(118, 29);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboUsuarioResponsable
            // 
            this.cboUsuarioResponsable.BackColor = System.Drawing.Color.OldLace;
            this.cboUsuarioResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsuarioResponsable.FormattingEnabled = true;
            this.cboUsuarioResponsable.Location = new System.Drawing.Point(927, 12);
            this.cboUsuarioResponsable.Name = "cboUsuarioResponsable";
            this.cboUsuarioResponsable.Size = new System.Drawing.Size(121, 26);
            this.cboUsuarioResponsable.TabIndex = 6;
            // 
            // lblUsuarioResponsable
            // 
            this.lblUsuarioResponsable.AutoSize = true;
            this.lblUsuarioResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioResponsable.Location = new System.Drawing.Point(702, 15);
            this.lblUsuarioResponsable.Name = "lblUsuarioResponsable";
            this.lblUsuarioResponsable.Size = new System.Drawing.Size(170, 18);
            this.lblUsuarioResponsable.TabIndex = 7;
            this.lblUsuarioResponsable.Text = "Usuario Responsable";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Location = new System.Drawing.Point(408, 12);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaInicial.TabIndex = 1;
            // 
            // frmReporteUsuariosResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblUsuarioResponsable);
            this.Controls.Add(this.cboUsuarioResponsable);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.rptUsuarioResponsable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReporteUsuariosResponsables";
            this.Text = "Listado de Facturaciones por Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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