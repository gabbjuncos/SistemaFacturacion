namespace SistemaFacturacion.Reportes
{
    partial class frmUsuarioProductosVendidos
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSUsuarioProductoVendidos = new SistemaFacturacion.Reportes.DSUsuarioProductoVendidos();
            this.rptUsuarioProductosVendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSUsuarioProductoVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DSUsuarioProductoVendidos;
            // 
            // DSUsuarioProductoVendidos
            // 
            this.DSUsuarioProductoVendidos.DataSetName = "DSUsuarioProductoVendidos";
            this.DSUsuarioProductoVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptUsuarioProductosVendidos
            // 
            reportDataSource1.Name = "DSUsuarioProductosVendidos";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rptUsuarioProductosVendidos.LocalReport.DataSources.Add(reportDataSource1);
            this.rptUsuarioProductosVendidos.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Reportes.EstadisticasUsuarioProductosVendidos.rdlc";
            this.rptUsuarioProductosVendidos.Location = new System.Drawing.Point(21, 161);
            this.rptUsuarioProductosVendidos.Name = "rptUsuarioProductosVendidos";
            this.rptUsuarioProductosVendidos.ServerReport.BearerToken = null;
            this.rptUsuarioProductosVendidos.Size = new System.Drawing.Size(742, 246);
            this.rptUsuarioProductosVendidos.TabIndex = 0;
            this.rptUsuarioProductosVendidos.Load += new System.EventHandler(this.rptUsuarioProductosVendidos_Load);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(125, 23);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 1;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(125, 83);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(18, 30);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(67, 13);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha Inicial";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(18, 89);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(62, 13);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha Final";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(417, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(141, 25);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmUsuarioProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.rptUsuarioProductosVendidos);
            this.Name = "frmUsuarioProductosVendidos";
            this.Text = "Venta de Productos por Usuario";
            this.Load += new System.EventHandler(this.frmUsuarioProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSUsuarioProductoVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptUsuarioProductosVendidos;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Reportes.DSUsuarioProductoVendidos DSUsuarioProductoVendidos;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Button btnFiltrar;
    }
}