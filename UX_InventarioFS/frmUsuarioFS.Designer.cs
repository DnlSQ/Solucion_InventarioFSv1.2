
namespace UX_InventarioFS
{
    partial class frmUsuarioFS
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_BCliente = new System.Windows.Forms.Label();
            this.Dgv_RegistroUsuario = new System.Windows.Forms.DataGridView();
            this.GB_infoUsuario = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_UxR = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_idEmpleado = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.Dgv_RegistroEmpleado = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroUsuario)).BeginInit();
            this.GB_infoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Limpiar Formulario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Eliminar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Agregar";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::UX_InventarioFS.Properties.Resources.clean_user;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(401, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 55);
            this.button4.TabIndex = 61;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::UX_InventarioFS.Properties.Resources.borrar_usuario;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(401, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 60;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::UX_InventarioFS.Properties.Resources.user_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(401, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 59;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UX_InventarioFS.Properties.Resources.Add_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(401, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(777, 8);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(314, 24);
            this.txt_Buscar.TabIndex = 57;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // lbl_BCliente
            // 
            this.lbl_BCliente.AutoSize = true;
            this.lbl_BCliente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCliente.Location = new System.Drawing.Point(477, 8);
            this.lbl_BCliente.Name = "lbl_BCliente";
            this.lbl_BCliente.Size = new System.Drawing.Size(246, 25);
            this.lbl_BCliente.TabIndex = 56;
            this.lbl_BCliente.Text = "Ingrese el nombre de Usuario";
            // 
            // Dgv_RegistroUsuario
            // 
            this.Dgv_RegistroUsuario.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegistroUsuario.Location = new System.Drawing.Point(482, 38);
            this.Dgv_RegistroUsuario.Name = "Dgv_RegistroUsuario";
            this.Dgv_RegistroUsuario.ReadOnly = true;
            this.Dgv_RegistroUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_RegistroUsuario.Size = new System.Drawing.Size(690, 213);
            this.Dgv_RegistroUsuario.TabIndex = 55;
            this.Dgv_RegistroUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RegistroUsuario_CellClick);
            // 
            // GB_infoUsuario
            // 
            this.GB_infoUsuario.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoUsuario.Controls.Add(this.txt_rol);
            this.GB_infoUsuario.Controls.Add(this.label8);
            this.GB_infoUsuario.Controls.Add(this.label6);
            this.GB_infoUsuario.Controls.Add(this.dgv_UxR);
            this.GB_infoUsuario.Controls.Add(this.txt_id);
            this.GB_infoUsuario.Controls.Add(this.txt_idEmpleado);
            this.GB_infoUsuario.Controls.Add(this.txt_Pass);
            this.GB_infoUsuario.Controls.Add(this.lbl_telefono);
            this.GB_infoUsuario.Controls.Add(this.lbl_Apellido);
            this.GB_infoUsuario.Controls.Add(this.txt_nombre);
            this.GB_infoUsuario.Controls.Add(this.lbl_Nombre);
            this.GB_infoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoUsuario.Location = new System.Drawing.Point(10, 8);
            this.GB_infoUsuario.Name = "GB_infoUsuario";
            this.GB_infoUsuario.Size = new System.Drawing.Size(385, 538);
            this.GB_infoUsuario.TabIndex = 54;
            this.GB_infoUsuario.TabStop = false;
            this.GB_infoUsuario.Text = "Ingrese Informacion para crear el Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 70;
            this.label8.Text = "Asigne el Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Roles para asignar ";
            // 
            // dgv_UxR
            // 
            this.dgv_UxR.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_UxR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UxR.Location = new System.Drawing.Point(82, 330);
            this.dgv_UxR.Name = "dgv_UxR";
            this.dgv_UxR.ReadOnly = true;
            this.dgv_UxR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UxR.Size = new System.Drawing.Size(282, 137);
            this.dgv_UxR.TabIndex = 68;
            this.dgv_UxR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UxR_CellClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(318, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(46, 24);
            this.txt_id.TabIndex = 29;
            // 
            // txt_idEmpleado
            // 
            this.txt_idEmpleado.Location = new System.Drawing.Point(164, 235);
            this.txt_idEmpleado.Name = "txt_idEmpleado";
            this.txt_idEmpleado.Size = new System.Drawing.Size(200, 24);
            this.txt_idEmpleado.TabIndex = 22;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(164, 177);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(200, 24);
            this.txt_Pass.TabIndex = 21;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(16, 241);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(116, 18);
            this.lbl_telefono.TabIndex = 20;
            this.lbl_telefono.Text = "ID del Empleado";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(16, 183);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(85, 18);
            this.lbl_Apellido.TabIndex = 19;
            this.lbl_Apellido.Text = "Contraseña";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(164, 117);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 24);
            this.txt_nombre.TabIndex = 18;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(16, 123);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(138, 18);
            this.lbl_Nombre.TabIndex = 16;
            this.lbl_Nombre.Text = "Nombre de Usuario";
            // 
            // Dgv_RegistroEmpleado
            // 
            this.Dgv_RegistroEmpleado.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegistroEmpleado.Location = new System.Drawing.Point(482, 331);
            this.Dgv_RegistroEmpleado.Name = "Dgv_RegistroEmpleado";
            this.Dgv_RegistroEmpleado.ReadOnly = true;
            this.Dgv_RegistroEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_RegistroEmpleado.Size = new System.Drawing.Size(690, 198);
            this.Dgv_RegistroEmpleado.TabIndex = 66;
            this.Dgv_RegistroEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RegistroEmpleado_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "Empleado";
            // 
            // txt_rol
            // 
            this.txt_rol.Location = new System.Drawing.Point(164, 494);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.Size = new System.Drawing.Size(200, 24);
            this.txt_rol.TabIndex = 71;
            // 
            // frmUsuarioFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_RegistroEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.lbl_BCliente);
            this.Controls.Add(this.Dgv_RegistroUsuario);
            this.Controls.Add(this.GB_infoUsuario);
            this.Name = "frmUsuarioFS";
            this.Text = "Crear Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroUsuario)).EndInit();
            this.GB_infoUsuario.ResumeLayout(false);
            this.GB_infoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_BCliente;
        private System.Windows.Forms.DataGridView Dgv_RegistroUsuario;
        private System.Windows.Forms.GroupBox GB_infoUsuario;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_idEmpleado;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridView Dgv_RegistroEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_UxR;
        private System.Windows.Forms.TextBox txt_rol;
    }
}