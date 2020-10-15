namespace SistemaFacturacion.Reportes
{
    partial class frmProyectosVendidos
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
            this.dtProyectosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPProyectosVendidos = new SistemaFacturacion.Reportes.DSPProyectosVendidos();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rpvEstadisticaProyectosVendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtProyectosVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPProyectosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProyectosVendidosBindingSource
            // 
            this.dtProyectosVendidosBindingSource.DataMember = "dtProyectosVendidos";
            this.dtProyectosVendidosBindingSource.DataSource = this.DSPProyectosVendidos;
            // 
            // DSPProyectosVendidos
            // 
            this.DSPProyectosVendidos.DataSetName = "DSPProyectosVendidos";
            this.DSPProyectosVendidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(179, 33);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(179, 79);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(61, 33);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(71, 13);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rpvEstadisticaProyectosVendidos
            // 
            this.rpvEstadisticaProyectosVendidos.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Reportes.EstadisticasProyectosVendidos.rdlc";
            this.rpvEstadisticaProyectosVendidos.Location = new System.Drawing.Point(12, 147);
            this.rpvEstadisticaProyectosVendidos.Name = "rpvEstadisticaProyectosVendidos";
            this.rpvEstadisticaProyectosVendidos.ServerReport.BearerToken = null;
            this.rpvEstadisticaProyectosVendidos.Size = new System.Drawing.Size(988, 406);
            this.rpvEstadisticaProyectosVendidos.TabIndex = 5;
            this.rpvEstadisticaProyectosVendidos.Load += new System.EventHandler(this.rpvEstadisticaProyectosVendidos_Load);
            // 
            // frmProyectosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 565);
            this.Controls.Add(this.rpvEstadisticaProyectosVendidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "frmProyectosVendidos";
            this.Text = "Estadistica cantidad de proyectos vendidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProyectosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProyectosVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPProyectosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEstadisticaProyectosVendidos;
        private System.Windows.Forms.BindingSource dtProyectosVendidosBindingSource;
        private DSPProyectosVendidos DSPProyectosVendidos;
    }
}