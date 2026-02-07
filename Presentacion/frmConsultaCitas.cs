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
    public partial class frmConsultaCitas : Form
    {
        public List<Cita> listaConsultar { get; set; }
        public frmConsultaCitas()
        {
            InitializeComponent();
            CargarListado3();
        }

        private void CargarListado3()
        {
            try
            {
                List<Cita> lstaresultado = Logica.ConsultarCitas(new Cita());
                listaConsultar = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Cita");
                dt.Columns.Add("ID Cliente");
                dt.Columns.Add("Nombre del Cliente");
                dt.Columns.Add("ID Colaborador");
                dt.Columns.Add("Colaborador");
                dt.Columns.Add("ID Servicio");
                dt.Columns.Add("Servicio");
                dt.Columns.Add("Fecha de la cita");
                dt.Columns.Add("Hora");
                dt.Columns.Add("Notas");



                foreach (Cita item in lstaresultado)
                {
                    dt.Rows.Add(item.IDCita,
                        item.ClienteId,
                        item.NombreCliente,
                        item.EmpleadoId,
                        item.NombreEmpleado,
                        item.ServicioId,
                        item.NombreServicio,
                        item.Fecha,
                        item.Hora,
                        item.Notas);
                }

                Dgv_RegistroCitas.DataSource = dt;
                Dgv_RegistroCitas.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_BuscarCitas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Cita> filtrado = listaConsultar;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarCitas.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.Fecha.ToString().Contains(txt_BuscarCitas.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Cita");
                    dt.Columns.Add("ID Cliente");
                    dt.Columns.Add("Nombre del Cliente");
                    dt.Columns.Add("ID Colaborador");
                    dt.Columns.Add("Colaborador");
                    dt.Columns.Add("ID Servicio");
                    dt.Columns.Add("Servicio");
                    dt.Columns.Add("Fecha de la cita");
                    dt.Columns.Add("Hora");
                    dt.Columns.Add("Notas");

                    foreach (Cita item in filtrado)
                    {
                        dt.Rows.Add(item.IDCita,
                        item.ClienteId,
                        item.NombreCliente,
                        item.EmpleadoId,
                        item.NombreEmpleado,
                        item.ServicioId,
                        item.NombreServicio,
                        item.Fecha,
                        item.Hora,
                        item.Notas);
                    }

                    Dgv_RegistroCitas.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Cita");
                    dt.Columns.Add("ID Cliente");
                    dt.Columns.Add("Nombre del Cliente");
                    dt.Columns.Add("ID Colaborador");
                    dt.Columns.Add("Colaborador");
                    dt.Columns.Add("ID Servicio");
                    dt.Columns.Add("Servicio");
                    dt.Columns.Add("Fecha de la cita");
                    dt.Columns.Add("Hora");
                    dt.Columns.Add("Notas");

                    foreach (Cita item in filtrado)
                    {
                        dt.Rows.Add(item.IDCita,
                        item.ClienteId,
                        item.NombreCliente,
                        item.EmpleadoId,
                        item.NombreEmpleado,
                        item.ServicioId,
                        item.NombreServicio,
                        item.Fecha,
                        item.Hora,
                        item.Notas); ;
                    }

                    Dgv_RegistroCitas.DataSource = dt;
                }
                Dgv_RegistroCitas.Refresh();
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
