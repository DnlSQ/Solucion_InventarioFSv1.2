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
    public partial class frmRegistroClienteFS : Form
    {
        public List<ClienteFS> listaConsultarClienteFS { get; set; }
        public frmRegistroClienteFS()
        {
            InitializeComponent();
            CargarListado();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_correo.Text = string.Empty;

        }

        private void CargarListado()
        {
            try
            {
                List<ClienteFS> lstaresultado = Logica.ConsultarClienteFS(new ClienteFS());
                listaConsultarClienteFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Cliente");
                dt.Columns.Add("Nombre ");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Email");
                dt.Columns.Add("Telfono");


                foreach (ClienteFS item in lstaresultado)
                {
                    dt.Rows.Add(item.ClienteID,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.Email,
                        item.C_Telefono);
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
                List<ClienteFS> filtrado = listaConsultarClienteFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.C_Nombre.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Cliente");
                    dt.Columns.Add("Nombre ");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Telfono");

                    foreach (ClienteFS item in filtrado)
                    {
                        dt.Rows.Add(item.ClienteID,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.Email,
                        item.C_Telefono);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Cliente");
                    dt.Columns.Add("Nombre ");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Telfono");

                    foreach (ClienteFS item in filtrado)
                    {
                        dt.Rows.Add(item.ClienteID,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.Email,
                        item.C_Telefono);
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
            txt_Apellido.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_correo.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_telefono.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        #region Eventos
        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteFS u = new ClienteFS
            {
                //ClienteID = Convert.ToInt32(txt_id.Text.Trim()),
                C_Nombre = txt_nombre.Text.Trim(),
                C_Apellidos = txt_Apellido.Text.Trim(),
                Email = txt_correo.Text.Trim(),
                C_Telefono = txt_telefono.Text.Trim(),



            };
            Logica.AgregarClienteFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteFS u = new ClienteFS
            {
                ClienteID = Convert.ToInt32(txt_id.Text.Trim()),
                C_Nombre = txt_nombre.Text.Trim(),
                C_Apellidos = txt_Apellido.Text.Trim(),
                Email = txt_correo.Text.Trim(),
                C_Telefono = txt_telefono.Text.Trim(),



            };
            Logica.ModificarClienteFS(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteFS u = new ClienteFS
            {
                ClienteID = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarClienteFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }
        #endregion


    }
}
