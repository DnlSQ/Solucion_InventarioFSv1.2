
namespace Presentacion
{
    partial class frmConsultaCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCitas));
            this.lbl_NempresaCliente = new System.Windows.Forms.Label();
            this.txt_BuscarCitas = new System.Windows.Forms.TextBox();
            this.lbl_B_Citas = new System.Windows.Forms.Label();
            this.Dgv_RegistroCitas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroCitas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NempresaCliente
            // 
            resources.ApplyResources(this.lbl_NempresaCliente, "lbl_NempresaCliente");
            this.lbl_NempresaCliente.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_NempresaCliente.Name = "lbl_NempresaCliente";
            // 
            // txt_BuscarCitas
            // 
            resources.ApplyResources(this.txt_BuscarCitas, "txt_BuscarCitas");
            this.txt_BuscarCitas.Name = "txt_BuscarCitas";
            // 
            // lbl_B_Citas
            // 
            resources.ApplyResources(this.lbl_B_Citas, "lbl_B_Citas");
            this.lbl_B_Citas.Name = "lbl_B_Citas";
            // 
            // Dgv_RegistroCitas
            // 
            this.Dgv_RegistroCitas.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.Dgv_RegistroCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Dgv_RegistroCitas, "Dgv_RegistroCitas");
            this.Dgv_RegistroCitas.Name = "Dgv_RegistroCitas";
            this.Dgv_RegistroCitas.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lbl_B_Citas);
            this.panel1.Controls.Add(this.txt_BuscarCitas);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // frmConsultaCitas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_NempresaCliente);
            this.Controls.Add(this.Dgv_RegistroCitas);
            this.Name = "frmConsultaCitas";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegistroCitas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NempresaCliente;
        private System.Windows.Forms.TextBox txt_BuscarCitas;
        private System.Windows.Forms.Label lbl_B_Citas;
        private System.Windows.Forms.DataGridView Dgv_RegistroCitas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}