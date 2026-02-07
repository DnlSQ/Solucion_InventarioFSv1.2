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

namespace UX_InventarioFS
{
    public partial class frmDetalleCompraFS : Form
    {
        public List<DetalleOrdenCompraFS> listaConsultarDetalle { get; set; }
        public frmDetalleCompraFS()
        {
            InitializeComponent();
            CargarListado();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_ordenid.Text = string.Empty;
            txt_idproduc.Text = string.Empty;
            txt_cantidad.Text = string.Empty;
            txt_precio.Text = string.Empty;
            txt_total.Text = string.Empty;
        }

        private void CargarListado()
        {
            try
            {
                List<DetalleOrdenCompraFS> lstaresultado = Logica.ConsultarDetalleOrdenCompraFS(new DetalleOrdenCompraFS());
                listaConsultarDetalle = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Detalle ");
                dt.Columns.Add("ID de la Orden");
                dt.Columns.Add("ID del Producto");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Precio Unitario");
                dt.Columns.Add("Precio Total");


                foreach (DetalleOrdenCompraFS item in lstaresultado)
                {
                    dt.Rows.Add(item.DetalleID,
                        item.OrdenID,
                        item.ProductoID,
                        item.Cantidad,
                        item.PrecioUnitario,
                        item.TotalLinea);
                }

                Dgv_RegistroUsuario.DataSource = dt;
                Dgv_RegistroUsuario.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Dgv_RegistroUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ordenid.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_idproduc.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_cantidad.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_precio.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_total.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<DetalleOrdenCompraFS> filtrado = listaConsultarDetalle;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.DetalleID.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Detalle ");
                    dt.Columns.Add("ID de la Orden");
                    dt.Columns.Add("ID del Producto");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Precio Unitario");
                    dt.Columns.Add("Precio Total");

                    foreach (DetalleOrdenCompraFS item in filtrado)
                    {
                        dt.Rows.Add(item.DetalleID,
                        item.OrdenID,
                        item.ProductoID,
                        item.Cantidad,
                        item.PrecioUnitario,
                        item.TotalLinea);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Detalle ");
                dt.Columns.Add("ID de la Orden");
                dt.Columns.Add("ID del Producto");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Precio Unitario");
                dt.Columns.Add("Precio Total");

                    foreach (DetalleOrdenCompraFS item in filtrado)
                    {
                        dt.Rows.Add(item.DetalleID,
                        item.OrdenID,
                        item.ProductoID,
                        item.Cantidad,
                        item.PrecioUnitario,
                        item.TotalLinea);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;
                }
                Dgv_RegistroUsuario.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Eventos
        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleOrdenCompraFS u = new DetalleOrdenCompraFS
            {
                //DetalleID= Convert.ToInt32(txt_id.Text.Trim()),
                OrdenID = Convert.ToInt32(txt_ordenid.Text.Trim()),
                ProductoID = Convert.ToInt32(txt_idproduc.Text.Trim()),
                Cantidad = Convert.ToInt32(txt_cantidad.Text.Trim()),
                PrecioUnitario = Convert.ToInt32(txt_precio.Text.Trim()),
                TotalLinea = Convert.ToInt32(txt_total.Text.Trim()),


            };
            Logica.AgregarDetalleOrdenCompraFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleOrdenCompraFS u = new DetalleOrdenCompraFS
            {
                DetalleID= Convert.ToInt32(txt_id.Text.Trim()),
                OrdenID = Convert.ToInt32(txt_ordenid.Text.Trim()),
                ProductoID = Convert.ToInt32(txt_idproduc.Text.Trim()),
                Cantidad = Convert.ToInt32(txt_cantidad.Text.Trim()),
                PrecioUnitario = Convert.ToInt32(txt_precio.Text.Trim()),
                TotalLinea = Convert.ToInt32(txt_total.Text.Trim()),


            };
            Logica.ModificarDetalleOrdenCompraFS(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalleOrdenCompraFS u = new DetalleOrdenCompraFS
            {
                DetalleID = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarDetalleOrdenCompraFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            frmTransaccionInventario frm = new frmTransaccionInventario();
            frm.Show();
        }
    }
}
