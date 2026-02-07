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
    public partial class frmAuditoriaEmpleados : Form
    {
        public List<AuditoriaEmpleadosFS> listaConsultarAuditoria { get; set; }
        public frmAuditoriaEmpleados()
        {
            InitializeComponent();
            CargarListado();
        }

        private void CargarListado()
        {
            try
            {
                List<AuditoriaEmpleadosFS> lstaresultado = Logica.ConsultarAuditorsFSiaEmpleado(new AuditoriaEmpleadosFS());
                listaConsultarAuditoria = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID de la Auditoria ");
                dt.Columns.Add("ID del Empleado");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Cargo");
                dt.Columns.Add("Email");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("Direccion");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("Accion");


                foreach (AuditoriaEmpleadosFS item in lstaresultado)
                {
                    dt.Rows.Add(item.AuditoriaID,
                        item.EmpleadoID,
                        item.NombreCompleto,
                        item.Cargo,
                        item.Email,
                        item.Telefono,
                        item.Direccion,
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
                List<AuditoriaEmpleadosFS> filtrado = listaConsultarAuditoria;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.EmpleadoID.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la Auditoria ");
                    dt.Columns.Add("ID del Empleado");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Cargo");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Telefono");
                    dt.Columns.Add("Direccion");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("Accion");

                    foreach (AuditoriaEmpleadosFS item in filtrado)
                    {
                        dt.Rows.Add(item.AuditoriaID,
                       item.EmpleadoID,
                       item.NombreCompleto,
                       item.Cargo,
                       item.Email,
                       item.Telefono,
                       item.Direccion,
                       item.FechaAuditoria,
                       item.Accion);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la Auditoria ");
                    dt.Columns.Add("ID del Empleado");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Cargo");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Telefono");
                    dt.Columns.Add("Direccion");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("Accion");

                    foreach (AuditoriaEmpleadosFS item in filtrado)
                    {
                        dt.Rows.Add(item.AuditoriaID,
                        item.EmpleadoID,
                        item.NombreCompleto,
                        item.Cargo,
                        item.Email,
                        item.Telefono,
                        item.Direccion,
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
