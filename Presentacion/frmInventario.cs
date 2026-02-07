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
    public partial class frmInventario : Form
    {
        public List<Inventario> listaConsultarInventario { get; set; }
        public frmInventario()
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

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_N_Inventario.Text = string.Empty;
            txt_cantidad.Text = string.Empty;
            cb_unidad.Text = " ";
            txt_Descripcion.Text = string.Empty;
            txt_Proveedor.Text = string.Empty;
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

        private void dgv_Inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text= dgv_Inventario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_N_Inventario.Text= dgv_Inventario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_cantidad.Text= dgv_Inventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_unidad.Text= dgv_Inventario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Descripcion.Text= dgv_Inventario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Proveedor.Text= dgv_Inventario.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        #region Eventos
        private void btn_limpiarInventario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarInventario_Click(object sender, EventArgs e)
        {
            Inventario u = new Inventario
            {

                I_Nombre = txt_N_Inventario.Text.Trim(),
                Cantidad = Convert.ToInt32(txt_cantidad.Text.Trim()),
                UnidadMedida = cb_unidad.Text.Trim(),
                Descripcion = txt_Descripcion.Text.Trim(),
                ProveedorId = Convert.ToInt32(txt_Proveedor.Text.Trim()),

            };
            Logica.AgregarInventario(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void btn_ModificarInventario_Click(object sender, EventArgs e)
        {
            Inventario u = new Inventario
            {
                IDInventario = Convert.ToInt32(txt_id.Text.Trim()),
                I_Nombre = txt_N_Inventario.Text.Trim(),
                Cantidad = Convert.ToInt32(txt_cantidad.Text.Trim()),
                UnidadMedida = cb_unidad.Text.Trim(),
                Descripcion = txt_Descripcion.Text.Trim(),
                ProveedorId = Convert.ToInt32(txt_Proveedor.Text.Trim()),

            };
            Logica.ModificarInventario(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void btn_EliminarInventario_Click(object sender, EventArgs e)
        {
            Inventario u = new Inventario
            {
                IDInventario = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarInventario(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            Close();
        }
        #endregion

        
    }
}
