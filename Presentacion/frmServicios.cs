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
    public partial class frmServicios : Form
    {
        public List<Servicios> listaConsultarServicio { get; set; }
        public frmServicios()
        {
            InitializeComponent();
            CargarListado();
        }

        private void CargarListado()
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

                dgv_Servicios.DataSource = dt;
                dgv_Servicios.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_NombreS.Text = string.Empty;
            txt_descripcion.Text = string.Empty;
            txt_tiempoServicio.Text = string.Empty;
        }

        private void txt_BuscarInventario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Servicios> filtrado = listaConsultarServicio;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarInventario.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.S_Nombre.ToString().Contains(txt_BuscarInventario.Text.ToUpper().Trim())).ToList();

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

                    dgv_Servicios.DataSource = dt;

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

                    dgv_Servicios.DataSource = dt;
                }
                dgv_Servicios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Servicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_Servicios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_NombreS.Text = dgv_Servicios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_descripcion.Text = dgv_Servicios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_tiempoServicio.Text = dgv_Servicios.Rows[e.RowIndex].Cells[3].Value.ToString();
        }


        #region Eventos
        private void btn_limpiarS_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarS_Click(object sender, EventArgs e)
        {
            Servicios u = new Servicios
            {

                S_Nombre = txt_NombreS.Text.Trim(),
                Descripcion = txt_descripcion.Text.Trim(),
                Duracion = txt_tiempoServicio.Text.Trim(),

            };
            Logica.AgregarServicio(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void btn_ModificarS_Click(object sender, EventArgs e)
        {
            Servicios u = new Servicios
            {
                IDServicio = Convert.ToInt32(txt_id.Text.Trim()),
                S_Nombre = txt_NombreS.Text.Trim(),
                Descripcion = txt_descripcion.Text.Trim(),
                Duracion = txt_tiempoServicio.Text.Trim(),

            };
            Logica.ModificarServicio(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void btn_EliminarS_Click(object sender, EventArgs e)
        {
            Servicios u = new Servicios
            {
                IDServicio = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarServicio(u);
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
