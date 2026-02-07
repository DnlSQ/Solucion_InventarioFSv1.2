
namespace Presentacion
{
    partial class frmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicios));
            this.txt_BuscarInventario = new System.Windows.Forms.TextBox();
            this.lbl_B_inventario = new System.Windows.Forms.Label();
            this.GB_infoInventario = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_tiempoServicio = new System.Windows.Forms.TextBox();
            this.lbl_tiempoServicio = new System.Windows.Forms.Label();
            this.txt_NombreS = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_N_Articulo = new System.Windows.Forms.Label();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.dgv_Servicios = new System.Windows.Forms.DataGridView();
            this.btn_EliminarS = new System.Windows.Forms.Button();
            this.btn_ModificarS = new System.Windows.Forms.Button();
            this.btn_AgregarS = new System.Windows.Forms.Button();
            this.btn_limpiarS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GB_infoInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BuscarInventario
            // 
            this.txt_BuscarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarInventario.Location = new System.Drawing.Point(491, 300);
            this.txt_BuscarInventario.Name = "txt_BuscarInventario";
            this.txt_BuscarInventario.Size = new System.Drawing.Size(420, 24);
            this.txt_BuscarInventario.TabIndex = 53;
            this.txt_BuscarInventario.TextChanged += new System.EventHandler(this.txt_BuscarInventario_TextChanged);
            // 
            // lbl_B_inventario
            // 
            this.lbl_B_inventario.AutoSize = true;
            this.lbl_B_inventario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_inventario.Location = new System.Drawing.Point(405, 298);
            this.lbl_B_inventario.Name = "lbl_B_inventario";
            this.lbl_B_inventario.Size = new System.Drawing.Size(67, 25);
            this.lbl_B_inventario.TabIndex = 52;
            this.lbl_B_inventario.Text = "Buscar";
            // 
            // GB_infoInventario
            // 
            this.GB_infoInventario.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoInventario.Controls.Add(this.txt_descripcion);
            this.GB_infoInventario.Controls.Add(this.lbl_descripcion);
            this.GB_infoInventario.Controls.Add(this.txt_tiempoServicio);
            this.GB_infoInventario.Controls.Add(this.lbl_tiempoServicio);
            this.GB_infoInventario.Controls.Add(this.txt_NombreS);
            this.GB_infoInventario.Controls.Add(this.txt_id);
            this.GB_infoInventario.Controls.Add(this.lbl_Cantidad);
            this.GB_infoInventario.Controls.Add(this.lbl_N_Articulo);
            this.GB_infoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoInventario.Location = new System.Drawing.Point(387, 26);
            this.GB_infoInventario.Name = "GB_infoInventario";
            this.GB_infoInventario.Size = new System.Drawing.Size(831, 221);
            this.GB_infoInventario.TabIndex = 43;
            this.GB_infoInventario.TabStop = false;
            this.GB_infoInventario.Text = "Informacion de los Servicios";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(208, 143);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(606, 24);
            this.txt_descripcion.TabIndex = 12;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(19, 143);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_descripcion.TabIndex = 11;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // txt_tiempoServicio
            // 
            this.txt_tiempoServicio.Location = new System.Drawing.Point(208, 180);
            this.txt_tiempoServicio.Name = "txt_tiempoServicio";
            this.txt_tiempoServicio.Size = new System.Drawing.Size(606, 24);
            this.txt_tiempoServicio.TabIndex = 10;
            // 
            // lbl_tiempoServicio
            // 
            this.lbl_tiempoServicio.AutoSize = true;
            this.lbl_tiempoServicio.Location = new System.Drawing.Point(19, 183);
            this.lbl_tiempoServicio.Name = "lbl_tiempoServicio";
            this.lbl_tiempoServicio.Size = new System.Drawing.Size(156, 18);
            this.lbl_tiempoServicio.TabIndex = 9;
            this.lbl_tiempoServicio.Text = "Durancion del Servicio";
            // 
            // txt_NombreS
            // 
            this.txt_NombreS.Location = new System.Drawing.Point(207, 101);
            this.txt_NombreS.Name = "txt_NombreS";
            this.txt_NombreS.Size = new System.Drawing.Size(607, 24);
            this.txt_NombreS.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(208, 57);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(606, 24);
            this.txt_id.TabIndex = 5;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(19, 104);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(142, 18);
            this.lbl_Cantidad.TabIndex = 1;
            this.lbl_Cantidad.Text = "Nombre del Servicio";
            // 
            // lbl_N_Articulo
            // 
            this.lbl_N_Articulo.AutoSize = true;
            this.lbl_N_Articulo.Location = new System.Drawing.Point(19, 57);
            this.lbl_N_Articulo.Name = "lbl_N_Articulo";
            this.lbl_N_Articulo.Size = new System.Drawing.Size(102, 18);
            this.lbl_N_Articulo.TabIndex = 0;
            this.lbl_N_Articulo.Text = "ID del Servicio";
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(15, 15);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(334, 32);
            this.lbl_NempresaCliente.TabIndex = 41;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // dgv_Servicios
            // 
            this.dgv_Servicios.AllowUserToAddRows = false;
            this.dgv_Servicios.AllowUserToDeleteRows = false;
            this.dgv_Servicios.AllowUserToOrderColumns = true;
            this.dgv_Servicios.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_Servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Servicios.Location = new System.Drawing.Point(387, 327);
            this.dgv_Servicios.Name = "dgv_Servicios";
            this.dgv_Servicios.ReadOnly = true;
            this.dgv_Servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Servicios.Size = new System.Drawing.Size(836, 397);
            this.dgv_Servicios.TabIndex = 40;
            this.dgv_Servicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Servicios_CellClick);
            // 
            // btn_EliminarS
            // 
            this.btn_EliminarS.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarS.BackgroundImage")));
            this.btn_EliminarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarS.FlatAppearance.BorderSize = 0;
            this.btn_EliminarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EliminarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarS.Location = new System.Drawing.Point(90, 512);
            this.btn_EliminarS.Name = "btn_EliminarS";
            this.btn_EliminarS.Size = new System.Drawing.Size(249, 72);
            this.btn_EliminarS.TabIndex = 47;
            this.btn_EliminarS.Text = "Eiminar";
            this.btn_EliminarS.UseVisualStyleBackColor = false;
            this.btn_EliminarS.Click += new System.EventHandler(this.btn_EliminarS_Click);
            // 
            // btn_ModificarS
            // 
            this.btn_ModificarS.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarS.BackgroundImage")));
            this.btn_ModificarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarS.FlatAppearance.BorderSize = 0;
            this.btn_ModificarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ModificarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarS.Location = new System.Drawing.Point(90, 380);
            this.btn_ModificarS.Name = "btn_ModificarS";
            this.btn_ModificarS.Size = new System.Drawing.Size(249, 72);
            this.btn_ModificarS.TabIndex = 46;
            this.btn_ModificarS.Text = "Modificar";
            this.btn_ModificarS.UseVisualStyleBackColor = false;
            this.btn_ModificarS.Click += new System.EventHandler(this.btn_ModificarS_Click);
            // 
            // btn_AgregarS
            // 
            this.btn_AgregarS.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarS.BackgroundImage")));
            this.btn_AgregarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarS.FlatAppearance.BorderSize = 0;
            this.btn_AgregarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AgregarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarS.Location = new System.Drawing.Point(90, 125);
            this.btn_AgregarS.Name = "btn_AgregarS";
            this.btn_AgregarS.Size = new System.Drawing.Size(249, 72);
            this.btn_AgregarS.TabIndex = 45;
            this.btn_AgregarS.Text = "Agregar";
            this.btn_AgregarS.UseVisualStyleBackColor = false;
            this.btn_AgregarS.Click += new System.EventHandler(this.btn_AgregarS_Click);
            // 
            // btn_limpiarS
            // 
            this.btn_limpiarS.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiarS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiarS.BackgroundImage")));
            this.btn_limpiarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiarS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarS.FlatAppearance.BorderSize = 0;
            this.btn_limpiarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarS.Location = new System.Drawing.Point(90, 255);
            this.btn_limpiarS.Name = "btn_limpiarS";
            this.btn_limpiarS.Size = new System.Drawing.Size(249, 72);
            this.btn_limpiarS.TabIndex = 44;
            this.btn_limpiarS.Text = "Limpiar";
            this.btn_limpiarS.UseVisualStyleBackColor = false;
            this.btn_limpiarS.Click += new System.EventHandler(this.btn_limpiarS_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_NempresaCliente);
            this.panel1.Controls.Add(this.btn_AgregarS);
            this.panel1.Controls.Add(this.btn_limpiarS);
            this.panel1.Controls.Add(this.btn_EliminarS);
            this.panel1.Controls.Add(this.btn_ModificarS);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 742);
            this.panel1.TabIndex = 54;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(21, 658);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(43, 40);
            this.panel6.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(21, 529);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(43, 40);
            this.panel5.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(21, 399);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 40);
            this.panel4.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(21, 276);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 40);
            this.panel3.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(21, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 40);
            this.panel2.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(90, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 72);
            this.button1.TabIndex = 48;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmServicios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1230, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_BuscarInventario);
            this.Controls.Add(this.lbl_B_inventario);
            this.Controls.Add(this.GB_infoInventario);
            this.Controls.Add(this.dgv_Servicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Servicios";
            this.GB_infoInventario.ResumeLayout(false);
            this.GB_infoInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BuscarInventario;
        private System.Windows.Forms.Label lbl_B_inventario;
        private System.Windows.Forms.Button btn_EliminarS;
        private System.Windows.Forms.Button btn_ModificarS;
        private System.Windows.Forms.Button btn_AgregarS;
        private System.Windows.Forms.Button btn_limpiarS;
        private System.Windows.Forms.GroupBox GB_infoInventario;
        private System.Windows.Forms.TextBox txt_tiempoServicio;
        private System.Windows.Forms.Label lbl_tiempoServicio;
        private System.Windows.Forms.TextBox txt_NombreS;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_N_Articulo;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.DataGridView dgv_Servicios;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}