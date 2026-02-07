
namespace Presentacion
{
    partial class frmConsultarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarProveedor));
            this.txt_BuscarProveedor = new System.Windows.Forms.TextBox();
            this.lbl_B_Proveedor = new System.Windows.Forms.Label();
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.dgv_proveedor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BuscarProveedor
            // 
            this.txt_BuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarProveedor.Location = new System.Drawing.Point(221, 14);
            this.txt_BuscarProveedor.Name = "txt_BuscarProveedor";
            this.txt_BuscarProveedor.Size = new System.Drawing.Size(227, 26);
            this.txt_BuscarProveedor.TabIndex = 58;
            this.txt_BuscarProveedor.TextChanged += new System.EventHandler(this.txt_BuscarProveedor_TextChanged);
            // 
            // lbl_B_Proveedor
            // 
            this.lbl_B_Proveedor.AutoSize = true;
            this.lbl_B_Proveedor.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_B_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B_Proveedor.Location = new System.Drawing.Point(30, 11);
            this.lbl_B_Proveedor.Name = "lbl_B_Proveedor";
            this.lbl_B_Proveedor.Size = new System.Drawing.Size(184, 25);
            this.lbl_B_Proveedor.TabIndex = 57;
            this.lbl_B_Proveedor.Text = "Buscar Proveedor";
            // 
            // lbl_NempresaCliente
            // 
            this.lbl_NempresaCliente.AutoSize = true;
            this.lbl_NempresaCliente.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_NempresaCliente.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaCliente.Location = new System.Drawing.Point(12, 451);
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            this.lbl_NempresaCliente.Size = new System.Drawing.Size(360, 35);
            this.lbl_NempresaCliente.TabIndex = 55;
            this.lbl_NempresaCliente.Text = "Elegancia Integral S.A.";
            // 
            // dgv_proveedor
            // 
            this.dgv_proveedor.AllowUserToAddRows = false;
            this.dgv_proveedor.AllowUserToDeleteRows = false;
            this.dgv_proveedor.AllowUserToOrderColumns = true;
            this.dgv_proveedor.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedor.Location = new System.Drawing.Point(12, 70);
            this.dgv_proveedor.Name = "dgv_proveedor";
            this.dgv_proveedor.ReadOnly = true;
            this.dgv_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_proveedor.Size = new System.Drawing.Size(887, 364);
            this.dgv_proveedor.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lbl_B_Proveedor);
            this.panel1.Controls.Add(this.txt_BuscarProveedor);
            this.panel1.Location = new System.Drawing.Point(206, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 51);
            this.panel1.TabIndex = 59;
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
            this.button1.Location = new System.Drawing.Point(744, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 59);
            this.button1.TabIndex = 60;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(690, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 39);
            this.panel2.TabIndex = 61;
            // 
            // frmConsultarProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_NempresaCliente);
            this.Controls.Add(this.dgv_proveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BuscarProveedor;
        private System.Windows.Forms.Label lbl_B_Proveedor;
        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.DataGridView dgv_proveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}