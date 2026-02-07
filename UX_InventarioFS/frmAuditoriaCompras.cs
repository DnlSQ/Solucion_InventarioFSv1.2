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
    public partial class frmAuditoriaCompras : Form
    {
        public List<AuditoriaOrdenesCompraFS> listaConsultarAuditoriaO { get; set; }
        public frmAuditoriaCompras()
        {
            InitializeComponent();
            CargarListado();
        }

        private void CargarListado()
        {
            try
            {
                List<AuditoriaOrdenesCompraFS> lstaresultado = Logica.ConsultarAuditoriaOrdenesCompraFS(new AuditoriaOrdenesCompraFS());
                listaConsultarAuditoriaO = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID de la Auditoria ");
                dt.Columns.Add("ID de la Orden");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("ID del Proveedor");
                dt.Columns.Add("Total");
                dt.Columns.Add("Estado");
                dt.Columns.Add("ID del Empleado");
                dt.Columns.Add("Fecha de la Auditoria");
                dt.Columns.Add("Accion");


                foreach (AuditoriaOrdenesCompraFS item in lstaresultado)
                {
                    dt.Rows.Add(item.AuditoriaID,
                        item.OrdenID,
                        item.FechaOrden,
                        item.ProveedorID,
                        item.Total,
                        item.Estado,
                        item.EmpleadoID,
                        item.FechaAuditoria,
                        item.Accion);
                }

                Dgv_RegistroUsuario.DataSource = dt;
                Dgv_RegistroUsuario.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<AuditoriaOrdenesCompraFS> filtrado = listaConsultarAuditoriaO;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.OrdenID.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la Auditoria ");
                    dt.Columns.Add("ID de la Orden");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("ID del Proveedor");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("Estado");
                    dt.Columns.Add("ID del Empleado");
                    dt.Columns.Add("Fecha de la Auditoria");
                    dt.Columns.Add("Accion");

                    foreach (AuditoriaOrdenesCompraFS item in filtrado)
                    {
                        dt.Rows.Add(item.AuditoriaID,
                        item.OrdenID,
                        item.FechaOrden,
                        item.ProveedorID,
                        item.Total,
                        item.Estado,
                        item.EmpleadoID,
                        item.FechaAuditoria,
                        item.Accion);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la Auditoria ");
                    dt.Columns.Add("ID de la Orden");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("ID del Proveedor");
                    dt.Columns.Add("Total");
                    dt.Columns.Add("Estado");
                    dt.Columns.Add("ID del Empleado");
                    dt.Columns.Add("Fecha de la Auditoria");
                    dt.Columns.Add("Accion");

                    foreach (AuditoriaOrdenesCompraFS item in filtrado)
                    {
                        dt.Rows.Add(item.AuditoriaID,
                        item.OrdenID,
                        item.FechaOrden,
                        item.ProveedorID,
                        item.Total,
                        item.Estado,
                        item.EmpleadoID,
                        item.FechaAuditoria,
                        item.Accion);
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
    }
}
