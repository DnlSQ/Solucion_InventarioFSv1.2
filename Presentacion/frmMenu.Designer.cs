
namespace Presentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeInsumosPorServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_UsuarioLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.clientesToolStripMenuItem2,
            this.citasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(782, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaboradoresToolStripMenuItem1,
            this.asignacionDeRolToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.clientesToolStripMenuItem.Text = "Usuario";
            // 
            // colaboradoresToolStripMenuItem1
            // 
            this.colaboradoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("colaboradoresToolStripMenuItem1.Image")));
            this.colaboradoresToolStripMenuItem1.Name = "colaboradoresToolStripMenuItem1";
            this.colaboradoresToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.colaboradoresToolStripMenuItem1.Text = "Registro de Colaboradores";
            this.colaboradoresToolStripMenuItem1.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem1_Click);
            // 
            // asignacionDeRolToolStripMenuItem
            // 
            this.asignacionDeRolToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("asignacionDeRolToolStripMenuItem.Image")));
            this.asignacionDeRolToolStripMenuItem.Name = "asignacionDeRolToolStripMenuItem";
            this.asignacionDeRolToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.asignacionDeRolToolStripMenuItem.Text = "Asignacion de Rol";
            this.asignacionDeRolToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeRolToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClienteToolStripMenuItem});
            this.clientesToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(69, 21);
            this.clientesToolStripMenuItem2.Text = "Clientes";
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeClienteToolStripMenuItem.Image")));
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.registroDeClienteToolStripMenuItem.Text = "Registro de Cliente";
            this.registroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.registroDeClienteToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // registroDeCitasToolStripMenuItem
            // 
            this.registroDeCitasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeCitasToolStripMenuItem.Image")));
            this.registroDeCitasToolStripMenuItem.Name = "registroDeCitasToolStripMenuItem";
            this.registroDeCitasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registroDeCitasToolStripMenuItem.Text = "Registro de citas ";
            this.registroDeCitasToolStripMenuItem.Click += new System.EventHandler(this.registroDeCitasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductoToolStripMenuItem,
            this.registrarProveedoresToolStripMenuItem});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.ShowShortcutKeys = false;
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarProductoToolStripMenuItem.Image")));
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.registrarProductoToolStripMenuItem.Text = "Registrar producto";
            this.registrarProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click);
            // 
            // registrarProveedoresToolStripMenuItem
            // 
            this.registrarProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarProveedoresToolStripMenuItem.Image")));
            this.registrarProveedoresToolStripMenuItem.Name = "registrarProveedoresToolStripMenuItem";
            this.registrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.registrarProveedoresToolStripMenuItem.Text = "Registrar Proveedores";
            this.registrarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.registrarProveedoresToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeServiciosToolStripMenuItem,
            this.registrosDeInsumosPorServicioToolStripMenuItem});
            this.serviciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // registroDeServiciosToolStripMenuItem
            // 
            this.registroDeServiciosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeServiciosToolStripMenuItem.Image")));
            this.registroDeServiciosToolStripMenuItem.Name = "registroDeServiciosToolStripMenuItem";
            this.registroDeServiciosToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.registroDeServiciosToolStripMenuItem.Text = "Registro de Servicios";
            this.registroDeServiciosToolStripMenuItem.Click += new System.EventHandler(this.registroDeServiciosToolStripMenuItem_Click);
            // 
            // registrosDeInsumosPorServicioToolStripMenuItem
            // 
            this.registrosDeInsumosPorServicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrosDeInsumosPorServicioToolStripMenuItem.Image")));
            this.registrosDeInsumosPorServicioToolStripMenuItem.Name = "registrosDeInsumosPorServicioToolStripMenuItem";
            this.registrosDeInsumosPorServicioToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.registrosDeInsumosPorServicioToolStripMenuItem.Text = "Registros de insumos por servicio";
            this.registrosDeInsumosPorServicioToolStripMenuItem.Click += new System.EventHandler(this.registrosDeInsumosPorServicioToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.inventarioToolStripMenuItem1,
            this.citasToolStripMenuItem1,
            this.serviciosToolStripMenuItem1,
            this.proveedoresToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem1.Image")));
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("inventarioToolStripMenuItem1.Image")));
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // citasToolStripMenuItem1
            // 
            this.citasToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("citasToolStripMenuItem1.Image")));
            this.citasToolStripMenuItem1.Name = "citasToolStripMenuItem1";
            this.citasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.citasToolStripMenuItem1.Text = "Citas";
            this.citasToolStripMenuItem1.Click += new System.EventHandler(this.citasToolStripMenuItem1_Click);
            // 
            // serviciosToolStripMenuItem1
            // 
            this.serviciosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("serviciosToolStripMenuItem1.Image")));
            this.serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
            this.serviciosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.serviciosToolStripMenuItem1.Text = "Servicios";
            this.serviciosToolStripMenuItem1.Click += new System.EventHandler(this.serviciosToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_UsuarioLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel1.Text = "Usuario Conectado";
            // 
            // tssl_UsuarioLogin
            // 
            this.tssl_UsuarioLogin.Name = "tssl_UsuarioLogin";
            this.tssl_UsuarioLogin.Size = new System.Drawing.Size(65, 17);
            this.tssl_UsuarioLogin.Text = "(Usuario)";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 508);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(252, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 505);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baloo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baloo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elegancia  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baloo", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Integral S.A ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desarrolado por Logical System";
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(782, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegancia Integral S.A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_UsuarioLogin;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeInsumosPorServicioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}