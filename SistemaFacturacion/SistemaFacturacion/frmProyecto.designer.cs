namespace SistemaFacturacion
{
    partial class frmProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProyecto));
            this.lblProyecto = new System.Windows.Forms.Label();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.txtAlcance = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.grdProyecto = new System.Windows.Forms.DataGridView();
            this.id_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboIdResponsable = new System.Windows.Forms.ComboBox();
            this.cboIdProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(48, 34);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(74, 13);
            this.lblProyecto.TabIndex = 0;
            this.lblProyecto.Text = "ID Proyecto";
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.BackColor = System.Drawing.Color.OldLace;
            this.txtIdProyecto.Location = new System.Drawing.Point(128, 31);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProyecto.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.OldLace;
            this.txtDescripcion.Location = new System.Drawing.Point(735, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(648, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(48, 82);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(49, 13);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Versión";
            this.lblVersion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.BackColor = System.Drawing.Color.OldLace;
            this.txtVersion.Location = new System.Drawing.Point(128, 80);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 0;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcance.Location = new System.Drawing.Point(329, 82);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(53, 13);
            this.lblAlcance.TabIndex = 6;
            this.lblAlcance.Text = "Alcance";
            // 
            // txtAlcance
            // 
            this.txtAlcance.BackColor = System.Drawing.Color.OldLace;
            this.txtAlcance.Location = new System.Drawing.Point(409, 82);
            this.txtAlcance.Name = "txtAlcance";
            this.txtAlcance.Size = new System.Drawing.Size(121, 20);
            this.txtAlcance.TabIndex = 1;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(642, 33);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(80, 13);
            this.lblResponsable.TabIndex = 9;
            this.lblResponsable.Text = "Responsable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(325, 33);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(58, 13);
            this.lblProducto.TabIndex = 12;
            this.lblProducto.Text = "Producto\r\n";
            // 
            // grdProyecto
            // 
            this.grdProyecto.AllowUserToAddRows = false;
            this.grdProyecto.AllowUserToDeleteRows = false;
            this.grdProyecto.BackgroundColor = System.Drawing.Color.OldLace;
            this.grdProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proyecto,
            this.borrado,
            this.id_producto,
            this.descripcion,
            this.version,
            this.alcance,
            this.id_responsable});
            this.grdProyecto.Location = new System.Drawing.Point(51, 163);
            this.grdProyecto.Name = "grdProyecto";
            this.grdProyecto.ReadOnly = true;
            this.grdProyecto.Size = new System.Drawing.Size(805, 150);
            this.grdProyecto.TabIndex = 13;
            this.grdProyecto.SelectionChanged += new System.EventHandler(this.grdProyecto_SelectionChanged);
            // 
            // id_proyecto
            // 
            this.id_proyecto.DividerWidth = 2;
            this.id_proyecto.HeaderText = "ID Proyecto";
            this.id_proyecto.Name = "id_proyecto";
            this.id_proyecto.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.DividerWidth = 2;
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            // 
            // id_producto
            // 
            this.id_producto.DividerWidth = 2;
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DividerWidth = 2;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // version
            // 
            this.version.DividerWidth = 2;
            this.version.HeaderText = "Version";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            // 
            // alcance
            // 
            this.alcance.DividerWidth = 2;
            this.alcance.HeaderText = "Alcance";
            this.alcance.Name = "alcance";
            this.alcance.ReadOnly = true;
            // 
            // id_responsable
            // 
            this.id_responsable.DividerWidth = 2;
            this.id_responsable.HeaderText = "ID Responsable";
            this.id_responsable.Name = "id_responsable";
            this.id_responsable.ReadOnly = true;
            this.id_responsable.Width = 110;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.OldLace;
            this.btnBorrar.Location = new System.Drawing.Point(669, 384);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.OldLace;
            this.btnCancelar.Location = new System.Drawing.Point(267, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.OldLace;
            this.btnEditar.Location = new System.Drawing.Point(162, 384);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.OldLace;
            this.btnNuevo.Location = new System.Drawing.Point(51, 384);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.OldLace;
            this.btnGrabar.Location = new System.Drawing.Point(455, 384);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.OldLace;
            this.btnSalir.Location = new System.Drawing.Point(781, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboIdResponsable
            // 
            this.cboIdResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdResponsable.FormattingEnabled = true;
            this.cboIdResponsable.Location = new System.Drawing.Point(735, 30);
            this.cboIdResponsable.Name = "cboIdResponsable";
            this.cboIdResponsable.Size = new System.Drawing.Size(121, 21);
            this.cboIdResponsable.TabIndex = 24;
            // 
            // cboIdProducto
            // 
            this.cboIdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdProducto.FormattingEnabled = true;
            this.cboIdProducto.Location = new System.Drawing.Point(409, 30);
            this.cboIdProducto.Name = "cboIdProducto";
            this.cboIdProducto.Size = new System.Drawing.Size(121, 21);
            this.cboIdProducto.TabIndex = 25;
            // 
            // frmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.cboIdProducto);
            this.Controls.Add(this.cboIdResponsable);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.grdProyecto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtAlcance);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.lblProyecto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProyecto";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.frmProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.TextBox txtAlcance;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView grdProyecto;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboIdResponsable;
        private System.Windows.Forms.ComboBox cboIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcance;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_responsable;
    }
}