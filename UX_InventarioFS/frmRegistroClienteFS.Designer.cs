
namespace UX_InventarioFS
{
    partial class frmRegistroClienteFS
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroUsuario)).BeginInit();
            this.GB_infoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Limpiar Formulario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Eliminar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Agregar";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::UX_InventarioFS.Properties.Resources.clean_user;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(24, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 55);
            this.button4.TabIndex = 49;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::UX_InventarioFS.Properties.Resources.borrar_usuario;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(396, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 48;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::UX_InventarioFS.Properties.Resources.user_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(396, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UX_InventarioFS.Properties.Resources.Add_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(396, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(772, 7);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(314, 24);
            this.txt_Buscar.TabIndex = 45;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // lbl_BCliente
            // 
            this.lbl_BCliente.AutoSize = true;
            this.lbl_BCliente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCliente.Location = new System.Drawing.Point(472, 7);
            this.lbl_BCliente.Name = "lbl_BCliente";
            this.lbl_BCliente.Size = new System.Drawing.Size(244, 25);
            this.lbl_BCliente.TabIndex = 44;
            this.lbl_BCliente.Text = "Ingrese el nombre del Cliente";
            // 
            // Dgv_RegistroUsuario
            // 
            this.Dgv_RegistroUsuario.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegistroUsuario.Location = new System.Drawing.Point(477, 37);
            this.Dgv_RegistroUsuario.Name = "Dgv_RegistroUsuario";
            this.Dgv_RegistroUsuario.ReadOnly = true;
            this.Dgv_RegistroUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_RegistroUsuario.Size = new System.Drawing.Size(690, 313);
            this.Dgv_RegistroUsuario.TabIndex = 43;
            this.Dgv_RegistroUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RegistroUsuario_CellClick);
            // 
            // GB_infoUsuario
            // 
            this.GB_infoUsuario.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoUsuario.Controls.Add(this.txt_id);
            this.GB_infoUsuario.Controls.Add(this.txt_telefono);
            this.GB_infoUsuario.Controls.Add(this.lbl_Email);
            this.GB_infoUsuario.Controls.Add(this.txt_correo);
            this.GB_infoUsuario.Controls.Add(this.txt_Apellido);
            this.GB_infoUsuario.Controls.Add(this.lbl_telefono);
            this.GB_infoUsuario.Controls.Add(this.lbl_Apellido);
            this.GB_infoUsuario.Controls.Add(this.txt_nombre);
            this.GB_infoUsuario.Controls.Add(this.lbl_Nombre);
            this.GB_infoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoUsuario.Location = new System.Drawing.Point(5, 7);
            this.GB_infoUsuario.Name = "GB_infoUsuario";
            this.GB_infoUsuario.Size = new System.Drawing.Size(385, 422);
            this.GB_infoUsuario.TabIndex = 42;
            this.GB_infoUsuario.TabStop = false;
            this.GB_infoUsuario.Text = "Ingrese Informacion del Cliente";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(318, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(46, 24);
            this.txt_id.TabIndex = 29;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(164, 285);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(200, 24);
            this.txt_telefono.TabIndex = 25;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(16, 291);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(66, 18);
            this.lbl_Email.TabIndex = 23;
            this.lbl_Email.Text = "Telefono";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(164, 214);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(200, 24);
            this.txt_correo.TabIndex = 22;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(164, 156);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(200, 24);
            this.txt_Apellido.TabIndex = 21;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(16, 220);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(45, 18);
            this.lbl_telefono.TabIndex = 20;
            this.lbl_telefono.Text = "Email";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(16, 162);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(59, 18);
            this.lbl_Apellido.TabIndex = 19;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(164, 96);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 24);
            this.txt_nombre.TabIndex = 18;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(16, 102);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(134, 18);
            this.lbl_Nombre.TabIndex = 16;
            this.lbl_Nombre.Text = "Nombre del Cliente";
            // 
            // frmRegistroClienteFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 545);
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
            this.Name = "frmRegistroClienteFS";
            this.Text = "Registro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroUsuario)).EndInit();
            this.GB_infoUsuario.ResumeLayout(false);
            this.GB_infoUsuario.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_Nombre;
    }
}