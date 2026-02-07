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
    public partial class frmRegistrarEmpleadoFS : Form
    {
        public List<UsuarioFS> listaConsultarFS { get; set; }
        public frmRegistrarEmpleadoFS()
        {
            InitializeComponent();
            CargarListado();
        }

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_cargo.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_correo.Text = string.Empty;
            txt_direccion.Text = string.Empty;
        }

        private void CargarListado()
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
                List<UsuarioFS> filtrado = listaConsultarFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.NombreCompleto.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Empleado");
                    dt.Columns.Add("Nombre Completo");
                    dt.Columns.Add("Cargo");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Telfono");
                    dt.Columns.Add("Direccion");

                    foreach (UsuarioFS item in filtrado)
                    {
                        dt.Rows.Add(item.EmpleadoID,
                        item.NombreCompleto,
                        item.Cargo,
                        item.Email,
                        item.Telefono,
                        item.Direccion);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Empleado");
                    dt.Columns.Add("Nombre Completo");
                    dt.Columns.Add("Cargo");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Telfono");
                    dt.Columns.Add("Direccion");

                    foreach (UsuarioFS item in filtrado)
                    {
                        dt.Rows.Add(item.EmpleadoID,
                        item.NombreCompleto,
                        item.Cargo,
                        item.Email,
                        item.Telefono,
                        item.Direccion);
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

        private void Dgv_RegistroUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nombre.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_cargo.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_correo.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_telefono.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_direccion.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        #region Eventos
        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioFS u = new UsuarioFS
            {
                //EmpleadoID = Convert.ToInt32(txt_id.Text.Trim()),
                NombreCompleto = txt_nombre.Text.Trim(),
                Cargo = txt_cargo.Text.Trim(),
                Email = txt_correo.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Direccion = txt_direccion.Text.Trim(),


            };
            Logica.AgregarUsuarioFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioFS u = new UsuarioFS
            {
                EmpleadoID = Convert.ToInt32(txt_id.Text.Trim()),
                NombreCompleto = txt_nombre.Text.Trim(),
                Cargo = txt_cargo.Text.Trim(),
                Email = txt_correo.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Direccion = txt_direccion.Text.Trim(),


            };
            Logica.ModificarUsuarioFS(u);
            MessageBox.Show("Actualizacion Completa");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioFS u = new UsuarioFS
            {
                EmpleadoID = Convert.ToInt32(txt_id.Text.Trim()),


            };
            Logica.EliminarUsuarioFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }

        #endregion

    }
}
