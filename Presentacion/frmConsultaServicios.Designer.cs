
namespace Presentacion
{
    partial class frmConsultaServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaServicios));
            this.txt_BuscarServicio = new System.Windows.Forms.TextBox();
            this.lbl_B_Proveedor = new System.Windows.Forms.Label();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.dgv_servicios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BuscarServicio
            // 
            this.txt_BuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarServicio.Location = new System.Drawing.Point(239, 12);
            this.txt_BuscarServicio.Name = "txt_BuscarServicio";
            this.txt_BuscarServicio.Size = new System.Drawing.Size(303, 26);
            this.txt_BuscarServicio.TabIndex = 63;
            this.txt_BuscarServicio.TextChanged += new System.EventHandler(this.txt_BuscarServicio_TextChanged);
            // 
            // lbl_B_Proveedor
            // 
            this.lbl_B_Proveedor.AutoSize = true;
            this.lbl_B_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_Proveedor.Location = new System.Drawing.Point(47, 9);
            this.lbl_B_Proveedor.Name = "lbl_B_Proveedor";
            this.lbl_B_Proveedor.Size = new System.Drawing.Size(173, 25);
            this.lbl_B_Proveedor.TabIndex = 62;
            this.lbl_B_Proveedor.Text = "Buscar Servicios";
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(12, 451);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(360, 35);
            this.lbl_NempresaCliente.TabIndex = 60;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // dgv_servicios
            // 
            this.dgv_servicios.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicios.Location = new System.Drawing.Point(12, 67);
            this.dgv_servicios.Name = "dgv_servicios";
            this.dgv_servicios.ReadOnly = true;
            this.dgv_servicios.Size = new System.Drawing.Size(918, 364);
            this.dgv_servicios.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lbl_B_Proveedor);
            this.panel1.Controls.Add(this.txt_BuscarServicio);
            this.panel1.Location = new System.Drawing.Point(200, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 49);
            this.panel1.TabIndex = 64;
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(791, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 55);
            this.button1.TabIndex = 65;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(749, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 36);
            this.panel2.TabIndex = 66;
            // 
            // frmConsultaServicios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(945, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_NempresaCliente);
            this.Controls.Add(this.dgv_servicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BuscarServicio;
        private System.Windows.Forms.Label lbl_B_Proveedor;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.DataGridView dgv_servicios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}