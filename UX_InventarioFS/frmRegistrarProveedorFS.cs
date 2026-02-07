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
    public partial class frmRegistrarProveedorFS : Form
    {
        public List<ProveedorFS> listaConsultarProveedorFS { get; set; }
        public frmRegistrarProveedorFS()
        {
            InitializeComponent();
            CargarListado();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_Contacto.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_Direccion.Text = string.Empty;

        }

        private void CargarListado()
        {
            try
            {
                List<ProveedorFS> lstaresultado = Logica.ConsultarProveedorFS(new ProveedorFS());
                listaConsultarProveedorFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Proveedor");
                dt.Columns.Add("Nombre de la Empresa");
                dt.Columns.Add("Contacto");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("Direccion");


                foreach (ProveedorFS item in lstaresultado)
                {
                    dt.Rows.Add(item.ProveedorID,
                        item.NombreEmpresa,
                        item.Contacto,
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

        private void Dgv_RegistroUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nombre.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Contacto.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Direccion.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_telefono.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ProveedorFS> filtrado = listaConsultarProveedorFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.NombreEmpresa.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Proveedor");
                    dt.Columns.Add("Nombre de la Empresa");
                    dt.Columns.Add("Contacto");
                    dt.Columns.Add("Telefono");
                    dt.Columns.Add("Direccion");

                    foreach (ProveedorFS item in filtrado)
                    {
                        dt.Rows.Add(item.ProveedorID,
                        item.NombreEmpresa,
                        item.Contacto,
                        item.Telefono,
                        item.Direccion);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Proveedor");
                    dt.Columns.Add("Nombre de la Empresa");
                    dt.Columns.Add("Contacto");
                    dt.Columns.Add("Telefono");
                    dt.Columns.Add("Direccion");

                    foreach (ProveedorFS item in filtrado)
                    {
                        dt.Rows.Add(item.ProveedorID,
                         item.NombreEmpresa,
                         item.Contacto,
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

        #region Eventos
        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveedorFS u = new ProveedorFS
            {
                //ProveedorID = Convert.ToInt32(txt_id.Text.Trim()),
                NombreEmpresa = txt_nombre.Text.Trim(),
                Contacto = txt_Contacto.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Direccion = txt_Direccion.Text.Trim(),



            };
            Logica.AgregarProveedorFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorFS u = new ProveedorFS
            {
                ProveedorID = Convert.ToInt32(txt_id.Text.Trim()),
                NombreEmpresa = txt_nombre.Text.Trim(),
                Contacto = txt_Contacto.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
                Direccion = txt_Direccion.Text.Trim(),



            };
            Logica.ModificarProveedorFS(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorFS u = new ProveedorFS
            {
                ProveedorID = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarProveedorFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }
        #endregion

    }
}
