
namespace Presentacion
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.txt_BuscarCliente = new System.Windows.Forms.TextBox();
            this.lbl_BCliente = new System.Windows.Forms.Label();
            this.Dgv_RegistroUsuario = new System.Windows.Forms.DataGridView();
            this.GB_infoUsuario = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.RB_Cuenta_Activa = new System.Windows.Forms.RadioButton();
            this.RB_activo = new System.Windows.Forms.RadioButton();
            this.cb_Tcedula = new System.Windows.Forms.ComboBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.lbl_NCedula = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_C_activa = new System.Windows.Forms.Label();
            this.lbl_FRegistro = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Nusuario = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroUsuario)).BeginInit();
            this.GB_infoUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(16, 10);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(334, 32);
            this.lbl_NempresaCliente.TabIndex = 39;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // txt_BuscarCliente
            // 
            this.txt_BuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarCliente.Location = new System.Drawing.Point(801, 395);
            this.txt_BuscarCliente.Name = "txt_BuscarCliente";
            this.txt_BuscarCliente.Size = new System.Drawing.Size(314, 24);
            this.txt_BuscarCliente.TabIndex = 30;
            this.txt_BuscarCliente.TextChanged += new System.EventHandler(this.txt_BuscarCliente_TextChanged);
            // 
            // lbl_BCliente
            // 
            this.lbl_BCliente.AutoSize = true;
            this.lbl_BCliente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCliente.Location = new System.Drawing.Point(501, 395);
            this.lbl_BCliente.Name = "lbl_BCliente";
            this.lbl_BCliente.Size = new System.Drawing.Size(289, 25);
            this.lbl_BCliente.TabIndex = 29;
            this.lbl_BCliente.Text = "Ingrese el nombre del colaborador ";
            // 
            // Dgv_RegistroUsuario
            // 
            this.Dgv_RegistroUsuario.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegistroUsuario.Location = new System.Drawing.Point(378, 425);
            this.Dgv_RegistroUsuario.Name = "Dgv_RegistroUsuario";
            this.Dgv_RegistroUsuario.ReadOnly = true;
            this.Dgv_RegistroUsuario.Size = new System.Drawing.Size(1060, 313);
            this.Dgv_RegistroUsuario.TabIndex = 27;
            this.Dgv_RegistroUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RegistroUsuario_CellClick_1);
            // 
            // GB_infoUsuario
            // 
            this.GB_infoUsuario.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoUsuario.Controls.Add(this.label3);
            this.GB_infoUsuario.Controls.Add(this.dtpFechaRegistro);
            this.GB_infoUsuario.Controls.Add(this.txt_id);
            this.GB_infoUsuario.Controls.Add(this.RB_Cuenta_Activa);
            this.GB_infoUsuario.Controls.Add(this.RB_activo);
            this.GB_infoUsuario.Controls.Add(this.cb_Tcedula);
            this.GB_infoUsuario.Controls.Add(this.txt_cedula);
            this.GB_infoUsuario.Controls.Add(this.lbl_NCedula);
            this.GB_infoUsuario.Controls.Add(this.txt_Email);
            this.GB_infoUsuario.Controls.Add(this.lbl_cedula);
            this.GB_infoUsuario.Controls.Add(this.lbl_Email);
            this.GB_infoUsuario.Controls.Add(this.txt_telefono);
            this.GB_infoUsuario.Controls.Add(this.txt_apellido);
            this.GB_infoUsuario.Controls.Add(this.lbl_telefono);
            this.GB_infoUsuario.Controls.Add(this.lbl_Apellido);
            this.GB_infoUsuario.Controls.Add(this.txt_nombre);
            this.GB_infoUsuario.Controls.Add(this.lbl_Nombre);
            this.GB_infoUsuario.Controls.Add(this.lbl_Estado);
            this.GB_infoUsuario.Controls.Add(this.lbl_C_activa);
            this.GB_infoUsuario.Controls.Add(this.lbl_FRegistro);
            this.GB_infoUsuario.Controls.Add(this.txt_Pass);
            this.GB_infoUsuario.Controls.Add(this.txt_Usuario);
            this.GB_infoUsuario.Controls.Add(this.lbl_Pass);
            this.GB_infoUsuario.Controls.Add(this.lbl_Nusuario);
            this.GB_infoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoUsuario.Location = new System.Drawing.Point(378, 26);
            this.GB_infoUsuario.Name = "GB_infoUsuario";
            this.GB_infoUsuario.Size = new System.Drawing.Size(776, 356);
            this.GB_infoUsuario.TabIndex = 26;
            this.GB_infoUsuario.TabStop = false;
            this.GB_infoUsuario.Text = "Ingrese Informacion del Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Asigne ID al Usuario";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(193, 195);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaRegistro.TabIndex = 38;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(193, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(204, 24);
            this.txt_id.TabIndex = 36;
            // 
            // RB_Cuenta_Activa
            // 
            this.RB_Cuenta_Activa.AutoSize = true;
            this.RB_Cuenta_Activa.Location = new System.Drawing.Point(193, 262);
            this.RB_Cuenta_Activa.Name = "RB_Cuenta_Activa";
            this.RB_Cuenta_Activa.Size = new System.Drawing.Size(65, 22);
            this.RB_Cuenta_Activa.TabIndex = 33;
            this.RB_Cuenta_Activa.TabStop = true;
            this.RB_Cuenta_Activa.Text = "Activa";
            this.RB_Cuenta_Activa.UseVisualStyleBackColor = true;
            // 
            // RB_activo
            // 
            this.RB_activo.AutoSize = true;
            this.RB_activo.Location = new System.Drawing.Point(193, 321);
            this.RB_activo.Name = "RB_activo";
            this.RB_activo.Size = new System.Drawing.Size(65, 22);
            this.RB_activo.TabIndex = 31;
            this.RB_activo.TabStop = true;
            this.RB_activo.Text = "Activa";
            this.RB_activo.UseVisualStyleBackColor = true;
            // 
            // cb_Tcedula
            // 
            this.cb_Tcedula.FormattingEnabled = true;
            this.cb_Tcedula.Items.AddRange(new object[] {
            "Nacional",
            "Extranjero",
            "Pasaporte",
            "Cedula Juridica"});
            this.cb_Tcedula.Location = new System.Drawing.Point(558, 254);
            this.cb_Tcedula.Name = "cb_Tcedula";
            this.cb_Tcedula.Size = new System.Drawing.Size(200, 26);
            this.cb_Tcedula.TabIndex = 30;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(558, 311);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(200, 24);
            this.txt_cedula.TabIndex = 28;
            // 
            // lbl_NCedula
            // 
            this.lbl_NCedula.AutoSize = true;
            this.lbl_NCedula.Location = new System.Drawing.Point(431, 318);
            this.lbl_NCedula.Name = "lbl_NCedula";
            this.lbl_NCedula.Size = new System.Drawing.Size(54, 18);
            this.lbl_NCedula.TabIndex = 27;
            this.lbl_NCedula.Text = "Cédula";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(558, 195);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 24);
            this.txt_Email.TabIndex = 25;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Location = new System.Drawing.Point(431, 262);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(107, 18);
            this.lbl_cedula.TabIndex = 24;
            this.lbl_cedula.Text = "Tipo de Cédula";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(431, 202);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 18);
            this.lbl_Email.TabIndex = 23;
            this.lbl_Email.Text = "Email";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(558, 144);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(200, 24);
            this.txt_telefono.TabIndex = 22;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(558, 86);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(200, 24);
            this.txt_apellido.TabIndex = 21;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(431, 151);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(66, 18);
            this.lbl_telefono.TabIndex = 20;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(431, 93);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(67, 18);
            this.lbl_Apellido.TabIndex = 19;
            this.lbl_Apellido.Text = "Apellidos";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(558, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 24);
            this.txt_nombre.TabIndex = 18;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(431, 33);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_Nombre.TabIndex = 16;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(23, 328);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(55, 18);
            this.lbl_Estado.TabIndex = 15;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_C_activa
            // 
            this.lbl_C_activa.AutoSize = true;
            this.lbl_C_activa.Location = new System.Drawing.Point(23, 262);
            this.lbl_C_activa.Name = "lbl_C_activa";
            this.lbl_C_activa.Size = new System.Drawing.Size(55, 18);
            this.lbl_C_activa.TabIndex = 12;
            this.lbl_C_activa.Text = "Cuenta";
            // 
            // lbl_FRegistro
            // 
            this.lbl_FRegistro.AutoSize = true;
            this.lbl_FRegistro.Location = new System.Drawing.Point(23, 200);
            this.lbl_FRegistro.Name = "lbl_FRegistro";
            this.lbl_FRegistro.Size = new System.Drawing.Size(109, 18);
            this.lbl_FRegistro.TabIndex = 11;
            this.lbl_FRegistro.Text = "Fecha Registro";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(193, 128);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(200, 24);
            this.txt_Pass.TabIndex = 6;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(193, 72);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(200, 24);
            this.txt_Usuario.TabIndex = 5;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(23, 131);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(85, 18);
            this.lbl_Pass.TabIndex = 1;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // lbl_Nusuario
            // 
            this.lbl_Nusuario.AutoSize = true;
            this.lbl_Nusuario.Location = new System.Drawing.Point(23, 78);
            this.lbl_Nusuario.Name = "lbl_Nusuario";
            this.lbl_Nusuario.Size = new System.Drawing.Size(60, 18);
            this.lbl_Nusuario.TabIndex = 0;
            this.lbl_Nusuario.Text = "Usuario";
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
            this.btn_EliminarCliente.Location = new System.Drawing.Point(95, 508);
            this.btn_EliminarCliente.Name = "btn_EliminarCliente";
            this.btn_EliminarCliente.Size = new System.Drawing.Size(242, 87);
            this.btn_EliminarCliente.TabIndex = 34;
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
            this.btn_ModificarCliente.Location = new System.Drawing.Point(95, 359);
            this.btn_ModificarCliente.Name = "btn_ModificarCliente";
            this.btn_ModificarCliente.Size = new System.Drawing.Size(242, 89);
            this.btn_ModificarCliente.TabIndex = 33;
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
            this.btn_AgregarCliente.Location = new System.Drawing.Point(95, 70);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(242, 89);
            this.btn_AgregarCliente.TabIndex = 32;
            this.btn_AgregarCliente.Text = "Agregar";
            this.btn_AgregarCliente.UseVisualStyleBackColor = false;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click_1);
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
            this.btn_limpiar.Location = new System.Drawing.Point(95, 215);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(242, 89);
            this.btn_limpiar.TabIndex = 31;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click_1);
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
            this.panel1.Controls.Add(this.btn_ModificarCliente);
            this.panel1.Controls.Add(this.btn_EliminarCliente);
            this.panel1.Controls.Add(this.btn_AgregarCliente);
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 757);
            this.panel1.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(22, 677);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 37);
            this.panel6.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(22, 530);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 37);
            this.panel5.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(22, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 37);
            this.panel4.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(22, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 37);
            this.panel3.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(22, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 37);
            this.panel2.TabIndex = 41;
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
            this.button1.Location = new System.Drawing.Point(95, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 87);
            this.button1.TabIndex = 40;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1450, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_BuscarCliente);
            this.Controls.Add(this.lbl_BCliente);
            this.Controls.Add(this.Dgv_RegistroUsuario);
            this.Controls.Add(this.GB_infoUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroUsuario)).EndInit();
            this.GB_infoUsuario.ResumeLayout(false);
            this.GB_infoUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.Button btn_EliminarCliente;
        private System.Windows.Forms.Button btn_ModificarCliente;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_BuscarCliente;
        private System.Windows.Forms.Label lbl_BCliente;
        private System.Windows.Forms.DataGridView Dgv_RegistroUsuario;
        private System.Windows.Forms.GroupBox GB_infoUsuario;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Nusuario;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_C_activa;
        private System.Windows.Forms.Label lbl_FRegistro;
        private System.Windows.Forms.ComboBox cb_Tcedula;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label lbl_NCedula;
        private System.Windows.Forms.RadioButton RB_activo;
        private System.Windows.Forms.RadioButton RB_Cuenta_Activa;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label3;
    }
}