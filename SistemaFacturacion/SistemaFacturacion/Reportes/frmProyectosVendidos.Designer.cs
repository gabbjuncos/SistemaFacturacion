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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyectosVendidos));
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
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(336, 27);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Location = new System.Drawing.Point(336, 73);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(218, 27);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(107, 18);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(645, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rpvEstadisticaProyectosVendidos
            // 
            this.rpvEstadisticaProyectosVendidos.BackColor = System.Drawing.Color.OldLace;
            this.rpvEstadisticaProyectosVendidos.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Reportes.EstadisticasProyectosVendidos.rdlc";
            this.rpvEstadisticaProyectosVendidos.Location = new System.Drawing.Point(12, 147);
            this.rpvEstadisticaProyectosVendidos.Name = "rpvEstadisticaProyectosVendidos";
            this.rpvEstadisticaProyectosVendidos.ServerReport.BearerToken = null;
            this.rpvEstadisticaProyectosVendidos.Size = new System.Drawing.Size(1025, 590);
            this.rpvEstadisticaProyectosVendidos.TabIndex = 5;
            this.rpvEstadisticaProyectosVendidos.Load += new System.EventHandler(this.rpvEstadisticaProyectosVendidos_Load);
            // 
            // frmProyectosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1049, 749);
            this.Controls.Add(this.rpvEstadisticaProyectosVendidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProyectosVendidos";
            this.Text = "Cantidad de proyectos vendidos";
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