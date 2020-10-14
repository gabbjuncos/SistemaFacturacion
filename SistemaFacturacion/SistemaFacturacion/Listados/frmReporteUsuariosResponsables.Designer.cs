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
            this.rptUsuarioResponsable = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboUsuarioResponsable = new System.Windows.Forms.ComboBox();
            this.lblUsuarioResponsable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rptUsuarioResponsable
            // 
            this.rptUsuarioResponsable.BackColor = System.Drawing.Color.OldLace;
            this.rptUsuarioResponsable.DocumentMapWidth = 64;
            this.rptUsuarioResponsable.Location = new System.Drawing.Point(38, 161);
            this.rptUsuarioResponsable.Name = "rptUsuarioResponsable";
            this.rptUsuarioResponsable.ServerReport.BearerToken = null;
            this.rptUsuarioResponsable.Size = new System.Drawing.Size(727, 242);
            this.rptUsuarioResponsable.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
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
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rptUsuarioResponsable);
            this.Name = "frmReporteUsuariosResponsables";
            this.Text = "Listado de Responsables de Proyecto";
            this.Load += new System.EventHandler(this.frmReporteUsuariosResponsables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptUsuarioResponsable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboUsuarioResponsable;
        private System.Windows.Forms.Label lblUsuarioResponsable;
    }
}