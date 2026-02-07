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
    public partial class frmProveedor : Form
    {
        public List<Proveedor> listaConsultarProveedor { get; set; }
        public frmProveedor()
        {
            InitializeComponent();
            CargarListado();
        }

        private void CargarListado()
        {
            try
            {
                List<Proveedor> lstaresultado = Logica.ConsultarProveedor(new Proveedor());
                listaConsultarProveedor = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Proveedor");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("Telefono");

                foreach (Proveedor item in lstaresultado)
                {
                    dt.Rows.Add(item.IDProveedor,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Telefono);
                }

                dgv_Proveedor.DataSource = dt;
                dgv_Proveedor.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_N_Proveedor.Text = string.Empty;
            txt_Descripcion_Proveedor.Text = string.Empty;
            txt_contacto.Text = string.Empty;
        }

        private void txt_BuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Proveedor> filtrado = listaConsultarProveedor;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarProveedor.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.P_Nombre.ToString().Contains(txt_BuscarProveedor.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Proveedor");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Telefono");

                    foreach (Proveedor item in filtrado)
                    {
                        dt.Rows.Add(item.IDProveedor,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Telefono);
                    }

                    dgv_Proveedor.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Proveedor");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Telefono");

                    foreach (Proveedor item in filtrado)
                    {
                        dt.Rows.Add(item.IDProveedor,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Telefono);
                    }

                    dgv_Proveedor.DataSource = dt;
                }
                dgv_Proveedor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text= dgv_Proveedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_N_Proveedor.Text = dgv_Proveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Descripcion_Proveedor.Text = dgv_Proveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_contacto.Text = dgv_Proveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        #region Eventos
        private void btn_limpiarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor u = new Proveedor
            {

                P_Nombre = txt_N_Proveedor.Text.Trim(),
                Descripcion = txt_Descripcion_Proveedor.Text.Trim(),
                Telefono = txt_contacto.Text.Trim(),

            };
            Logica.AgregarProveedor(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void btn_ModificarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor u = new Proveedor
            {
                IDProveedor = Convert.ToInt32(txt_id.Text.Trim()),
                P_Nombre = txt_N_Proveedor.Text.Trim(),
                Descripcion = txt_Descripcion_Proveedor.Text.Trim(),
                Telefono = txt_contacto.Text.Trim(),

            };
            Logica.ModificarProveedor(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor u = new Proveedor
            {
                IDProveedor = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarProveedor(u);
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
