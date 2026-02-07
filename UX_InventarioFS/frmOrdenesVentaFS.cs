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
    public partial class frmOrdenesVentaFS : Form
    {
        public List<OrdenVentaFS> listaConsultarOrdenVentaFS { get; set; }
        public frmOrdenesVentaFS()
        {
            InitializeComponent();
            CargarListado();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_idCliente.Text = string.Empty;
            txt_total.Text = string.Empty;
            txt_idEmpleado.Text = string.Empty;
            txt_Estado.Text = string.Empty;
        }

        private void CargarListado()
        {
            try
            {
                List<OrdenVentaFS> lstaresultado = Logica.ConsultarOrdenVentaFS(new OrdenVentaFS());
                listaConsultarOrdenVentaFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID de la orden ");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("ID del Cliente");
                dt.Columns.Add("Total");
                dt.Columns.Add("Estado");
                dt.Columns.Add("ID del Empleado");


                foreach (OrdenVentaFS item in lstaresultado)
                {
                    dt.Rows.Add(item.VentaID,
                        item.FechaVenta,
                        item.ClienteID,
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
            txt_idCliente.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_total.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Estado.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_idEmpleado.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<OrdenVentaFS> filtrado = listaConsultarOrdenVentaFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.FechaVenta.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la orden ");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("ID del Cliente");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("Estado");
                    dt.Columns.Add("ID del Empleado");

                    foreach (OrdenVentaFS item in filtrado)
                    {
                        dt.Rows.Add(item.VentaID,
                         item.FechaVenta,
                         item.ClienteID,
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
                    dt.Columns.Add("ID del Cliente");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("Estado");
                    dt.Columns.Add("ID del Empleado");

                    foreach (OrdenVentaFS item in filtrado)
                    {
                        dt.Rows.Add(item.VentaID,
                         item.FechaVenta,
                         item.ClienteID,
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
            OrdenVentaFS u = new OrdenVentaFS
            {
                //VentaID= Convert.ToInt32(txt_id.Text.Trim()),
                FechaVenta = Convert.ToString(dtpFechaRegistro.Value),
                ClienteID = Convert.ToInt32(txt_idCliente.Text.Trim()),
                Total = Convert.ToInt32(txt_total.Text.Trim()),
                Estado = txt_Estado.Text.Trim(),
                EmpleadoID = Convert.ToInt32(txt_idEmpleado.Text.Trim()),


            };
            Logica.AgregarOrdenVentaFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdenVentaFS u = new OrdenVentaFS
            {
                VentaID= Convert.ToInt32(txt_id.Text.Trim()),
                FechaVenta = Convert.ToString(dtpFechaRegistro.Value),
                ClienteID = Convert.ToInt32(txt_idCliente.Text.Trim()),
                Total = Convert.ToInt32(txt_total.Text.Trim()),
                Estado = txt_Estado.Text.Trim(),
                EmpleadoID = Convert.ToInt32(txt_idEmpleado.Text.Trim()),

            };
            Logica.ModificarOrdenVentaFS(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdenVentaFS u = new OrdenVentaFS
            {
                VentaID = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarOrdenVentaFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDetalleVentaFS frm = new frmDetalleVentaFS();
            frm.Show();
        }
        #endregion


    }
}
