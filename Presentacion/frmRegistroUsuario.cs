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
    public partial class frmRegistroUsuario : Form
    {
        public List<Usuario> listaConsultarU { get; set; }
        public frmRegistroUsuario()
        {
            InitializeComponent();
            RB_activo.Checked = false;
            RB_Cuenta_Activa.Checked = true;
            CargarListado();
        }




        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_Usuario.Text = string.Empty;
            txt_Pass.Text = string.Empty;
            dtpFechaRegistro.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_Email.Text = string.Empty;
            cb_Tcedula.Text = string.Empty;
            txt_cedula.Text = string.Empty;
        }

        private void CargarListado()
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

                Dgv_RegistroUsuario.DataSource = dt;
                Dgv_RegistroUsuario.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_BuscarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> filtrado = listaConsultarU;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarCliente.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.U_Nombre.ToString().Contains(txt_BuscarCliente.Text.ToUpper().Trim())).ToList();

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

                    Dgv_RegistroUsuario.DataSource = dt;

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

                    Dgv_RegistroUsuario.DataSource = dt;
                }
                Dgv_RegistroUsuario.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_RegistroUsuario_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Usuario.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Pass.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_nombre.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_apellido.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_telefono.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_Email.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[9].Value.ToString();
            cb_Tcedula.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_cedula.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[11].Value.ToString();

        }

        #region Eventos

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarCliente_Click_1(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                IDUsuario = Convert.ToInt32(txt_id.Text.Trim()),
                NUsuario = txt_Usuario.Text.Trim(),
                Pass = txt_Pass.Text.Trim(),
                Fecha = Convert.ToString(dtpFechaRegistro.Value),
                Activo = RB_Cuenta_Activa.Checked,
                U_Nombre = txt_nombre.Text.Trim(),
                U_Apellido = txt_apellido.Text.Trim(),
                U_Telefono = txt_nombre.Text.Trim(),
                U_Email = txt_Email.Text.Trim(),
                TCedula = cb_Tcedula.Text.Trim(),
                Cedula = txt_cedula.Text.Trim(),

            };
            Logica.AgregarUsuario(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                IDUsuario = Convert.ToInt32(txt_id.Text.Trim()),
                NUsuario = txt_Usuario.Text.Trim(),
                Pass = txt_Pass.Text.Trim(),
                Fecha = Convert.ToString(dtpFechaRegistro.Value),
                Activo = RB_Cuenta_Activa.Checked,
                U_Nombre = txt_nombre.Text.Trim(),
                U_Apellido = txt_apellido.Text.Trim(),
                U_Telefono = txt_nombre.Text.Trim(),
                U_Email = txt_Email.Text.Trim(),
                TCedula = cb_Tcedula.Text.Trim(),
                Cedula = txt_cedula.Text.Trim(),

            };
            Logica.ModificarUsuario(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                IDUsuario = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarUsuario(u);
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
