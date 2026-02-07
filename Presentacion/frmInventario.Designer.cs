
namespace Presentacion
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.GB_infoInventario = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cb_unidad = new System.Windows.Forms.ComboBox();
            this.txt_Proveedor = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_N_Inventario = new System.Windows.Forms.TextBox();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_N_Articulo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_BuscarInventario = new System.Windows.Forms.TextBox();
            this.lbl_B_inventario = new System.Windows.Forms.Label();
            this.btn_EliminarInventario = new System.Windows.Forms.Button();
            this.btn_ModificarInventario = new System.Windows.Forms.Button();
            this.btn_AgregarInventario = new System.Windows.Forms.Button();
            this.btn_limpiarInventario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            this.GB_infoInventario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Inventario
            // 
            this.dgv_Inventario.AllowUserToAddRows = false;
            this.dgv_Inventario.AllowUserToDeleteRows = false;
            this.dgv_Inventario.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventario.Location = new System.Drawing.Point(381, 316);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.ReadOnly = true;
            this.dgv_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Inventario.Size = new System.Drawing.Size(691, 364);
            this.dgv_Inventario.TabIndex = 0;
            this.dgv_Inventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Inventario_CellClick);
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(8, 16);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(334, 32);
            this.lbl_NempresaCliente.TabIndex = 26;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // GB_infoInventario
            // 
            this.GB_infoInventario.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoInventario.Controls.Add(this.txt_id);
            this.GB_infoInventario.Controls.Add(this.cb_unidad);
            this.GB_infoInventario.Controls.Add(this.txt_Proveedor);
            this.GB_infoInventario.Controls.Add(this.txt_Descripcion);
            this.GB_infoInventario.Controls.Add(this.lbl_Descripcion);
            this.GB_infoInventario.Controls.Add(this.txt_cantidad);
            this.GB_infoInventario.Controls.Add(this.txt_N_Inventario);
            this.GB_infoInventario.Controls.Add(this.lbl_Proveedor);
            this.GB_infoInventario.Controls.Add(this.lbl_Cantidad);
            this.GB_infoInventario.Controls.Add(this.lbl_N_Articulo);
            this.GB_infoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoInventario.Location = new System.Drawing.Point(372, 12);
            this.GB_infoInventario.Name = "GB_infoInventario";
            this.GB_infoInventario.Size = new System.Drawing.Size(700, 263);
            this.GB_infoInventario.TabIndex = 28;
            this.GB_infoInventario.TabStop = false;
            this.GB_infoInventario.Text = "Informacion de productos";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(200, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(62, 24);
            this.txt_id.TabIndex = 13;
            this.txt_id.Visible = false;
            // 
            // cb_unidad
            // 
            this.cb_unidad.FormattingEnabled = true;
            this.cb_unidad.Items.AddRange(new object[] {
            "ml",
            "Unidad",
            "Scoop"});
            this.cb_unidad.Location = new System.Drawing.Point(372, 127);
            this.cb_unidad.Name = "cb_unidad";
            this.cb_unidad.Size = new System.Drawing.Size(81, 26);
            this.cb_unidad.TabIndex = 12;
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(200, 215);
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(469, 24);
            this.txt_Proveedor.TabIndex = 11;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(200, 173);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(469, 24);
            this.txt_Descripcion.TabIndex = 10;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(18, 173);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_Descripcion.TabIndex = 9;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(200, 127);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(142, 24);
            this.txt_cantidad.TabIndex = 6;
            // 
            // txt_N_Inventario
            // 
            this.txt_N_Inventario.Location = new System.Drawing.Point(200, 80);
            this.txt_N_Inventario.Name = "txt_N_Inventario";
            this.txt_N_Inventario.Size = new System.Drawing.Size(200, 24);
            this.txt_N_Inventario.TabIndex = 5;
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.Location = new System.Drawing.Point(18, 222);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(81, 18);
            this.lbl_Proveedor.TabIndex = 2;
            this.lbl_Proveedor.Text = "Proveedor ";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(18, 130);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(66, 18);
            this.lbl_Cantidad.TabIndex = 1;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_N_Articulo
            // 
            this.lbl_N_Articulo.AutoSize = true;
            this.lbl_N_Articulo.Location = new System.Drawing.Point(18, 83);
            this.lbl_N_Articulo.Name = "lbl_N_Articulo";
            this.lbl_N_Articulo.Size = new System.Drawing.Size(150, 18);
            this.lbl_N_Articulo.TabIndex = 0;
            this.lbl_N_Articulo.Text = "Nombre del Producto";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_BuscarInventario
            // 
            this.txt_BuscarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarInventario.Location = new System.Drawing.Point(572, 281);
            this.txt_BuscarInventario.Name = "txt_BuscarInventario";
            this.txt_BuscarInventario.Size = new System.Drawing.Size(322, 26);
            this.txt_BuscarInventario.TabIndex = 39;
            this.txt_BuscarInventario.TextChanged += new System.EventHandler(this.txt_BuscarInventario_TextChanged);
            // 
            // lbl_B_inventario
            // 
            this.lbl_B_inventario.AutoSize = true;
            this.lbl_B_inventario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_inventario.Location = new System.Drawing.Point(403, 280);
            this.lbl_B_inventario.Name = "lbl_B_inventario";
            this.lbl_B_inventario.Size = new System.Drawing.Size(143, 25);
            this.lbl_B_inventario.TabIndex = 38;
            this.lbl_B_inventario.Text = "Buscar Producto";
            // 
            // btn_EliminarInventario
            // 
            this.btn_EliminarInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarInventario.BackgroundImage")));
            this.btn_EliminarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarInventario.FlatAppearance.BorderSize = 0;
            this.btn_EliminarInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EliminarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarInventario.Location = new System.Drawing.Point(86, 459);
            this.btn_EliminarInventario.Name = "btn_EliminarInventario";
            this.btn_EliminarInventario.Size = new System.Drawing.Size(238, 67);
            this.btn_EliminarInventario.TabIndex = 33;
            this.btn_EliminarInventario.Text = "Eliminar";
            this.btn_EliminarInventario.UseVisualStyleBackColor = true;
            this.btn_EliminarInventario.Click += new System.EventHandler(this.btn_EliminarInventario_Click);
            // 
            // btn_ModificarInventario
            // 
            this.btn_ModificarInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarInventario.BackgroundImage")));
            this.btn_ModificarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarInventario.FlatAppearance.BorderSize = 0;
            this.btn_ModificarInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ModificarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarInventario.Location = new System.Drawing.Point(86, 330);
            this.btn_ModificarInventario.Name = "btn_ModificarInventario";
            this.btn_ModificarInventario.Size = new System.Drawing.Size(238, 67);
            this.btn_ModificarInventario.TabIndex = 32;
            this.btn_ModificarInventario.Text = "Modificar";
            this.btn_ModificarInventario.UseVisualStyleBackColor = true;
            this.btn_ModificarInventario.Click += new System.EventHandler(this.btn_ModificarInventario_Click);
            // 
            // btn_AgregarInventario
            // 
            this.btn_AgregarInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarInventario.BackgroundImage")));
            this.btn_AgregarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarInventario.FlatAppearance.BorderSize = 0;
            this.btn_AgregarInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarInventario.Location = new System.Drawing.Point(86, 73);
            this.btn_AgregarInventario.Name = "btn_AgregarInventario";
            this.btn_AgregarInventario.Size = new System.Drawing.Size(238, 67);
            this.btn_AgregarInventario.TabIndex = 31;
            this.btn_AgregarInventario.Text = "Agregar";
            this.btn_AgregarInventario.UseVisualStyleBackColor = true;
            this.btn_AgregarInventario.Click += new System.EventHandler(this.btn_AgregarInventario_Click);
            // 
            // btn_limpiarInventario
            // 
            this.btn_limpiarInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiarInventario.BackgroundImage")));
            this.btn_limpiarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarInventario.FlatAppearance.BorderSize = 0;
            this.btn_limpiarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarInventario.Location = new System.Drawing.Point(86, 200);
            this.btn_limpiarInventario.Name = "btn_limpiarInventario";
            this.btn_limpiarInventario.Size = new System.Drawing.Size(238, 67);
            this.btn_limpiarInventario.TabIndex = 30;
            this.btn_limpiarInventario.Text = "Limpiar";
            this.btn_limpiarInventario.UseVisualStyleBackColor = true;
            this.btn_limpiarInventario.Click += new System.EventHandler(this.btn_limpiarInventario_Click);
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
            this.panel1.Controls.Add(this.btn_AgregarInventario);
            this.panel1.Controls.Add(this.btn_limpiarInventario);
            this.panel1.Controls.Add(this.btn_EliminarInventario);
            this.panel1.Controls.Add(this.btn_ModificarInventario);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 694);
            this.panel1.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(25, 599);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(37, 45);
            this.panel6.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(25, 469);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 45);
            this.panel5.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(25, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 45);
            this.panel4.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(25, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 45);
            this.panel3.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(25, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 45);
            this.panel2.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(86, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 67);
            this.button1.TabIndex = 34;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1095, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_BuscarInventario);
            this.Controls.Add(this.lbl_B_inventario);
            this.Controls.Add(this.GB_infoInventario);
            this.Controls.Add(this.dgv_Inventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            this.GB_infoInventario.ResumeLayout(false);
            this.GB_infoInventario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Inventario;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.GroupBox GB_infoInventario;
        private System.Windows.Forms.TextBox txt_Proveedor;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_N_Inventario;
        private System.Windows.Forms.Label lbl_Proveedor;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_N_Articulo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_EliminarInventario;
        private System.Windows.Forms.Button btn_ModificarInventario;
        private System.Windows.Forms.Button btn_AgregarInventario;
        private System.Windows.Forms.Button btn_limpiarInventario;
        private System.Windows.Forms.TextBox txt_BuscarInventario;
        private System.Windows.Forms.Label lbl_B_inventario;
        private System.Windows.Forms.ComboBox cb_unidad;
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