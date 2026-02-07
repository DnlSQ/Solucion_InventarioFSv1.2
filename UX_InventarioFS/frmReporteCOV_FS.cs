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
    public partial class frmReporteCOV_FS : Form
    {
        public List<ObtenerClientesOrdenesVentaFS> listaConsultarClienteVFS { get; set; }
        public frmReporteCOV_FS()
        {
            InitializeComponent();
            CargarListado();
        }

        private void CargarListado()
        {
            try
            {
                List<ObtenerClientesOrdenesVentaFS> lstaresultado = Logica.ConsultarCOV(new ObtenerClientesOrdenesVentaFS());
                listaConsultarClienteVFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Cliente");
                dt.Columns.Add("Nombre ");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Telfono");
                dt.Columns.Add("ID Venta");
                dt.Columns.Add("Fecha de Venta");
                dt.Columns.Add("Venta Total");



                foreach (ObtenerClientesOrdenesVentaFS item in lstaresultado)
                {
                    dt.Rows.Add(item.ClienteID,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.VentaID,
                        item.FechaVenta,
                        item.VentaTotal);
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
                List<ObtenerClientesOrdenesVentaFS> filtrado = listaConsultarClienteVFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.C_Nombre.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Cliente");
                    dt.Columns.Add("Nombre ");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Telfono");
                    dt.Columns.Add("ID Venta");
                    dt.Columns.Add("Fecha de Venta");
                    dt.Columns.Add("Venta Total");

                    foreach (ObtenerClientesOrdenesVentaFS item in filtrado)
                    {
                        dt.Rows.Add(item.ClienteID,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.VentaID,
                        item.FechaVenta,
                        item.VentaTotal);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Cliente");
                    dt.Columns.Add("Nombre ");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Telfono");
                    dt.Columns.Add("ID Venta");
                    dt.Columns.Add("Fecha de Venta");
                    dt.Columns.Add("Venta Total");

                    foreach (ObtenerClientesOrdenesVentaFS item in filtrado)
                    {
                        dt.Rows.Add(item.ClienteID,
                         item.C_Nombre,
                         item.C_Apellidos,
                         item.C_Telefono,
                         item.VentaID,
                         item.FechaVenta,
                         item.VentaTotal);
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
