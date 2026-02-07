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
    public partial class frmConsultaInventario : Form
    {
        public List<Inventario> listaConsultarInventario { get; set; }
        public frmConsultaInventario()
        {
            InitializeComponent();
            CargarListado();
        }

        private void CargarListado()
        {
            try
            {
                List<Inventario> lstaresultado = Logica.ConsultarInventario(new Inventario());
                listaConsultarInventario = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Producto");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Unidad de Medida");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("ID Proveedor");

                foreach (Inventario item in lstaresultado)
                {
                    dt.Rows.Add(item.IDInventario,
                        item.I_Nombre,
                        item.Cantidad,
                        item.UnidadMedida,
                        item.Descripcion,
                        item.ProveedorId);
                }

                dgv_Inventario.DataSource = dt;
                dgv_Inventario.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_BuscarInventario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Inventario> filtrado = listaConsultarInventario;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarInventario.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.I_Nombre.ToString().Contains(txt_BuscarInventario.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Producto");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Unidad de Medida");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("ID Proveedor");

                    foreach (Inventario item in filtrado)
                    {
                        dt.Rows.Add(item.IDInventario,
                         item.I_Nombre,
                         item.Cantidad,
                         item.UnidadMedida,
                         item.Descripcion,
                         item.ProveedorId);
                    }

                    dgv_Inventario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Producto");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Unidad de Medida");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("ID Proveedor");

                    foreach (Inventario item in filtrado)
                    {
                        dt.Rows.Add(item.IDInventario,
                         item.I_Nombre,
                         item.Cantidad,
                         item.UnidadMedida,
                         item.Descripcion,
                         item.ProveedorId);
                    }

                    dgv_Inventario.DataSource = dt;
                }
                dgv_Inventario.Refresh();
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
