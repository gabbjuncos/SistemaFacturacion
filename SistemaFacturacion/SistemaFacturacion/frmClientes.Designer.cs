namespace SistemaFacturacion.Formularios
{
    partial class frmClientes
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
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtIdBarrio = new System.Windows.Forms.TextBox();
            this.lblIdBarrio = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblIdContacto = new System.Windows.Forms.Label();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(222, 32);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "Cuit";
            this.lblCuit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(437, 33);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(870, 79);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 3;
            this.btnConsultarCliente.Text = "Buscar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(276, 30);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 4;
            this.txtCuit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(529, 32);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.borrado,
            this.id_barrio,
            this.cuit,
            this.razon_social,
            this.calle,
            this.numero,
            this.fecha_alta,
            this.id_contacto});
            this.grdClientes.Location = new System.Drawing.Point(28, 146);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.Size = new System.Drawing.Size(946, 150);
            this.grdClientes.TabIndex = 6;
            this.grdClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grdClientes.SelectionChanged += new System.EventHandler(this.grdClientes_SelectionChanged);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Id Cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            // 
            // id_barrio
            // 
            this.id_barrio.HeaderText = "Id Barrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "Cuit";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razon Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // fecha_alta
            // 
            this.fecha_alta.HeaderText = "Fecha Alta";
            this.fecha_alta.Name = "fecha_alta";
            this.fecha_alta.ReadOnly = true;
            // 
            // id_contacto
            // 
            this.id_contacto.HeaderText = "Id Contacto";
            this.id_contacto.Name = "id_contacto";
            this.id_contacto.ReadOnly = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(35, 322);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(135, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(225, 322);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(38, 32);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "ID Cliente";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(97, 29);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 11;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(97, 77);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 12;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(276, 79);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // txtIdBarrio
            // 
            this.txtIdBarrio.Location = new System.Drawing.Point(529, 77);
            this.txtIdBarrio.Name = "txtIdBarrio";
            this.txtIdBarrio.Size = new System.Drawing.Size(100, 20);
            this.txtIdBarrio.TabIndex = 14;
            // 
            // lblIdBarrio
            // 
            this.lblIdBarrio.AutoSize = true;
            this.lblIdBarrio.Location = new System.Drawing.Point(437, 79);
            this.lblIdBarrio.Name = "lblIdBarrio";
            this.lblIdBarrio.Size = new System.Drawing.Size(48, 13);
            this.lblIdBarrio.TabIndex = 15;
            this.lblIdBarrio.Text = "ID Barrio";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(38, 79);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 16;
            this.lblCalle.Text = "Calle";
            this.lblCalle.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(222, 84);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "Numero";
            this.lblNumero.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblIdContacto
            // 
            this.lblIdContacto.AutoSize = true;
            this.lblIdContacto.Location = new System.Drawing.Point(667, 83);
            this.lblIdContacto.Name = "lblIdContacto";
            this.lblIdContacto.Size = new System.Drawing.Size(64, 13);
            this.lblIdContacto.TabIndex = 18;
            this.lblIdContacto.Text = "ID Contacto";
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(737, 78);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(100, 20);
            this.txtIdContacto.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(432, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(336, 322);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 22;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.lblIdContacto);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblIdBarrio);
            this.Controls.Add(this.txtIdBarrio);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdClientes);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblCuit);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtIdBarrio;
        private System.Windows.Forms.Label lblIdBarrio;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblIdContacto;
        private System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_contacto;
        private System.Windows.Forms.Label label1;
    }
}