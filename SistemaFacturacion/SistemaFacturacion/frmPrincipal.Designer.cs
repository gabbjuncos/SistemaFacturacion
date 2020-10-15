namespace SistemaFacturacion
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeFacturasPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeProductosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem,
            this.transacciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.proyectosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.barriosToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.soporteToolStripMenuItem.Text = "Registrar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.proyectosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // barriosToolStripMenuItem
            // 
            this.barriosToolStripMenuItem.Name = "barriosToolStripMenuItem";
            this.barriosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.barriosToolStripMenuItem.Text = "Barrios";
            // 
            // transacciónToolStripMenuItem
            // 
            this.transacciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem});
            this.transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            this.transacciónToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.transacciónToolStripMenuItem.Text = "Ventas";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            this.facturaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProductosToolStripMenuItem,
            this.listadoDeProyectosToolStripMenuItem,
            this.listadoDeFacturasPorUsuarioToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de Productos";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // listadoDeProyectosToolStripMenuItem
            // 
            this.listadoDeProyectosToolStripMenuItem.Name = "listadoDeProyectosToolStripMenuItem";
            this.listadoDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDeProyectosToolStripMenuItem.Text = "Listado de Proyectos";
            this.listadoDeProyectosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProyectosToolStripMenuItem_Click);
            // 
            // listadoDeFacturasPorUsuarioToolStripMenuItem
            // 
            this.listadoDeFacturasPorUsuarioToolStripMenuItem.Name = "listadoDeFacturasPorUsuarioToolStripMenuItem";
            this.listadoDeFacturasPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDeFacturasPorUsuarioToolStripMenuItem.Text = "Listado de Facturas";
            this.listadoDeFacturasPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturasPorUsuarioToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosVendidosToolStripMenuItem,
            this.cantidadDeProductosVendidosToolStripMenuItem,
            this.cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // proyectosVendidosToolStripMenuItem
            // 
            this.proyectosVendidosToolStripMenuItem.Name = "proyectosVendidosToolStripMenuItem";
            this.proyectosVendidosToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.proyectosVendidosToolStripMenuItem.Text = "Cantidad de Proyectos Vendidos";
            this.proyectosVendidosToolStripMenuItem.Click += new System.EventHandler(this.proyectosVendidosToolStripMenuItem_Click);
            // 
            // cantidadDeProductosVendidosToolStripMenuItem
            // 
            this.cantidadDeProductosVendidosToolStripMenuItem.Name = "cantidadDeProductosVendidosToolStripMenuItem";
            this.cantidadDeProductosVendidosToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.cantidadDeProductosVendidosToolStripMenuItem.Text = "Cantidad de Productos Vendidos";
            this.cantidadDeProductosVendidosToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeProductosVendidosToolStripMenuItem_Click);
            // 
            // cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem
            // 
            this.cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem.Name = "cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem";
            this.cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            this.cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem.Text = "Cantidad de Ventas de Proyectos por Usuario";
            this.cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeFacturasPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeProductosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeVentasDeProyectosPorUsuarioToolStripMenuItem;
    }
}