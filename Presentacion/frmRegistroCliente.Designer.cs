
namespace Presentacion
{
    partial class frmRegistroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCliente));
            this.GB_infoCliente = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cb_Tcedula = new System.Windows.Forms.ComboBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.lbl_NCedula = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.txt_Ncliente = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Ncliente = new System.Windows.Forms.Label();
            this.Dgv_RegistroClientes = new System.Windows.Forms.DataGridView();
            this.lbl_BCliente = new System.Windows.Forms.Label();
            this.txt_BuscarCliente = new System.Windows.Forms.TextBox();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.btn_EliminarCliente = new System.Windows.Forms.Button();
            this.btn_ModificarCliente = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GB_infoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_infoCliente
            // 
            this.GB_infoCliente.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoCliente.Controls.Add(this.txt_id);
            this.GB_infoCliente.Controls.Add(this.cb_Tcedula);
            this.GB_infoCliente.Controls.Add(this.txt_cedula);
            this.GB_infoCliente.Controls.Add(this.lbl_NCedula);
            this.GB_infoCliente.Controls.Add(this.lbl_cedula);
            this.GB_infoCliente.Controls.Add(this.txt_email);
            this.GB_infoCliente.Controls.Add(this.txt_telefono);
            this.GB_infoCliente.Controls.Add(this.lbl_telefono);
            this.GB_infoCliente.Controls.Add(this.txt_Apellido1);
            this.GB_infoCliente.Controls.Add(this.txt_Ncliente);
            this.GB_infoCliente.Controls.Add(this.lbl_Email);
            this.GB_infoCliente.Controls.Add(this.lbl_Apellido);
            this.GB_infoCliente.Controls.Add(this.lbl_Ncliente);
            this.GB_infoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoCliente.Location = new System.Drawing.Point(390, 12);
            this.GB_infoCliente.Name = "GB_infoCliente";
            this.GB_infoCliente.Size = new System.Drawing.Size(790, 201);
            this.GB_infoCliente.TabIndex = 1;
            this.GB_infoCliente.TabStop = false;
            this.GB_infoCliente.Text = "Ingrese Informacion del Cliente";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(135, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(47, 24);
            this.txt_id.TabIndex = 35;
            this.txt_id.Visible = false;
            // 
            // cb_Tcedula
            // 
            this.cb_Tcedula.FormattingEnabled = true;
            this.cb_Tcedula.Items.AddRange(new object[] {
            "Nacional",
            "Extranjero",
            "Pasaporte",
            "Cedula Juridica"});
            this.cb_Tcedula.Location = new System.Drawing.Point(528, 98);
            this.cb_Tcedula.Name = "cb_Tcedula";
            this.cb_Tcedula.Size = new System.Drawing.Size(235, 26);
            this.cb_Tcedula.TabIndex = 34;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(528, 146);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(235, 24);
            this.txt_cedula.TabIndex = 33;
            // 
            // lbl_NCedula
            // 
            this.lbl_NCedula.AutoSize = true;
            this.lbl_NCedula.Location = new System.Drawing.Point(399, 149);
            this.lbl_NCedula.Name = "lbl_NCedula";
            this.lbl_NCedula.Size = new System.Drawing.Size(54, 18);
            this.lbl_NCedula.TabIndex = 32;
            this.lbl_NCedula.Text = "Cédula";
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Location = new System.Drawing.Point(399, 101);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(107, 18);
            this.lbl_cedula.TabIndex = 31;
            this.lbl_cedula.Text = "Tipo de Cédula";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(528, 48);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(235, 24);
            this.txt_email.TabIndex = 11;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(133, 146);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(200, 24);
            this.txt_telefono.TabIndex = 10;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(18, 153);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(66, 18);
            this.lbl_telefono.TabIndex = 9;
            this.lbl_telefono.Text = "Telefono";
            // 
            // txt_Apellido1
            // 
            this.txt_Apellido1.Location = new System.Drawing.Point(135, 101);
            this.txt_Apellido1.Name = "txt_Apellido1";
            this.txt_Apellido1.Size = new System.Drawing.Size(200, 24);
            this.txt_Apellido1.TabIndex = 6;
            // 
            // txt_Ncliente
            // 
            this.txt_Ncliente.Location = new System.Drawing.Point(135, 52);
            this.txt_Ncliente.Name = "txt_Ncliente";
            this.txt_Ncliente.Size = new System.Drawing.Size(200, 24);
            this.txt_Ncliente.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(399, 51);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 18);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(19, 101);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(67, 18);
            this.lbl_Apellido.TabIndex = 1;
            this.lbl_Apellido.Text = "Apellidos";
            // 
            // lbl_Ncliente
            // 
            this.lbl_Ncliente.AutoSize = true;
            this.lbl_Ncliente.Location = new System.Drawing.Point(18, 55);
            this.lbl_Ncliente.Name = "lbl_Ncliente";
            this.lbl_Ncliente.Size = new System.Drawing.Size(62, 18);
            this.lbl_Ncliente.TabIndex = 0;
            this.lbl_Ncliente.Text = "Nombre";
            // 
            // Dgv_RegistroClientes
            // 
            this.Dgv_RegistroClientes.AllowUserToAddRows = false;
            this.Dgv_RegistroClientes.AllowUserToDeleteRows = false;
            this.Dgv_RegistroClientes.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegistroClientes.Location = new System.Drawing.Point(390, 286);
            this.Dgv_RegistroClientes.Name = "Dgv_RegistroClientes";
            this.Dgv_RegistroClientes.ReadOnly = true;
            this.Dgv_RegistroClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_RegistroClientes.Size = new System.Drawing.Size(789, 402);
            this.Dgv_RegistroClientes.TabIndex = 2;
            this.Dgv_RegistroClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RegistroClientes_CellClick);
            // 
            // lbl_BCliente
            // 
            this.lbl_BCliente.AutoSize = true;
            this.lbl_BCliente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCliente.Location = new System.Drawing.Point(408, 250);
            this.lbl_BCliente.Name = "lbl_BCliente";
            this.lbl_BCliente.Size = new System.Drawing.Size(238, 25);
            this.lbl_BCliente.TabIndex = 4;
            this.lbl_BCliente.Text = "Ingrese le numero de cedúla";
            // 
            // txt_BuscarCliente
            // 
            this.txt_BuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarCliente.Location = new System.Drawing.Point(662, 250);
            this.txt_BuscarCliente.Name = "txt_BuscarCliente";
            this.txt_BuscarCliente.Size = new System.Drawing.Size(302, 24);
            this.txt_BuscarCliente.TabIndex = 16;
            this.txt_BuscarCliente.TextChanged += new System.EventHandler(this.txt_BuscarCliente_TextChanged);
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(23, 18);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(334, 32);
            this.lbl_NempresaCliente.TabIndex = 25;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // btn_EliminarCliente
            // 
            this.btn_EliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_EliminarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCliente.BackgroundImage")));
            this.btn_EliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarCliente.FlatAppearance.BorderSize = 0;
            this.btn_EliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarCliente.Location = new System.Drawing.Point(99, 496);
            this.btn_EliminarCliente.Name = "btn_EliminarCliente";
            this.btn_EliminarCliente.Size = new System.Drawing.Size(254, 75);
            this.btn_EliminarCliente.TabIndex = 20;
            this.btn_EliminarCliente.Text = "Eliminar";
            this.btn_EliminarCliente.UseVisualStyleBackColor = false;
            this.btn_EliminarCliente.Click += new System.EventHandler(this.btn_EliminarCliente_Click);
            // 
            // btn_ModificarCliente
            // 
            this.btn_ModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModificarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarCliente.BackgroundImage")));
            this.btn_ModificarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarCliente.FlatAppearance.BorderSize = 0;
            this.btn_ModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarCliente.Location = new System.Drawing.Point(99, 362);
            this.btn_ModificarCliente.Name = "btn_ModificarCliente";
            this.btn_ModificarCliente.Size = new System.Drawing.Size(254, 75);
            this.btn_ModificarCliente.TabIndex = 19;
            this.btn_ModificarCliente.Text = "Modificar";
            this.btn_ModificarCliente.UseVisualStyleBackColor = false;
            this.btn_ModificarCliente.Click += new System.EventHandler(this.btn_ModificarCliente_Click);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_AgregarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCliente.BackgroundImage")));
            this.btn_AgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarCliente.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCliente.Location = new System.Drawing.Point(99, 93);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(254, 75);
            this.btn_AgregarCliente.TabIndex = 18;
            this.btn_AgregarCliente.Text = "Agregar";
            this.btn_AgregarCliente.UseVisualStyleBackColor = false;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.BackgroundImage")));
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Location = new System.Drawing.Point(99, 228);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(254, 75);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
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
            this.panel1.Controls.Add(this.btn_EliminarCliente);
            this.panel1.Controls.Add(this.btn_AgregarCliente);
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.btn_ModificarCliente);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 715);
            this.panel1.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(29, 644);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(43, 39);
            this.panel6.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(29, 510);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(43, 39);
            this.panel5.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(29, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 39);
            this.panel4.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(29, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 39);
            this.panel3.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(29, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 39);
            this.panel2.TabIndex = 27;
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
            this.button1.Location = new System.Drawing.Point(99, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 75);
            this.button1.TabIndex = 26;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistroCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_BuscarCliente);
            this.Controls.Add(this.lbl_BCliente);
            this.Controls.Add(this.Dgv_RegistroClientes);
            this.Controls.Add(this.GB_infoCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            this.GB_infoCliente.ResumeLayout(false);
            this.GB_infoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_infoCliente;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_Apellido1;
        private System.Windows.Forms.TextBox txt_Ncliente;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Ncliente;
        private System.Windows.Forms.DataGridView Dgv_RegistroClientes;
        private System.Windows.Forms.Label lbl_BCliente;
        private System.Windows.Forms.TextBox txt_BuscarCliente;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_ModificarCliente;
        private System.Windows.Forms.Button btn_EliminarCliente;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.ComboBox cb_Tcedula;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label lbl_NCedula;
        private System.Windows.Forms.Label lbl_cedula;
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