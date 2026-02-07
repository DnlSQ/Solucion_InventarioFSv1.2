
namespace Presentacion
{
    partial class frmConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClientes));
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_C_buscar = new System.Windows.Forms.TextBox();
            this.dgv_consultaCliente = new System.Windows.Forms.DataGridView();
            this.lbl_NempresaConsultaCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(33, 15);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(291, 25);
            this.lbl_buscar.TabIndex = 1;
            this.lbl_buscar.Text = "Ingrese el Numero de Cedúla";
            // 
            // txt_C_buscar
            // 
            this.txt_C_buscar.Location = new System.Drawing.Point(344, 18);
            this.txt_C_buscar.Name = "txt_C_buscar";
            this.txt_C_buscar.Size = new System.Drawing.Size(277, 24);
            this.txt_C_buscar.TabIndex = 2;
            this.txt_C_buscar.TextChanged += new System.EventHandler(this.txt_C_buscar_TextChanged);
            // 
            // dgv_consultaCliente
            // 
            this.dgv_consultaCliente.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgv_consultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultaCliente.Location = new System.Drawing.Point(16, 110);
            this.dgv_consultaCliente.Name = "dgv_consultaCliente";
            this.dgv_consultaCliente.ReadOnly = true;
            this.dgv_consultaCliente.Size = new System.Drawing.Size(1053, 290);
            this.dgv_consultaCliente.TabIndex = 3;
            // 
            // lbl_NempresaConsultaCliente
            // 
            this.lbl_NempresaConsultaCliente.AutoSize = true;
            this.lbl_NempresaConsultaCliente.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_NempresaConsultaCliente.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NempresaConsultaCliente.Location = new System.Drawing.Point(12, 422);
            this.lbl_NempresaConsultaCliente.Name = "lbl_NempresaConsultaCliente";
            this.lbl_NempresaConsultaCliente.Size = new System.Drawing.Size(360, 35);
            this.lbl_NempresaConsultaCliente.TabIndex = 26;
            this.lbl_NempresaConsultaCliente.Text = "Elegancia Integral S.A.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lbl_buscar);
            this.panel1.Controls.Add(this.txt_C_buscar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(213, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 70);
            this.panel1.TabIndex = 27;
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
            this.button1.Location = new System.Drawing.Point(916, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 52);
            this.button1.TabIndex = 28;
            this.button1.Text = "Regresar al Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(868, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 36);
            this.panel2.TabIndex = 29;
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1089, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_NempresaConsultaCliente);
            this.Controls.Add(this.dgv_consultaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultaCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_C_buscar;
        private System.Windows.Forms.DataGridView dgv_consultaCliente;
        private System.Windows.Forms.Label lbl_NempresaConsultaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}