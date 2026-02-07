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
    public partial class frmUsuarioFS : Form
    {
        public List<UsuarioUFS> listaConsultarUFS { get; set; }
        public List<UsuarioFS> listaConsultarFS { get; set; }
        public List<RolesFS> listaConsultarRolFS { get; set; }
        public List<UxRFS> listaConsultarUxRFS { get; set; }
        public frmUsuarioFS()
        {
            InitializeComponent();
            CargarListado();
            CargarListado1();
            CargarListado2();
            
        }

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_Pass.Text = string.Empty;
            txt_idEmpleado.Text = string.Empty;

        }

        private void CargarListado()
        {
            try
            {
                List<UsuarioUFS> lstaresultado = Logica.ConsultarUFS(new UsuarioUFS());
                listaConsultarUFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Usuario");
                dt.Columns.Add("Nombre del Usuario");
                dt.Columns.Add("Contraseña");
                dt.Columns.Add("ID del Empleado");


                foreach (UsuarioUFS item in lstaresultado)
                {
                    dt.Rows.Add(item.UsuarioID,
                        item.NombreUsuario,
                        item.Contrasena,
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

        private void CargarListado1()
        {
            try
            {
                List<UsuarioFS> lstaresultado = Logica.ConsultarUsuarioFS(new UsuarioFS());
                listaConsultarFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Empleado");
                dt.Columns.Add("Nombre Completo");
                dt.Columns.Add("Cargo");
                dt.Columns.Add("Email");
                dt.Columns.Add("Telfono");
                dt.Columns.Add("Direccion");


                foreach (UsuarioFS item in lstaresultado)
                {
                    dt.Rows.Add(item.EmpleadoID,
                        item.NombreCompleto,
                        item.Cargo,
                        item.Email,
                        item.Telefono,
                        item.Direccion);
                }

                Dgv_RegistroEmpleado.DataSource = dt;
                Dgv_RegistroEmpleado.Refresh();

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
                List<RolesFS> lstaresultado = Logica.ConsultarRolesFS(new RolesFS());
                listaConsultarRolFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Rol");
                dt.Columns.Add("Nombre del Rol");



                foreach (RolesFS item in lstaresultado)
                {
                    dt.Rows.Add(item.RolID,
                        item.NombreRol);
                }

                dgv_UxR.DataSource = dt;
                dgv_UxR.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Dgv_RegistroUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nombre.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Pass.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void Dgv_RegistroEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idEmpleado.Text = Dgv_RegistroEmpleado.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<UsuarioUFS> filtrado = listaConsultarUFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.NombreUsuario.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Usuario");
                    dt.Columns.Add("Nombre del Usuario");
                    dt.Columns.Add("Contraseña");
                    dt.Columns.Add("ID del Empleado");

                    foreach (UsuarioUFS item in filtrado)
                    {
                        dt.Rows.Add(item.UsuarioID,
                         item.NombreUsuario,
                         item.Contrasena,
                         item.EmpleadoID);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Usuario");
                    dt.Columns.Add("Nombre del Usuario");
                    dt.Columns.Add("Contraseña");
                    dt.Columns.Add("ID del Empleado");

                    foreach (UsuarioUFS item in filtrado)
                    {
                        dt.Rows.Add(item.UsuarioID,
                        item.NombreUsuario,
                        item.Contrasena,
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

        private void dgv_UxR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txt_rol.Text = dgv_UxR.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        #region Evento
        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioUFS u = new UsuarioUFS
            {
                //UsuarioID = Convert.ToInt32(txt_id.Text.Trim()),
                NombreUsuario = txt_nombre.Text.Trim(),
                Contrasena = txt_Pass.Text.Trim(),
                EmpleadoID = Convert.ToInt32(txt_idEmpleado.Text.Trim()),


            };
            Logica.AgregarUFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioUFS u = new UsuarioUFS
            {
                UsuarioID = Convert.ToInt32(txt_id.Text.Trim()),
                NombreUsuario = txt_nombre.Text.Trim(),
                Contrasena = txt_Pass.Text.Trim(),
                EmpleadoID = Convert.ToInt32(txt_idEmpleado.Text.Trim()),


            };
            Logica.ModificarUFS(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioUFS u = new UsuarioUFS
            {
                UsuarioID = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarUFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }
        #endregion


    }
}
