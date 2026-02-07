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
    public partial class frmConsultaServicios : Form
    {
        public List<Servicios> listaConsultarServicio { get; set; }
        public frmConsultaServicios()
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

                dgv_servicios.DataSource = dt;
                dgv_servicios.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void txt_BuscarServicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Servicios> filtrado = listaConsultarServicio;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarServicio.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.S_Nombre.ToString().Contains(txt_BuscarServicio.Text.ToUpper().Trim())).ToList();

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

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            Close();
        }
    }
}
