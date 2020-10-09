namespace SistemaFacturacion.Listados
{
    partial class frmReporteProductos
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
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.rptReporteProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSProductos = new SistemaFacturacion.Listados.DSProductos();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(91, 18);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(80, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Fecha Inicial";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(91, 62);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(73, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Fecha Final";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dtpDesde.Location = new System.Drawing.Point(209, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dtpHasta.Location = new System.Drawing.Point(209, 55);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.OldLace;
            this.btnImprimir.Location = new System.Drawing.Point(529, 33);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Filtrar";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rptReporteProductos
            // 
            this.rptReporteProductos.BackColor = System.Drawing.Color.OldLace;
            reportDataSource1.Name = "DatosListadoProductos";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.rptReporteProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.rptReporteProductos.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Listados.ReporteProductos.rdlc";
            this.rptReporteProductos.Location = new System.Drawing.Point(25, 123);
            this.rptReporteProductos.Name = "rptReporteProductos";
            this.rptReporteProductos.ServerReport.BearerToken = null;
            this.rptReporteProductos.Size = new System.Drawing.Size(763, 315);
            this.rptReporteProductos.TabIndex = 6;
            this.rptReporteProductos.Load += new System.EventHandler(this.rptReporteProductos_Load);
            // 
            // dSProductos
            // 
            this.dSProductos.DataSetName = "DSProductos";
            this.dSProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dSProductos;
            // 
            // frmReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptReporteProductos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Name = "frmReporteProductos";
            this.Text = "frmReporteProductos";
            this.Load += new System.EventHandler(this.frmReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnImprimir;
        private Microsoft.Reporting.WinForms.ReportViewer rptReporteProductos;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DSProductos dSProductos;
    }
}