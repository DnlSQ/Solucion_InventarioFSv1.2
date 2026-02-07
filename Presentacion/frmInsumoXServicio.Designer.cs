
namespace Presentacion
{
    partial class frmInsumoXServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsumoXServicio));
            this.txt_Bservicio = new System.Windows.Forms.TextBox();
            this.lbl_B_Proveedor = new System.Windows.Forms.Label();
            this.btn_EliminarProveedor = new System.Windows.Forms.Button();
            this.btn_ModificarProveedor = new System.Windows.Forms.Button();
            this.btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.btn_limpiarProveedor = new System.Windows.Forms.Button();
            this.GB_infoProveedor = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.txt_N_Insumo = new System.Windows.Forms.TextBox();
            this.txt_N_Servicio = new System.Windows.Forms.TextBox();
            this.lbl_Desccripcion_Proveedor = new System.Windows.Forms.Label();
            this.lbl_N_Proveedor = new System.Windows.Forms.Label();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.dgv_servicio = new System.Windows.Forms.DataGridView();
            this.txt_Binsumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_insumo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_IXS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_IXS = new System.Windows.Forms.DataGridView();
            this.GB_infoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insumo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IXS)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Bservicio
            // 
            this.txt_Bservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bservicio.Location = new System.Drawing.Point(630, 231);
            this.txt_Bservicio.Name = "txt_Bservicio";
            this.txt_Bservicio.Size = new System.Drawing.Size(200, 24);
            this.txt_Bservicio.TabIndex = 69;
            this.txt_Bservicio.TextChanged += new System.EventHandler(this.txt_Bservicio_TextChanged_1);
            // 
            // lbl_B_Proveedor
            // 
            this.lbl_B_Proveedor.AutoSize = true;
            this.lbl_B_Proveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_Proveedor.Location = new System.Drawing.Point(491, 231);
            this.lbl_B_Proveedor.Name = "lbl_B_Proveedor";
            this.lbl_B_Proveedor.Size = new System.Drawing.Size(128, 19);
            this.lbl_B_Proveedor.TabIndex = 68;
            this.lbl_B_Proveedor.Text = "Buscar servicio";
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProveedor.BackgroundImage")));
            this.btn_EliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_EliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(75, 419);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(233, 68);
            this.btn_EliminarProveedor.TabIndex = 63;
            this.btn_EliminarProveedor.Text = "Eliminar";
            this.btn_EliminarProveedor.UseVisualStyleBackColor = true;
            this.btn_EliminarProveedor.Click += new System.EventHandler(this.btn_EliminarProveedor_Click);
            // 
            // btn_ModificarProveedor
            // 
            this.btn_ModificarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarProveedor.BackgroundImage")));
            this.btn_ModificarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_ModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarProveedor.Location = new System.Drawing.Point(75, 313);
            this.btn_ModificarProveedor.Name = "btn_ModificarProveedor";
            this.btn_ModificarProveedor.Size = new System.Drawing.Size(233, 68);
            this.btn_ModificarProveedor.TabIndex = 62;
            this.btn_ModificarProveedor.Text = "Modificar";
            this.btn_ModificarProveedor.UseVisualStyleBackColor = true;
            this.btn_ModificarProveedor.Click += new System.EventHandler(this.btn_ModificarProveedor_Click);
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProveedor.BackgroundImage")));
            this.btn_AgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_AgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(75, 92);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(233, 68);
            this.btn_AgregarProveedor.TabIndex = 61;
            this.btn_AgregarProveedor.Text = "Agregar";
            this.btn_AgregarProveedor.UseVisualStyleBackColor = true;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // btn_limpiarProveedor
            // 
            this.btn_limpiarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiarProveedor.BackgroundImage")));
            this.btn_limpiarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_limpiarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_limpiarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarProveedor.Location = new System.Drawing.Point(75, 203);
            this.btn_limpiarProveedor.Name = "btn_limpiarProveedor";
            this.btn_limpiarProveedor.Size = new System.Drawing.Size(233, 68);
            this.btn_limpiarProveedor.TabIndex = 60;
            this.btn_limpiarProveedor.Text = "Limpiar";
            this.btn_limpiarProveedor.UseVisualStyleBackColor = true;
            this.btn_limpiarProveedor.Click += new System.EventHandler(this.btn_limpiarProveedor_Click);
            // 
            // GB_infoProveedor
            // 
            this.GB_infoProveedor.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoProveedor.Controls.Add(this.txt_id);
            this.GB_infoProveedor.Controls.Add(this.txt_Cantidad);
            this.GB_infoProveedor.Controls.Add(this.lbl_contacto);
            this.GB_infoProveedor.Controls.Add(this.txt_N_Insumo);
            this.GB_infoProveedor.Controls.Add(this.txt_N_Servicio);
            this.GB_infoProveedor.Controls.Add(this.lbl_Desccripcion_Proveedor);
            this.GB_infoProveedor.Controls.Add(this.lbl_N_Proveedor);
            this.GB_infoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoProveedor.Location = new System.Drawing.Point(369, 19);
            this.GB_infoProveedor.Name = "GB_infoProveedor";
            this.GB_infoProveedor.Size = new System.Drawing.Size(287, 185);
            this.GB_infoProveedor.TabIndex = 59;
            this.GB_infoProveedor.TabStop = false;
            this.GB_infoProveedor.Text = "Informacion del Proveedor";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(118, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(122, 24);
            this.txt_id.TabIndex = 11;
            this.txt_id.Visible = false;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(127, 132);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(133, 24);
            this.txt_Cantidad.TabIndex = 10;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Location = new System.Drawing.Point(6, 135);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(113, 18);
            this.lbl_contacto.TabIndex = 9;
            this.lbl_contacto.Text = "Cantidad Usada";
            // 
            // txt_N_Insumo
            // 
            this.txt_N_Insumo.Location = new System.Drawing.Point(127, 94);
            this.txt_N_Insumo.Name = "txt_N_Insumo";
            this.txt_N_Insumo.Size = new System.Drawing.Size(135, 24);
            this.txt_N_Insumo.TabIndex = 6;
            // 
            // txt_N_Servicio
            // 
            this.txt_N_Servicio.Location = new System.Drawing.Point(127, 59);
            this.txt_N_Servicio.Name = "txt_N_Servicio";
            this.txt_N_Servicio.Size = new System.Drawing.Size(133, 24);
            this.txt_N_Servicio.TabIndex = 5;
            // 
            // lbl_Desccripcion_Proveedor
            // 
            this.lbl_Desccripcion_Proveedor.AutoSize = true;
            this.lbl_Desccripcion_Proveedor.Location = new System.Drawing.Point(6, 100);
            this.lbl_Desccripcion_Proveedor.Name = "lbl_Desccripcion_Proveedor";
            this.lbl_Desccripcion_Proveedor.Size = new System.Drawing.Size(98, 18);
            this.lbl_Desccripcion_Proveedor.TabIndex = 1;
            this.lbl_Desccripcion_Proveedor.Text = "ID del Insumo";
            // 
            // lbl_N_Proveedor
            // 
            this.lbl_N_Proveedor.AutoSize = true;
            this.lbl_N_Proveedor.Location = new System.Drawing.Point(6, 66);
            this.lbl_N_Proveedor.Name = "lbl_N_Proveedor";
            this.lbl_N_Proveedor.Size = new System.Drawing.Size(102, 18);
            this.lbl_N_Proveedor.TabIndex = 0;
            this.lbl_N_Proveedor.Text = "ID del Servicio";
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(4, 20);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(334, 32);
            this.lbl_NempresaCliente.TabIndex = 57;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // dgv_servicio
            // 
            this.dgv_servicio.AllowUserToAddRows = false;
            this.dgv_servicio.AllowUserToDeleteRows = false;
            this.dgv_servicio.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicio.Location = new System.Drawing.Point(487, 259);
            this.dgv_servicio.Name = "dgv_servicio";
            this.dgv_servicio.ReadOnly = true;
            this.dgv_servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servicio.Size = new System.Drawing.Size(775, 138);
            this.dgv_servicio.TabIndex = 56;
            this.dgv_servicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicio_CellClick_1);
            // 
            // txt_Binsumo
            // 
            this.txt_Binsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Binsumo.Location = new System.Drawing.Point(621, 446);
            this.txt_Binsumo.Name = "txt_Binsumo";
            this.txt_Binsumo.Size = new System.Drawing.Size(200, 24);
            this.txt_Binsumo.TabIndex = 74;
            this.txt_Binsumo.TextChanged += new System.EventHandler(this.txt_Binsumo_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Buscar Insumo";
            // 
            // dgv_insumo
            // 
            this.dgv_insumo.AllowUserToAddRows = false;
            this.dgv_insumo.AllowUserToDeleteRows = false;
            this.dgv_insumo.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_insumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_insumo.Location = new System.Drawing.Point(478, 472);
            this.dgv_insumo.Name = "dgv_insumo";
            this.dgv_insumo.ReadOnly = true;
            this.dgv_insumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_insumo.Size = new System.Drawing.Size(775, 137);
            this.dgv_insumo.TabIndex = 72;
            this.dgv_insumo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_insumo_CellClick_1);
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
            this.panel1.Controls.Add(this.btn_AgregarProveedor);
            this.panel1.Controls.Add(this.btn_limpiarProveedor);
            this.panel1.Controls.Add(this.btn_ModificarProveedor);
            this.panel1.Controls.Add(this.btn_EliminarProveedor);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 611);
            this.panel1.TabIndex = 75;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(23, 534);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(36, 41);
            this.panel6.TabIndex = 66;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(23, 431);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(36, 41);
            this.panel5.TabIndex = 66;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(23, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 41);
            this.panel4.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(23, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 41);
            this.panel3.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(23, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 41);
            this.panel2.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(75, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 68);
            this.button1.TabIndex = 64;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_IXS
            // 
            this.txt_IXS.Location = new System.Drawing.Point(1092, 17);
            this.txt_IXS.Name = "txt_IXS";
            this.txt_IXS.Size = new System.Drawing.Size(200, 20);
            this.txt_IXS.TabIndex = 80;
            this.txt_IXS.TextChanged += new System.EventHandler(this.txt_IXS_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "Insumos por servicios registrados";
            // 
            // dgv_IXS
            // 
            this.dgv_IXS.AllowUserToAddRows = false;
            this.dgv_IXS.AllowUserToDeleteRows = false;
            this.dgv_IXS.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_IXS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IXS.Location = new System.Drawing.Point(674, 45);
            this.dgv_IXS.Name = "dgv_IXS";
            this.dgv_IXS.ReadOnly = true;
            this.dgv_IXS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_IXS.Size = new System.Drawing.Size(721, 181);
            this.dgv_IXS.TabIndex = 78;
            this.dgv_IXS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_IXS_CellClick_1);
            // 
            // frmInsumoXServicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1425, 674);
            this.Controls.Add(this.txt_IXS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_IXS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Binsumo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_insumo);
            this.Controls.Add(this.txt_Bservicio);
            this.Controls.Add(this.lbl_B_Proveedor);
            this.Controls.Add(this.GB_infoProveedor);
            this.Controls.Add(this.dgv_servicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsumoXServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Insumo de Servicio";
            this.GB_infoProveedor.ResumeLayout(false);
            this.GB_infoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insumo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IXS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Bservicio;
        private System.Windows.Forms.Label lbl_B_Proveedor;
        private System.Windows.Forms.Button btn_EliminarProveedor;
        private System.Windows.Forms.Button btn_ModificarProveedor;
        private System.Windows.Forms.Button btn_AgregarProveedor;
        private System.Windows.Forms.Button btn_limpiarProveedor;
        private System.Windows.Forms.GroupBox GB_infoProveedor;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.TextBox txt_N_Insumo;
        private System.Windows.Forms.TextBox txt_N_Servicio;
        private System.Windows.Forms.Label lbl_Desccripcion_Proveedor;
        private System.Windows.Forms.Label lbl_N_Proveedor;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.DataGridView dgv_servicio;
        private System.Windows.Forms.TextBox txt_Binsumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_insumo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_IXS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_IXS;
    }
}