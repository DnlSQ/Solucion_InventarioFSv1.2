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
    public partial class frmOrdenesCompra : Form
    {
        public List<OrdenCompraFS> listaConsultarOrdenCompraFS { get; set; }
        public frmOrdenesCompra()
        {
            InitializeComponent();
            CargarListado();
        }

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_idProvee.Text = string.Empty;
            txt_total.Text = string.Empty;
            txt_idEmpleado.Text = string.Empty;
            txt_Estado.Text = string.Empty;
        }

        private void CargarListado()
        {
            try
            {
                List<OrdenCompraFS> lstaresultado = Logica.ConsultarOrdenCompraFS(new OrdenCompraFS());
                listaConsultarOrdenCompraFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID de la orden ");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("ID del Proveedor");
                dt.Columns.Add("Total");
                dt.Columns.Add("Estado");
                dt.Columns.Add("ID del Empleado");


                foreach (OrdenCompraFS item in lstaresultado)
                {
                    dt.Rows.Add(item.OrdenID,
                        item.FechaOrden,
                        item.ProveedorID,
                        item.Total,
                        item.Estado,
                        item.EmpleadoID);
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
            txt_idProvee.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_total.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Estado.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_idEmpleado.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<OrdenCompraFS> filtrado = listaConsultarOrdenCompraFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.FechaOrden.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la orden ");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("ID del Proveedor");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("Estado");
                    dt.Columns.Add("ID del Empleado");

                    foreach (OrdenCompraFS item in filtrado)
                    {
                        dt.Rows.Add(item.OrdenID,
                         item.FechaOrden,
                         item.ProveedorID,
                         item.Total,
                         item.Estado,
                         item.EmpleadoID);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la orden ");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("ID del Proveedor");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("Estado");
                    dt.Columns.Add("ID del Empleado");

                    foreach (OrdenCompraFS item in filtrado)
                    {
                        dt.Rows.Add(item.OrdenID,
                        item.FechaOrden,
                        item.ProveedorID,
                        item.Total,
                        item.Estado,
                        item.EmpleadoID);
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
            OrdenCompraFS u = new OrdenCompraFS
            {
                //OrdenID= Convert.ToInt32(txt_id.Text.Trim()),
                FechaOrden = Convert.ToString(dtpFechaRegistro.Value),
                ProveedorID = Convert.ToInt32(txt_idProvee.Text.Trim()),
                Total = txt_total.Text.Trim(),
                Estado = txt_Estado.Text.Trim(),
                EmpleadoID = Convert.ToInt32(txt_idEmpleado.Text.Trim()),


            };
            Logica.AgregarOrdenCompraFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdenCompraFS u = new OrdenCompraFS
            {
                OrdenID= Convert.ToInt32(txt_id.Text.Trim()),
                FechaOrden = dtpFechaRegistro.Text.Trim(),
                ProveedorID = Convert.ToInt32(txt_idProvee.Text.Trim()),
                Total = txt_total.Text.Trim(),
                Estado = txt_Estado.Text.Trim(),
                EmpleadoID = Convert.ToInt32(txt_idEmpleado.Text.Trim()),


            };
            Logica.ModificarOrdenCompraFS(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdenCompraFS u = new OrdenCompraFS
            {
                OrdenID = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarOrdenCompraFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDetalleCompraFS frm = new frmDetalleCompraFS();
            frm.Show();
        }
        #endregion



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmOrdenesCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
