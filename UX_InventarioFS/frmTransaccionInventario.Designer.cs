
namespace UX_InventarioFS
{
    partial class frmTransaccionInventario
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
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_notas = new System.Windows.Forms.TextBox();
            this.lbl_NCedula = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_idprod = new System.Windows.Forms.TextBox();
            this.txt_TT = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroUsuario)).BeginInit();
            this.GB_infoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Limpiar Formulario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Eliminar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Agregar";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::UX_InventarioFS.Properties.Resources.clean_user;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(30, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 55);
            this.button4.TabIndex = 77;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::UX_InventarioFS.Properties.Resources.borrar_usuario;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(402, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 76;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::UX_InventarioFS.Properties.Resources.user_edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(402, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 75;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UX_InventarioFS.Properties.Resources.Add_user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(402, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 74;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(778, 13);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(314, 24);
            this.txt_Buscar.TabIndex = 73;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // lbl_BCliente
            // 
            this.lbl_BCliente.AutoSize = true;
            this.lbl_BCliente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCliente.Location = new System.Drawing.Point(478, 13);
            this.lbl_BCliente.Name = "lbl_BCliente";
            this.lbl_BCliente.Size = new System.Drawing.Size(252, 25);
            this.lbl_BCliente.TabIndex = 72;
            this.lbl_BCliente.Text = "Ingrese el tipo de Transaccion";
            // 
            // Dgv_RegistroUsuario
            // 
            this.Dgv_RegistroUsuario.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegistroUsuario.Location = new System.Drawing.Point(483, 43);
            this.Dgv_RegistroUsuario.Name = "Dgv_RegistroUsuario";
            this.Dgv_RegistroUsuario.ReadOnly = true;
            this.Dgv_RegistroUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_RegistroUsuario.Size = new System.Drawing.Size(690, 313);
            this.Dgv_RegistroUsuario.TabIndex = 71;
            this.Dgv_RegistroUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RegistroUsuario_CellClick);
            // 
            // GB_infoUsuario
            // 
            this.GB_infoUsuario.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoUsuario.Controls.Add(this.label7);
            this.GB_infoUsuario.Controls.Add(this.dtpFechaRegistro);
            this.GB_infoUsuario.Controls.Add(this.label5);
            this.GB_infoUsuario.Controls.Add(this.txt_id);
            this.GB_infoUsuario.Controls.Add(this.txt_notas);
            this.GB_infoUsuario.Controls.Add(this.lbl_NCedula);
            this.GB_infoUsuario.Controls.Add(this.txt_cantidad);
            this.GB_infoUsuario.Controls.Add(this.lbl_Email);
            this.GB_infoUsuario.Controls.Add(this.txt_idprod);
            this.GB_infoUsuario.Controls.Add(this.txt_TT);
            this.GB_infoUsuario.Controls.Add(this.lbl_telefono);
            this.GB_infoUsuario.Controls.Add(this.lbl_Apellido);
            this.GB_infoUsuario.Controls.Add(this.lbl_Nombre);
            this.GB_infoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_infoUsuario.Location = new System.Drawing.Point(11, 13);
            this.GB_infoUsuario.Name = "GB_infoUsuario";
            this.GB_infoUsuario.Size = new System.Drawing.Size(385, 436);
            this.GB_infoUsuario.TabIndex = 70;
            this.GB_infoUsuario.TabStop = false;
            this.GB_infoUsuario.Text = "Ingrese Informacion de la orden de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Transaccion";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(164, 107);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(197, 24);
            this.dtpFechaRegistro.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Transaccion";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(318, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(46, 24);
            this.txt_id.TabIndex = 29;
            // 
            // txt_notas
            // 
            this.txt_notas.Location = new System.Drawing.Point(164, 355);
            this.txt_notas.Name = "txt_notas";
            this.txt_notas.Size = new System.Drawing.Size(200, 24);
            this.txt_notas.TabIndex = 28;
            // 
            // lbl_NCedula
            // 
            this.lbl_NCedula.AutoSize = true;
            this.lbl_NCedula.Location = new System.Drawing.Point(16, 355);
            this.lbl_NCedula.Name = "lbl_NCedula";
            this.lbl_NCedula.Size = new System.Drawing.Size(48, 18);
            this.lbl_NCedula.TabIndex = 27;
            this.lbl_NCedula.Text = "Notas";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(164, 285);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(200, 24);
            this.txt_cantidad.TabIndex = 25;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(16, 291);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(66, 18);
            this.lbl_Email.TabIndex = 23;
            this.lbl_Email.Text = "Cantidad";
            // 
            // txt_idprod
            // 
            this.txt_idprod.Location = new System.Drawing.Point(164, 221);
            this.txt_idprod.Name = "txt_idprod";
            this.txt_idprod.Size = new System.Drawing.Size(200, 24);
            this.txt_idprod.TabIndex = 22;
            // 
            // txt_TT
            // 
            this.txt_TT.Location = new System.Drawing.Point(164, 162);
            this.txt_TT.Name = "txt_TT";
            this.txt_TT.Size = new System.Drawing.Size(200, 24);
            this.txt_TT.TabIndex = 21;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(16, 227);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(110, 18);
            this.lbl_telefono.TabIndex = 20;
            this.lbl_telefono.Text = "ID del Producto";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(16, 162);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(61, 18);
            this.lbl_Apellido.TabIndex = 19;
            this.lbl_Apellido.Text = "Tipo de ";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(17, 95);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(88, 18);
            this.lbl_Nombre.TabIndex = 16;
            this.lbl_Nombre.Text = "Fecha de la ";
            // 
            // frmTransaccionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 553);
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
            this.Name = "frmTransaccionInventario";
            this.Text = "Transacciones  en el inventario";
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
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_notas;
        private System.Windows.Forms.Label lbl_NCedula;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_idprod;
        private System.Windows.Forms.TextBox txt_TT;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label7;
    }
}