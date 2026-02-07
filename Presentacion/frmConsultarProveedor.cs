using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2;

namespace Presentacion
{
    public partial class frmConsultarProveedor : Form
    {
        public List<Proveedor> listaConsultarProveedor { get; set; }
        public frmConsultarProveedor()
        {
            InitializeComponent(); 
            CargarListado();
        }

        private void CargarListado()
        {
            try
            {
                List<Proveedor> lstaresultado = Logica.ConsultarProveedor(new Proveedor());
                listaConsultarProveedor = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID PRoveedor");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("Telefono");

                foreach (Proveedor item in lstaresultado)
                {
                    dt.Rows.Add(item.IDProveedor,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Telefono);
                }

                dgv_proveedor.DataSource = dt;
                dgv_proveedor.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void txt_BuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Proveedor> filtrado = listaConsultarProveedor;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarProveedor.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.P_Nombre.ToString().Contains(txt_BuscarProveedor.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID PRoveedor");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Telefono");

                    foreach (Proveedor item in filtrado)
                    {
                        dt.Rows.Add(item.IDProveedor,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Telefono);
                    }

                    dgv_proveedor.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID PRoveedor");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Telefono");

                    foreach (Proveedor item in filtrado)
                    {
                        dt.Rows.Add(item.IDProveedor,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Telefono);
                    }

                    dgv_proveedor.DataSource = dt;
                }
                dgv_proveedor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            Close();
        }
    }
}
