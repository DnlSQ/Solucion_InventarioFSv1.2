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
    public partial class frmCitas : Form
    {
        public List<Cita> listaConsultar { get; set; }
        public List<Usuario> listaConsultarU { get; set; }
        public List<Servicios> listaConsultarServicio { get; set; }
        public List<Cliente> listaConsultarCliente { get; set; }
        public frmCitas()
        {
            InitializeComponent();
            CargarListado();
            CargarListado1();
            CargarListado2();
            CargarListado3();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_ID_cliente.Text = string.Empty;
            txt_Cliente.Text = string.Empty;
            txt_ID_Empleado.Text = string.Empty;
            txt_empleado.Text = string.Empty;
            txt_idServicio.Text = string.Empty;
            txt_Servicio.Text = string.Empty;
            txt_hora.Text = string.Empty;
            txt_notas.Text = string.Empty;

        }

        private void txt_BuscarCitas_TextChanged_1(object sender, EventArgs e)
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

        private void txt_B_Cliente_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> filtrado = listaConsultarCliente;

                if (filtrado != null && filtrado.Count() > 0 && txt_B_Cliente.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.NumeroCedula.ToString().Contains(txt_B_Cliente.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Cliente");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Télefono");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Tipo de Cédula");
                    dt.Columns.Add("Numero de cédula");

                    foreach (Cliente item in filtrado)
                    {
                        dt.Rows.Add(item.IDCliente,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.Email,
                        item.TipoCedula,
                        item.NumeroCedula);
                    }

                    dvg_cliente.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Cliente");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Télefono");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Tipo de Cédula");
                    dt.Columns.Add("Numero de cédula");

                    foreach (Cliente item in filtrado)
                    {
                        dt.Rows.Add(item.IDCliente,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.Email,
                        item.TipoCedula,
                        item.NumeroCedula);
                    }

                    dvg_cliente.DataSource = dt;
                }
                dvg_cliente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarListado()
        {
            try
            {
                List<Cliente> lstaresultado = Logica.ConsultarCliente(new Cliente());
                listaConsultarCliente = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Cliente");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Télefono");
                dt.Columns.Add("Email");
                dt.Columns.Add("Tipo de Cédula");
                dt.Columns.Add("Numero de cédula");


                foreach (Cliente item in lstaresultado)
                {
                    dt.Rows.Add(item.IDCliente,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.Email,
                        item.TipoCedula,
                        item.NumeroCedula);
                }

                dvg_cliente.DataSource = dt;
                dvg_cliente.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_B_Servicio_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<Servicios> filtrado = listaConsultarServicio;

                if (filtrado != null && filtrado.Count() > 0 && txt_B_Servicio.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.S_Nombre.ToString().Contains(txt_B_Servicio.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Servicio");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Duracion");

                    foreach (Servicios item in filtrado)
                    {
                        dt.Rows.Add(item.IDServicio,
                        item.S_Nombre,
                        item.Descripcion,
                        item.Duracion);
                    }

                    dgv_servicios.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Servicio");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Duracion");

                    foreach (Servicios item in filtrado)
                    {
                        dt.Rows.Add(item.IDServicio,
                        item.S_Nombre,
                        item.Descripcion,
                        item.Duracion);
                    }

                    dgv_servicios.DataSource = dt;
                }
                dgv_servicios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarListado1()
        {
            try
            {
                List<Servicios> lstaresultado = Logica.ConsultarServicio(new Servicios());
                listaConsultarServicio = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Servicio");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("Duracion");

                foreach (Servicios item in lstaresultado)
                {
                    dt.Rows.Add(item.IDServicio,
                        item.S_Nombre,
                        item.Descripcion,
                        item.Duracion);
                }

                dgv_servicios.DataSource = dt;
                dgv_servicios.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void xt_B_Empleado_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> filtrado = listaConsultarU;

                if (filtrado != null && filtrado.Count() > 0 && txt_B_Empleado.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.U_Nombre.ToString().Contains(txt_B_Empleado.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Usuario");
                    dt.Columns.Add("Usuario");
                    dt.Columns.Add("Password");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("Cuenta Activa");
                    dt.Columns.Add("Cuenta Bloqueada");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Telefono");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Tipo de Cédula");
                    dt.Columns.Add("Cédula");

                    foreach (Usuario item in filtrado)
                    {
                        dt.Rows.Add(item.IDUsuario,
                        item.NUsuario,
                        item.Pass,
                        item.Fecha,
                        item.Activo ? "Activo" : "Inactivo",
                        item.Bloqueo ? "Bloqueado" : "Desbloqueado",
                        item.U_Nombre,
                        item.U_Apellido,
                        item.U_Telefono,
                        item.U_Email,
                        item.TCedula,
                        item.Cedula);
                    }

                    dgv_Empleado.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Usuario");
                    dt.Columns.Add("Usuario");
                    dt.Columns.Add("Password");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("Cuenta Activa");
                    dt.Columns.Add("Cuenta Bloqueada");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Telefono");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Tipo de Cédula");
                    dt.Columns.Add("Cédula");

                    foreach (Usuario item in filtrado)
                    {
                        dt.Rows.Add(item.IDUsuario,
                       item.NUsuario,
                       item.Pass,
                       item.Fecha,
                       item.Activo ? "Activo" : "Inactivo",
                       item.Bloqueo ? "Bloqueado" : "Desbloqueado",
                       item.U_Nombre,
                       item.U_Apellido,
                       item.U_Telefono,
                       item.U_Email,
                       item.TCedula,
                       item.Cedula);
                    }

                    dgv_Empleado.DataSource = dt;
                }
                dgv_Empleado.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarListado2()
        {
            try
            {
                List<Usuario> lstaresultado = Logica.ConsultarUsuarioC(new Usuario());
                listaConsultarU = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Usuario");
                dt.Columns.Add("Usuario");
                dt.Columns.Add("Password");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("Cuenta Activa");
                dt.Columns.Add("Cuenta Bloqueada");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("Email");
                dt.Columns.Add("Tipo de Cédula");
                dt.Columns.Add("Cédula");


                foreach (Usuario item in lstaresultado)
                {
                    dt.Rows.Add(item.IDUsuario,
                        item.NUsuario,
                        item.Pass,
                        item.Fecha,
                        item.Activo ? "Activo" : "Inactivo",
                        item.Bloqueo ? "Bloqueado" : "Desbloqueado",
                        item.U_Nombre,
                        item.U_Apellido,
                        item.U_Telefono,
                        item.U_Email,
                        item.TCedula,
                        item.Cedula);
                }

                dgv_Empleado.DataSource = dt;
                dgv_Empleado.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Dgv_RegistroCitas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ID_cliente.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Cliente.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ID_Empleado.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_empleado.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_idServicio.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Servicio.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_hora.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_notas.Text = Dgv_RegistroCitas.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void dvg_cliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_cliente.Text = dvg_cliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Cliente.Text = dvg_cliente.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgv_Empleado_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_Empleado.Text = dgv_Empleado.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_empleado.Text = dgv_Empleado.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dgv_servicios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_idServicio.Text = dgv_servicios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Servicio.Text = dgv_servicios.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        #region Eventos
        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            Cita u = new Cita
            {

                ClienteId = Convert.ToInt32(txt_ID_cliente.Text.Trim()),
                NombreCliente = txt_Cliente.Text.Trim(),
                EmpleadoId = Convert.ToInt32(txt_ID_Empleado.Text.Trim()),
                NombreEmpleado = txt_empleado.Text.Trim(),
                ServicioId = Convert.ToInt32(txt_idServicio.Text.Trim()),
                NombreServicio = txt_Servicio.Text.Trim(),
                Fecha = Convert.ToString(dtpFechaRegistro.Value),
                Hora = txt_hora.Text.Trim(),
                Notas = txt_notas.Text.Trim(),


            };
            Logica.AgregarCitas(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado3();
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            Cita u = new Cita
            {
                IDCita = Convert.ToInt32(txt_id.Text.Trim()),
                ClienteId = Convert.ToInt32(txt_ID_cliente.Text.Trim()),
                NombreCliente = txt_Cliente.Text.Trim(),
                EmpleadoId = Convert.ToInt32(txt_ID_Empleado.Text.Trim()),
                NombreEmpleado = txt_empleado.Text.Trim(),
                ServicioId = Convert.ToInt32(txt_idServicio.Text.Trim()),
                NombreServicio = txt_Servicio.Text.Trim(),
                Fecha = Convert.ToString(dtpFechaRegistro.Value),
                Hora = txt_hora.Text.Trim(),
                Notas = txt_notas.Text.Trim(),

            };
            Logica.ModificarCitas(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado3();
        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            Cita u = new Cita
            {
                IDCita = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarCitas(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado3();
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
