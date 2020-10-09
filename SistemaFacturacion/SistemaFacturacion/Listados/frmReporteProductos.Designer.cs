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
            this.DSProductos = new SistemaFacturacion.Listados.DSProductos();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dSProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSProductosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.rptReporteProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DSProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(22, 19);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(80, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Fecha Inicial";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(22, 63);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(73, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Fecha Final";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dtpDesde.Location = new System.Drawing.Point(140, 13);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dtpHasta.Location = new System.Drawing.Point(140, 56);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 4;
            // 
            // DSProductos
            // 
            this.DSProductos.DataSetName = "DSProductos";
            this.DSProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DSProductos;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.OldLace;
            this.btnImprimir.Location = new System.Drawing.Point(357, 415);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dSProductosBindingSource
            // 
            this.dSProductosBindingSource.DataSource = this.DSProductos;
            this.dSProductosBindingSource.Position = 0;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.DSProductos;
            // 
            // dSProductosBindingSource1
            // 
            this.dSProductosBindingSource1.DataSource = this.DSProductos;
            this.dSProductosBindingSource1.Position = 0;
            // 
            // dSProductosBindingSource2
            // 
            this.dSProductosBindingSource2.DataSource = this.DSProductos;
            this.dSProductosBindingSource2.Position = 0;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dSProductosBindingSource;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dSProductosBindingSource;
            // 
            // rptReporteProductos
            // 
            this.rptReporteProductos.BackColor = System.Drawing.Color.OldLace;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rptReporteProductos.LocalReport.DataSources.Add(reportDataSource1);
            this.rptReporteProductos.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Listados.ReporteProductos.rdlc";
            this.rptReporteProductos.Location = new System.Drawing.Point(25, 121);
            this.rptReporteProductos.Name = "rptReporteProductos";
            this.rptReporteProductos.ServerReport.BearerToken = null;
            this.rptReporteProductos.Size = new System.Drawing.Size(731, 246);
            this.rptReporteProductos.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.DSProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DSProductos DSProductos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource dSProductosBindingSource1;
        private System.Windows.Forms.BindingSource dSProductosBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource dSProductosBindingSource2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private Microsoft.Reporting.WinForms.ReportViewer rptReporteProductos;
    }
}