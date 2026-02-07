
namespace Presentacion
{
    partial class frmAsignarRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarRol));
            this.txt_BuscarProveedor = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.btn_EliminarProveedor = new System.Windows.Forms.Button();
            this.btn_ModificarProveedor = new System.Windows.Forms.Button();
            this.btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.btn_limpiarProveedor = new System.Windows.Forms.Button();
            this.GB_infoProveedor = new System.Windows.Forms.GroupBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Desccripcion_Proveedor = new System.Windows.Forms.Label();
            this.lbl_N_Proveedor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.dgv_ARol = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.GB_infoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ARol)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BuscarProveedor
            // 
            this.txt_BuscarProveedor.Location = new System.Drawing.Point(234, 10);
            this.txt_BuscarProveedor.Name = "txt_BuscarProveedor";
            this.txt_BuscarProveedor.Size = new System.Drawing.Size(310, 21);
            this.txt_BuscarProveedor.TabIndex = 69;
            this.txt_BuscarProveedor.TextChanged += new System.EventHandler(this.txt_BuscarProveedor_TextChanged);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(128, 9);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(68, 19);
            this.lbl_Buscar.TabIndex = 68;
            this.lbl_Buscar.Text = "Buscar ";
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProveedor.BackgroundImage")));
            this.btn_EliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_EliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_EliminarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(79, 341);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(204, 57);
            this.btn_EliminarProveedor.TabIndex = 63;
            this.btn_EliminarProveedor.Text = "Eliminar";
            this.btn_EliminarProveedor.UseVisualStyleBackColor = false;
            this.btn_EliminarProveedor.Click += new System.EventHandler(this.btn_EliminarProveedor_Click);
            // 
            // btn_ModificarProveedor
            // 
            this.btn_ModificarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarProveedor.BackgroundImage")));
            this.btn_ModificarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_ModificarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarProveedor.Location = new System.Drawing.Point(79, 463);
            this.btn_ModificarProveedor.Name = "btn_ModificarProveedor";
            this.btn_ModificarProveedor.Size = new System.Drawing.Size(204, 57);
            this.btn_ModificarProveedor.TabIndex = 62;
            this.btn_ModificarProveedor.Text = "Modificar";
            this.btn_ModificarProveedor.UseVisualStyleBackColor = false;
            this.btn_ModificarProveedor.Click += new System.EventHandler(this.btn_ModificarProveedor_Click);
            // 
            // btn_AgregarProveedor
            // 
            this.btn_AgregarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarProveedor.BackgroundImage")));
            this.btn_AgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_AgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProveedor.Location = new System.Drawing.Point(79, 101);
            this.btn_AgregarProveedor.Name = "btn_AgregarProveedor";
            this.btn_AgregarProveedor.Size = new System.Drawing.Size(204, 59);
            this.btn_AgregarProveedor.TabIndex = 61;
            this.btn_AgregarProveedor.Text = "Asignar Rol";
            this.btn_AgregarProveedor.UseVisualStyleBackColor = false;
            this.btn_AgregarProveedor.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // btn_limpiarProveedor
            // 
            this.btn_limpiarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiarProveedor.BackgroundImage")));
            this.btn_limpiarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_limpiarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_limpiarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_limpiarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarProveedor.Location = new System.Drawing.Point(79, 225);
            this.btn_limpiarProveedor.Name = "btn_limpiarProveedor";
            this.btn_limpiarProveedor.Size = new System.Drawing.Size(204, 59);
            this.btn_limpiarProveedor.TabIndex = 60;
            this.btn_limpiarProveedor.Text = "Limpiar";
            this.btn_limpiarProveedor.UseVisualStyleBackColor = false;
            this.btn_limpiarProveedor.Click += new System.EventHandler(this.btn_limpiarProveedor_Click);
            // 
            // GB_infoProveedor
            // 
            this.GB_infoProveedor.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoProveedor.Controls.Add(this.label13);
            this.GB_infoProveedor.Controls.Add(this.txt_id);
            this.GB_infoProveedor.Controls.Add(this.dtpFechaRegistro);
            this.GB_infoProveedor.Controls.Add(this.cb_rol);
            this.GB_infoProveedor.Controls.Add(this.lbl_contacto);
            this.GB_infoProveedor.Controls.Add(this.txt_usuario);
            this.GB_infoProveedor.Controls.Add(this.lbl_Desccripcion_Proveedor);
            this.GB_infoProveedor.Controls.Add(this.lbl_N_Proveedor);
            this.GB_infoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoProveedor.Location = new System.Drawing.Point(347, 33);
            this.GB_infoProveedor.Name = "GB_infoProveedor";
            this.GB_infoProveedor.Size = new System.Drawing.Size(590, 213);
            this.GB_infoProveedor.TabIndex = 59;
            this.GB_infoProveedor.TabStop = false;
            this.GB_infoProveedor.Text = "Asignar el Rol";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(234, 177);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(310, 24);
            this.dtpFechaRegistro.TabIndex = 42;
            // 
            // cb_rol
            // 
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "10"});
            this.cb_rol.Location = new System.Drawing.Point(234, 139);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(310, 26);
            this.cb_rol.TabIndex = 22;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Location = new System.Drawing.Point(57, 177);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(49, 18);
            this.lbl_contacto.TabIndex = 9;
            this.lbl_contacto.Text = "Fecha";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(234, 86);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(310, 24);
            this.txt_usuario.TabIndex = 5;
            // 
            // lbl_Desccripcion_Proveedor
            // 
            this.lbl_Desccripcion_Proveedor.AutoSize = true;
            this.lbl_Desccripcion_Proveedor.Location = new System.Drawing.Point(57, 139);
            this.lbl_Desccripcion_Proveedor.Name = "lbl_Desccripcion_Proveedor";
            this.lbl_Desccripcion_Proveedor.Size = new System.Drawing.Size(84, 18);
            this.lbl_Desccripcion_Proveedor.TabIndex = 1;
            this.lbl_Desccripcion_Proveedor.Text = "Tipo de Rol";
            // 
            // lbl_N_Proveedor
            // 
            this.lbl_N_Proveedor.AutoSize = true;
            this.lbl_N_Proveedor.Location = new System.Drawing.Point(57, 95);
            this.lbl_N_Proveedor.Name = "lbl_N_Proveedor";
            this.lbl_N_Proveedor.Size = new System.Drawing.Size(60, 18);
            this.lbl_N_Proveedor.TabIndex = 0;
            this.lbl_N_Proveedor.Text = "Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "7. Asistente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "6. Pedicurista";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "1. Administrador.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "2. Estilista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "3. Recepcionista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "4. Manicurista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "5. Barbero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipos de Rol";
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(15, 36);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(295, 28);
            this.lbl_NempresaCliente.TabIndex = 57;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // dgv_ARol
            // 
            this.dgv_ARol.AllowUserToAddRows = false;
            this.dgv_ARol.AllowUserToDeleteRows = false;
            this.dgv_ARol.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_ARol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ARol.Location = new System.Drawing.Point(347, 295);
            this.dgv_ARol.Name = "dgv_ARol";
            this.dgv_ARol.ReadOnly = true;
            this.dgv_ARol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ARol.Size = new System.Drawing.Size(859, 352);
            this.dgv_ARol.TabIndex = 56;
            this.dgv_ARol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ARol_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_limpiarProveedor);
            this.panel1.Controls.Add(this.btn_AgregarProveedor);
            this.panel1.Controls.Add(this.btn_ModificarProveedor);
            this.panel1.Controls.Add(this.btn_EliminarProveedor);
            this.panel1.Controls.Add(this.lbl_NempresaCliente);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-7, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 687);
            this.panel1.TabIndex = 73;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Location = new System.Drawing.Point(23, 589);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(35, 36);
            this.panel8.TabIndex = 67;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Location = new System.Drawing.Point(23, 475);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(35, 36);
            this.panel7.TabIndex = 66;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(23, 351);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(35, 36);
            this.panel6.TabIndex = 66;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(23, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(35, 36);
            this.panel5.TabIndex = 66;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(23, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 36);
            this.panel4.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(79, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 57);
            this.button1.TabIndex = 64;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(950, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 241);
            this.panel2.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.txt_BuscarProveedor);
            this.panel3.Controls.Add(this.lbl_Buscar);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(347, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 37);
            this.panel3.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Asigne ID al Rol";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(234, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(310, 24);
            this.txt_id.TabIndex = 43;
            // 
            // frmAsignarRol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1322, 677);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GB_infoProveedor);
            this.Controls.Add(this.dgv_ARol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsignarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Roles";
            this.GB_infoProveedor.ResumeLayout(false);
            this.GB_infoProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ARol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_BuscarProveedor;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button btn_EliminarProveedor;
        private System.Windows.Forms.Button btn_ModificarProveedor;
        private System.Windows.Forms.Button btn_AgregarProveedor;
        private System.Windows.Forms.Button btn_limpiarProveedor;
        private System.Windows.Forms.GroupBox GB_infoProveedor;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_Desccripcion_Proveedor;
        private System.Windows.Forms.Label lbl_N_Proveedor;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.DataGridView dgv_ARol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_id;
    }
}