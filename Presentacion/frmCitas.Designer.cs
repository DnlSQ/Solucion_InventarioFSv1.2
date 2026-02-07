
namespace Presentacion
{
    partial class frmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.txt_BuscarCitas = new System.Windows.Forms.TextBox();
            this.lbl_B_Citas = new System.Windows.Forms.Label();
            this.lbl_BuscarCitas = new System.Windows.Forms.Label();
            this.Dgv_RegistroCitas = new System.Windows.Forms.DataGridView();
            this.GB_infoCitas = new System.Windows.Forms.GroupBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_notas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idServicio = new System.Windows.Forms.TextBox();
            this.lbl_idServicio = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.txt_Servicio = new System.Windows.Forms.TextBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.lbl_servicio = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.txt_ID_Empleado = new System.Windows.Forms.TextBox();
            this.lbl_IDColaborador = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.txt_ID_cliente = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_NCliente = new System.Windows.Forms.Label();
            this.lbl_N_Cita = new System.Windows.Forms.Label();
            this.btn_EliminarCliente = new System.Windows.Forms.Button();
            this.btn_ModificarCliente = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dvg_cliente = new System.Windows.Forms.DataGridView();
            this.txt_B_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_B_Servicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_servicios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_B_Empleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Empleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroCitas)).BeginInit();
            this.GB_infoCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NempresaCliente
            // 
            resources.ApplyResources(this.lbl_NempresaCliente, "lbl_NempresaCliente");
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            // 
            // txt_BuscarCitas
            // 
            resources.ApplyResources(this.txt_BuscarCitas, "txt_BuscarCitas");
            this.txt_BuscarCitas.Name = "txt_BuscarCitas";
            this.txt_BuscarCitas.TextChanged += new System.EventHandler(this.txt_BuscarCitas_TextChanged_1);
            // 
            // lbl_B_Citas
            // 
            resources.ApplyResources(this.lbl_B_Citas, "lbl_B_Citas");
            this.lbl_B_Citas.Name = "lbl_B_Citas";
            // 
            // lbl_BuscarCitas
            // 
            resources.ApplyResources(this.lbl_BuscarCitas, "lbl_BuscarCitas");
            this.lbl_BuscarCitas.Name = "lbl_BuscarCitas";
            // 
            // Dgv_RegistroCitas
            // 
            this.Dgv_RegistroCitas.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Dgv_RegistroCitas, "Dgv_RegistroCitas");
            this.Dgv_RegistroCitas.Name = "Dgv_RegistroCitas";
            this.Dgv_RegistroCitas.ReadOnly = true;
            this.Dgv_RegistroCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_RegistroCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_RegistroCitas_CellClick_1);
            // 
            // GB_infoCitas
            // 
            this.GB_infoCitas.BackColor = System.Drawing.Color.FloralWhite;
            this.GB_infoCitas.Controls.Add(this.dtpFechaRegistro);
            this.GB_infoCitas.Controls.Add(this.txt_id);
            this.GB_infoCitas.Controls.Add(this.txt_notas);
            this.GB_infoCitas.Controls.Add(this.label3);
            this.GB_infoCitas.Controls.Add(this.txt_idServicio);
            this.GB_infoCitas.Controls.Add(this.lbl_idServicio);
            this.GB_infoCitas.Controls.Add(this.txt_empleado);
            this.GB_infoCitas.Controls.Add(this.lbl_empleado);
            this.GB_infoCitas.Controls.Add(this.txt_Servicio);
            this.GB_infoCitas.Controls.Add(this.txt_hora);
            this.GB_infoCitas.Controls.Add(this.lbl_servicio);
            this.GB_infoCitas.Controls.Add(this.lbl_hora);
            this.GB_infoCitas.Controls.Add(this.txt_ID_Empleado);
            this.GB_infoCitas.Controls.Add(this.lbl_IDColaborador);
            this.GB_infoCitas.Controls.Add(this.txt_Cliente);
            this.GB_infoCitas.Controls.Add(this.txt_ID_cliente);
            this.GB_infoCitas.Controls.Add(this.lbl_Fecha);
            this.GB_infoCitas.Controls.Add(this.lbl_NCliente);
            this.GB_infoCitas.Controls.Add(this.lbl_N_Cita);
            resources.ApplyResources(this.GB_infoCitas, "GB_infoCitas");
            this.GB_infoCitas.Name = "GB_infoCitas";
            this.GB_infoCitas.TabStop = false;
            // 
            // dtpFechaRegistro
            // 
            resources.ApplyResources(this.dtpFechaRegistro, "dtpFechaRegistro");
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            // 
            // txt_id
            // 
            resources.ApplyResources(this.txt_id, "txt_id");
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            // 
            // txt_notas
            // 
            resources.ApplyResources(this.txt_notas, "txt_notas");
            this.txt_notas.Name = "txt_notas";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_idServicio
            // 
            resources.ApplyResources(this.txt_idServicio, "txt_idServicio");
            this.txt_idServicio.Name = "txt_idServicio";
            // 
            // lbl_idServicio
            // 
            resources.ApplyResources(this.lbl_idServicio, "lbl_idServicio");
            this.lbl_idServicio.Name = "lbl_idServicio";
            // 
            // txt_empleado
            // 
            resources.ApplyResources(this.txt_empleado, "txt_empleado");
            this.txt_empleado.Name = "txt_empleado";
            // 
            // lbl_empleado
            // 
            resources.ApplyResources(this.lbl_empleado, "lbl_empleado");
            this.lbl_empleado.Name = "lbl_empleado";
            // 
            // txt_Servicio
            // 
            resources.ApplyResources(this.txt_Servicio, "txt_Servicio");
            this.txt_Servicio.Name = "txt_Servicio";
            // 
            // txt_hora
            // 
            resources.ApplyResources(this.txt_hora, "txt_hora");
            this.txt_hora.Name = "txt_hora";
            // 
            // lbl_servicio
            // 
            resources.ApplyResources(this.lbl_servicio, "lbl_servicio");
            this.lbl_servicio.Name = "lbl_servicio";
            // 
            // lbl_hora
            // 
            resources.ApplyResources(this.lbl_hora, "lbl_hora");
            this.lbl_hora.Name = "lbl_hora";
            // 
            // txt_ID_Empleado
            // 
            resources.ApplyResources(this.txt_ID_Empleado, "txt_ID_Empleado");
            this.txt_ID_Empleado.Name = "txt_ID_Empleado";
            // 
            // lbl_IDColaborador
            // 
            resources.ApplyResources(this.lbl_IDColaborador, "lbl_IDColaborador");
            this.lbl_IDColaborador.Name = "lbl_IDColaborador";
            // 
            // txt_Cliente
            // 
            resources.ApplyResources(this.txt_Cliente, "txt_Cliente");
            this.txt_Cliente.Name = "txt_Cliente";
            // 
            // txt_ID_cliente
            // 
            resources.ApplyResources(this.txt_ID_cliente, "txt_ID_cliente");
            this.txt_ID_cliente.Name = "txt_ID_cliente";
            // 
            // lbl_Fecha
            // 
            resources.ApplyResources(this.lbl_Fecha, "lbl_Fecha");
            this.lbl_Fecha.Name = "lbl_Fecha";
            // 
            // lbl_NCliente
            // 
            resources.ApplyResources(this.lbl_NCliente, "lbl_NCliente");
            this.lbl_NCliente.Name = "lbl_NCliente";
            // 
            // lbl_N_Cita
            // 
            resources.ApplyResources(this.lbl_N_Cita, "lbl_N_Cita");
            this.lbl_N_Cita.Name = "lbl_N_Cita";
            // 
            // btn_EliminarCliente
            // 
            this.btn_EliminarCliente.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_EliminarCliente, "btn_EliminarCliente");
            this.btn_EliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarCliente.FlatAppearance.BorderSize = 0;
            this.btn_EliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EliminarCliente.Name = "btn_EliminarCliente";
            this.btn_EliminarCliente.UseVisualStyleBackColor = false;
            this.btn_EliminarCliente.Click += new System.EventHandler(this.btn_EliminarCliente_Click);
            // 
            // btn_ModificarCliente
            // 
            this.btn_ModificarCliente.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_ModificarCliente, "btn_ModificarCliente");
            this.btn_ModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarCliente.FlatAppearance.BorderSize = 0;
            this.btn_ModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ModificarCliente.Name = "btn_ModificarCliente";
            this.btn_ModificarCliente.UseVisualStyleBackColor = false;
            this.btn_ModificarCliente.Click += new System.EventHandler(this.btn_ModificarCliente_Click);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_AgregarCliente, "btn_AgregarCliente");
            this.btn_AgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarCliente.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.UseVisualStyleBackColor = false;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_limpiar, "btn_limpiar");
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click_1);
            // 
            // dvg_cliente
            // 
            this.dvg_cliente.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dvg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dvg_cliente, "dvg_cliente");
            this.dvg_cliente.Name = "dvg_cliente";
            this.dvg_cliente.ReadOnly = true;
            this.dvg_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_cliente_CellClick_1);
            // 
            // txt_B_Cliente
            // 
            resources.ApplyResources(this.txt_B_Cliente, "txt_B_Cliente");
            this.txt_B_Cliente.Name = "txt_B_Cliente";
            this.txt_B_Cliente.TextChanged += new System.EventHandler(this.txt_B_Cliente_TextChanged_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt_B_Servicio
            // 
            resources.ApplyResources(this.txt_B_Servicio, "txt_B_Servicio");
            this.txt_B_Servicio.Name = "txt_B_Servicio";
            this.txt_B_Servicio.TextChanged += new System.EventHandler(this.txt_B_Servicio_TextChanged_1);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dgv_servicios
            // 
            this.dgv_servicios.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_servicios, "dgv_servicios");
            this.dgv_servicios.Name = "dgv_servicios";
            this.dgv_servicios.ReadOnly = true;
            this.dgv_servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_servicios_CellClick_1);
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
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.btn_AgregarCliente);
            this.panel1.Controls.Add(this.btn_ModificarCliente);
            this.panel1.Controls.Add(this.btn_EliminarCliente);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txt_B_Empleado
            // 
            resources.ApplyResources(this.txt_B_Empleado, "txt_B_Empleado");
            this.txt_B_Empleado.Name = "txt_B_Empleado";

            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // dgv_Empleado
            // 
            this.dgv_Empleado.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgv_Empleado, "dgv_Empleado");
            this.dgv_Empleado.Name = "dgv_Empleado";
            this.dgv_Empleado.ReadOnly = true;
            this.dgv_Empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleado_CellClick_1);
            // 
            // frmCitas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_B_Empleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_Empleado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_B_Servicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_servicios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_B_Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BuscarCitas);
            this.Controls.Add(this.lbl_B_Citas);
            this.Controls.Add(this.dvg_cliente);
            this.Controls.Add(this.lbl_BuscarCitas);
            this.Controls.Add(this.Dgv_RegistroCitas);
            this.Controls.Add(this.GB_infoCitas);
            this.Name = "frmCitas";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroCitas)).EndInit();
            this.GB_infoCitas.ResumeLayout(false);
            this.GB_infoCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.Button btn_EliminarCliente;
        private System.Windows.Forms.Button btn_ModificarCliente;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_BuscarCitas;
        private System.Windows.Forms.Label lbl_B_Citas;
        private System.Windows.Forms.Label lbl_BuscarCitas;
        private System.Windows.Forms.DataGridView Dgv_RegistroCitas;
        private System.Windows.Forms.GroupBox GB_infoCitas;
        private System.Windows.Forms.TextBox txt_Servicio;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label lbl_servicio;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.TextBox txt_ID_Empleado;
        private System.Windows.Forms.Label lbl_IDColaborador;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.TextBox txt_ID_cliente;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_NCliente;
        private System.Windows.Forms.Label lbl_N_Cita;
        private System.Windows.Forms.TextBox txt_idServicio;
        private System.Windows.Forms.Label lbl_idServicio;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.DataGridView dvg_cliente;
        private System.Windows.Forms.TextBox txt_B_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_notas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_B_Servicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_servicios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_B_Empleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Empleado;
    }
}