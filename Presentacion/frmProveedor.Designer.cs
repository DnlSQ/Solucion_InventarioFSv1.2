
namespace Presentacion
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.txt_BuscarProveedor = new System.Windows.Forms.TextBox();
            this.lbl_B_Proveedor = new System.Windows.Forms.Label();
            this.GB_infoProveedor = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_contacto = new System.Windows.Forms.TextBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.txt_Descripcion_Proveedor = new System.Windows.Forms.TextBox();
            this.txt_N_Proveedor = new System.Windows.Forms.TextBox();
            this.lbl_Desccripcion_Proveedor = new System.Windows.Forms.Label();
            this.lbl_N_Proveedor = new System.Windows.Forms.Label();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.dgv_Proveedor = new System.Windows.Forms.DataGridView();
            this.btn_EliminarProveedor = new System.Windows.Forms.Button();
            this.btn_ModificarProveedor = new System.Windows.Forms.Button();
            this.btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.btn_limpiarProveedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GB_infoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BuscarProveedor
            // 
            this.txt_BuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarProveedor.Location = new System.Drawing.Point(548, 255);
            this.txt_BuscarProveedor.Name = "txt_BuscarProveedor";
            this.txt_BuscarProveedor.Size = new System.Drawing.Size(200, 24);
            this.txt_BuscarProveedor.TabIndex = 53;
            this.txt_BuscarProveedor.TextChanged += new System.EventHandler(this.txt_BuscarProveedor_TextChanged);
            // 
            // lbl_B_Proveedor
            // 
            this.lbl_B_Proveedor.AutoSize = true;
            this.lbl_B_Proveedor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_Proveedor.Location = new System.Drawing.Point(388, 253);
            this.lbl_B_Proveedor.Name = "lbl_B_Proveedor";
            this.lbl_B_Proveedor.Size = new System.Drawing.Size(154, 25);
            this.lbl_B_Proveedor.TabIndex = 52;
            this.lbl_B_Proveedor.Text = "Buscar Proveedor";
            // 
            // GB_infoProveedor
            // 
            this.GB_infoProveedor.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoProveedor.Controls.Add(this.txt_id);
            this.GB_infoProveedor.Controls.Add(this.txt_contacto);
            this.GB_infoProveedor.Controls.Add(this.lbl_contacto);
            this.GB_infoProveedor.Controls.Add(this.txt_Descripcion_Proveedor);
            this.GB_infoProveedor.Controls.Add(this.txt_N_Proveedor);
            this.GB_infoProveedor.Controls.Add(this.lbl_Desccripcion_Proveedor);
            this.GB_infoProveedor.Controls.Add(this.lbl_N_Proveedor);
            this.GB_infoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoProveedor.Location = new System.Drawing.Point(383, 29);
            this.GB_infoProveedor.Name = "GB_infoProveedor";
            this.GB_infoProveedor.Size = new System.Drawing.Size(629, 180);
            this.GB_infoProveedor.TabIndex = 43;
            this.GB_infoProveedor.TabStop = false;
            this.GB_infoProveedor.Text = "Informacion del Proveedor";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(240, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(45, 24);
            this.txt_id.TabIndex = 11;
            this.txt_id.Visible = false;
            // 
            // txt_contacto
            // 
            this.txt_contacto.Location = new System.Drawing.Point(240, 140);
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(372, 24);
            this.txt_contacto.TabIndex = 10;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Location = new System.Drawing.Point(33, 147);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(69, 18);
            this.lbl_contacto.TabIndex = 9;
            this.lbl_contacto.Text = "Contacto";
            // 
            // txt_Descripcion_Proveedor
            // 
            this.txt_Descripcion_Proveedor.Location = new System.Drawing.Point(240, 100);
            this.txt_Descripcion_Proveedor.Name = "txt_Descripcion_Proveedor";
            this.txt_Descripcion_Proveedor.Size = new System.Drawing.Size(372, 24);
            this.txt_Descripcion_Proveedor.TabIndex = 6;
            // 
            // txt_N_Proveedor
            // 
            this.txt_N_Proveedor.Location = new System.Drawing.Point(240, 56);
            this.txt_N_Proveedor.Name = "txt_N_Proveedor";
            this.txt_N_Proveedor.Size = new System.Drawing.Size(372, 24);
            this.txt_N_Proveedor.TabIndex = 5;
            // 
            // lbl_Desccripcion_Proveedor
            // 
            this.lbl_Desccripcion_Proveedor.AutoSize = true;
            this.lbl_Desccripcion_Proveedor.Location = new System.Drawing.Point(33, 103);
            this.lbl_Desccripcion_Proveedor.Name = "lbl_Desccripcion_Proveedor";
            this.lbl_Desccripcion_Proveedor.Size = new System.Drawing.Size(87, 18);
            this.lbl_Desccripcion_Proveedor.TabIndex = 1;
            this.lbl_Desccripcion_Proveedor.Text = "Descripcion";
            // 
            // lbl_N_Proveedor
            // 
            this.lbl_N_Proveedor.AutoSize = true;
            this.lbl_N_Proveedor.Location = new System.Drawing.Point(33, 59);
            this.lbl_N_Proveedor.Name = "lbl_N_Proveedor";
            this.lbl_N_Proveedor.Size = new System.Drawing.Size(158, 18);
            this.lbl_N_Proveedor.TabIndex = 0;
            this.lbl_N_Proveedor.Text = "Nombre del Proveedor";
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(3, 10);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(334, 32);
            this.lbl_NempresaCliente.TabIndex = 41;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // dgv_Proveedor
            // 
            this.dgv_Proveedor.AllowUserToAddRows = false;
            this.dgv_Proveedor.AllowUserToDeleteRows = false;
            this.dgv_Proveedor.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proveedor.Location = new System.Drawing.Point(383, 284);
            this.dgv_Proveedor.Name = "dgv_Proveedor";
            this.dgv_Proveedor.ReadOnly = true;
            this.dgv_Proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Proveedor.Size = new System.Drawing.Size(808, 380);
            this.dgv_Proveedor.TabIndex = 40;
            this.dgv_Proveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Proveedor_CellClick);
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProveedor.BackgroundImage")));
            this.btn_EliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_EliminarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(85, 463);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(252, 67);
            this.btn_EliminarProveedor.TabIndex = 47;
            this.btn_EliminarProveedor.Text = "Eliminar";
            this.btn_EliminarProveedor.UseVisualStyleBackColor = false;
            this.btn_EliminarProveedor.Click += new System.EventHandler(this.btn_EliminarProveedor_Click);
            // 
            // btn_ModificarProveedor
            // 
            this.btn_ModificarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarProveedor.BackgroundImage")));
            this.btn_ModificarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_ModificarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarProveedor.Location = new System.Drawing.Point(85, 340);
            this.btn_ModificarProveedor.Name = "btn_ModificarProveedor";
            this.btn_ModificarProveedor.Size = new System.Drawing.Size(252, 67);
            this.btn_ModificarProveedor.TabIndex = 46;
            this.btn_ModificarProveedor.Text = "Modificar";
            this.btn_ModificarProveedor.UseVisualStyleBackColor = false;
            this.btn_ModificarProveedor.Click += new System.EventHandler(this.btn_ModificarProveedor_Click);
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProveedor.BackgroundImage")));
            this.btn_AgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_AgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(85, 85);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(252, 68);
            this.btn_AgregarProveedor.TabIndex = 45;
            this.btn_AgregarProveedor.Text = "Agregar";
            this.btn_AgregarProveedor.UseVisualStyleBackColor = false;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // btn_limpiarProveedor
            // 
            this.btn_limpiarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiarProveedor.BackgroundImage")));
            this.btn_limpiarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_limpiarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_limpiarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarProveedor.Location = new System.Drawing.Point(85, 215);
            this.btn_limpiarProveedor.Name = "btn_limpiarProveedor";
            this.btn_limpiarProveedor.Size = new System.Drawing.Size(252, 67);
            this.btn_limpiarProveedor.TabIndex = 44;
            this.btn_limpiarProveedor.Text = "Limpiar";
            this.btn_limpiarProveedor.UseVisualStyleBackColor = false;
            this.btn_limpiarProveedor.Click += new System.EventHandler(this.btn_limpiarProveedor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_NempresaCliente);
            this.panel1.Controls.Add(this.btn_AgregarProveedor);
            this.panel1.Controls.Add(this.btn_limpiarProveedor);
            this.panel1.Controls.Add(this.btn_EliminarProveedor);
            this.panel1.Controls.Add(this.btn_ModificarProveedor);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 665);
            this.panel1.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(25, 594);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 38);
            this.panel4.TabIndex = 50;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(25, 477);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 38);
            this.panel6.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(25, 353);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 38);
            this.panel5.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(25, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 38);
            this.panel3.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(25, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 38);
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
            this.button1.Location = new System.Drawing.Point(85, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 67);
            this.button1.TabIndex = 48;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1252, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_BuscarProveedor);
            this.Controls.Add(this.lbl_B_Proveedor);
            this.Controls.Add(this.GB_infoProveedor);
            this.Controls.Add(this.dgv_Proveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proveedores";
            this.GB_infoProveedor.ResumeLayout(false);
            this.GB_infoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BuscarProveedor;
        private System.Windows.Forms.Label lbl_B_Proveedor;
        private System.Windows.Forms.Button btn_EliminarProveedor;
        private System.Windows.Forms.Button btn_ModificarProveedor;
        private System.Windows.Forms.Button btn_AgregarProveedor;
        private System.Windows.Forms.Button btn_limpiarProveedor;
        private System.Windows.Forms.GroupBox GB_infoProveedor;
        private System.Windows.Forms.TextBox txt_contacto;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.TextBox txt_Descripcion_Proveedor;
        private System.Windows.Forms.TextBox txt_N_Proveedor;
        private System.Windows.Forms.Label lbl_Desccripcion_Proveedor;
        private System.Windows.Forms.Label lbl_N_Proveedor;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.DataGridView dgv_Proveedor;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}