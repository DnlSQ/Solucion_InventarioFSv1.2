
namespace UX_InventarioFS
{
    partial class frmMenu
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
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeOrdenDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockExistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.auditoriasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.crearUsuarioToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registroToolStripMenuItem.Text = "Registro de Empleados";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProductoToolStripMenuItem,
            this.registroDeProveedoresToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // registroDeProductoToolStripMenuItem
            // 
            this.registroDeProductoToolStripMenuItem.Name = "registroDeProductoToolStripMenuItem";
            this.registroDeProductoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.registroDeProductoToolStripMenuItem.Text = "Registro de Producto";
            this.registroDeProductoToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductoToolStripMenuItem_Click);
            // 
            // registroDeProveedoresToolStripMenuItem
            // 
            this.registroDeProveedoresToolStripMenuItem.Name = "registroDeProveedoresToolStripMenuItem";
            this.registroDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.registroDeProveedoresToolStripMenuItem.Text = "Registro de Proveedores";
            this.registroDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.registroDeProveedoresToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeCompraToolStripMenuItem,
            this.detalleDeOrdenDeCompraToolStripMenuItem,
            this.ordenDeVentaToolStripMenuItem,
            this.detalleDeOrdenDeVentaToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // ordenDeCompraToolStripMenuItem
            // 
            this.ordenDeCompraToolStripMenuItem.Name = "ordenDeCompraToolStripMenuItem";
            this.ordenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.ordenDeCompraToolStripMenuItem.Text = "Orden de Compra";
            this.ordenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordenDeCompraToolStripMenuItem_Click);
            // 
            // detalleDeOrdenDeCompraToolStripMenuItem
            // 
            this.detalleDeOrdenDeCompraToolStripMenuItem.Name = "detalleDeOrdenDeCompraToolStripMenuItem";
            this.detalleDeOrdenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.detalleDeOrdenDeCompraToolStripMenuItem.Text = "Detalle de Orden de Compra";
            this.detalleDeOrdenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.detalleDeOrdenDeCompraToolStripMenuItem_Click);
            // 
            // ordenDeVentaToolStripMenuItem
            // 
            this.ordenDeVentaToolStripMenuItem.Name = "ordenDeVentaToolStripMenuItem";
            this.ordenDeVentaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.ordenDeVentaToolStripMenuItem.Text = "Orden de Venta";
            this.ordenDeVentaToolStripMenuItem.Click += new System.EventHandler(this.ordenDeVentaToolStripMenuItem_Click);
            // 
            // detalleDeOrdenDeVentaToolStripMenuItem
            // 
            this.detalleDeOrdenDeVentaToolStripMenuItem.Name = "detalleDeOrdenDeVentaToolStripMenuItem";
            this.detalleDeOrdenDeVentaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.detalleDeOrdenDeVentaToolStripMenuItem.Text = "Detalle de Orden de Venta";
            this.detalleDeOrdenDeVentaToolStripMenuItem.Click += new System.EventHandler(this.detalleDeOrdenDeVentaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDePreciosToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.inventarioToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // historialDePreciosToolStripMenuItem
            // 
            this.historialDePreciosToolStripMenuItem.Name = "historialDePreciosToolStripMenuItem";
            this.historialDePreciosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.historialDePreciosToolStripMenuItem.Text = "Historial de Precios";
            this.historialDePreciosToolStripMenuItem.Click += new System.EventHandler(this.historialDePreciosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // auditoriasToolStripMenuItem
            // 
            this.auditoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.ordenesDeCompraToolStripMenuItem});
            this.auditoriasToolStripMenuItem.Name = "auditoriasToolStripMenuItem";
            this.auditoriasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.auditoriasToolStripMenuItem.Text = "Auditorias";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraToolStripMenuItem.Text = "Ordenes de Compra";
            this.ordenesDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeCompraToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaPorClienteToolStripMenuItem,
            this.stockExistenteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventaPorClienteToolStripMenuItem
            // 
            this.ventaPorClienteToolStripMenuItem.Name = "ventaPorClienteToolStripMenuItem";
            this.ventaPorClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaPorClienteToolStripMenuItem.Text = "Venta por Cliente";
            this.ventaPorClienteToolStripMenuItem.Click += new System.EventHandler(this.ventaPorClienteToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion ";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // stockExistenteToolStripMenuItem
            // 
            this.stockExistenteToolStripMenuItem.Name = "stockExistenteToolStripMenuItem";
            this.stockExistenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockExistenteToolStripMenuItem.Text = "Stock Existente";
            this.stockExistenteToolStripMenuItem.Click += new System.EventHandler(this.stockExistenteToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::UX_InventarioFS.Properties.Resources.logo_distri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1314, 753);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu Principal Distribuidora FS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeOrdenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeOrdenDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockExistenteToolStripMenuItem;
    }
}

