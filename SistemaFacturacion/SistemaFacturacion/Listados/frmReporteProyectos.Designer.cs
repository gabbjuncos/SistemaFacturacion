namespace SistemaFacturacion.Listados
{
    partial class frmReporteProyectos
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
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DSPProyectos = new SistemaFacturacion.Listados.DSPProyectos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFecheDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPProyectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPProyectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.DSPProyectos;
            // 
            // DSPProyectos
            // 
            this.DSPProyectos.DataSetName = "DSPProyectos";
            this.DSPProyectos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ListadoProyectos";
            reportDataSource1.Value = this.dSPProyectosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Listados.ReporteProyectos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(126, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(470, 262);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dtpFecheDesde
            // 
            this.dtpFecheDesde.Location = new System.Drawing.Point(126, 27);
            this.dtpFecheDesde.Name = "dtpFecheDesde";
            this.dtpFecheDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFecheDesde.TabIndex = 1;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(486, 27);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(400, 27);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(68, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(39, 27);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 4;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(634, 84);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DSPProyectos;
            // 
            // dSPProyectosBindingSource
            // 
            this.dSPProyectosBindingSource.DataSource = this.DSPProyectos;
            this.dSPProyectosBindingSource.Position = 0;
            // 
            // frmReporteProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFecheDesde);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteProyectos";
            this.Text = "Listado de Proyectos";
            this.Load += new System.EventHandler(this.frmReporteProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPProyectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DSPProyectos DSPProyectos;
        private System.Windows.Forms.DateTimePicker dtpFecheDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource dSPProyectosBindingSource;
    }
}