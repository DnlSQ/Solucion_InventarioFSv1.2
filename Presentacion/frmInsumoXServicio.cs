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
    public partial class frmInsumoXServicio : Form
    {
        public List<ServicioInventario> listaConsultarIXS { get; set; }
        public List<Inventario> listaConsultarInventario { get; set; }
        public List<Servicios> listaConsultarServicio { get; set; }
        public frmInsumoXServicio()
        {
            InitializeComponent();
            CargarListado1();
            CargarListado();
            CargarListado2();
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

                dgv_servicio.DataSource = dt;
                dgv_servicio.Refresh();

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
                List<Inventario> lstaresultado = Logica.ConsultarInventario(new Inventario());
                listaConsultarInventario = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Producto");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Unidad de Medida");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("ID Proveedor");

                foreach (Inventario item in lstaresultado)
                {
                    dt.Rows.Add(item.IDInventario,
                        item.I_Nombre,
                        item.Cantidad,
                        item.UnidadMedida,
                        item.Descripcion,
                        item.ProveedorId);
                }

                dgv_insumo.DataSource = dt;
                dgv_insumo.Refresh();

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
                List<ServicioInventario> lstaresultado = Logica.ConsultarSXI(new ServicioInventario());
                listaConsultarIXS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("ID Servicio");
                dt.Columns.Add("ID Insumo");
                dt.Columns.Add("Cantidad Utilizada");

                foreach (ServicioInventario item in lstaresultado)
                {
                    dt.Rows.Add(item.IDServicioInventario,
                     item.IDServicio,
                     item.IDInventario,
                     item.CantidadUsada);
                }

                dgv_IXS.DataSource = dt;
                dgv_IXS.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_N_Servicio.Text = string.Empty;
            txt_N_Insumo.Text = string.Empty;
            txt_Cantidad.Text = string.Empty;
        }

        private void txt_Bservicio_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<Servicios> filtrado = listaConsultarServicio;

                if (filtrado != null && filtrado.Count() > 0 && txt_Bservicio.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.S_Nombre.ToString().Contains(txt_Bservicio.Text.ToUpper().Trim())).ToList();

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

                    dgv_servicio.DataSource = dt;

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

                    dgv_servicio.DataSource = dt;
                }
                dgv_servicio.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Binsumo_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<Inventario> filtrado = listaConsultarInventario;

                if (filtrado != null && filtrado.Count() > 0 && txt_Binsumo.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.I_Nombre.ToString().Contains(txt_Binsumo.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Producto");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Unidad de Medida");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("ID Proveedor");

                    foreach (Inventario item in filtrado)
                    {
                        dt.Rows.Add(item.IDInventario,
                         item.I_Nombre,
                         item.Cantidad,
                         item.UnidadMedida,
                         item.Descripcion,
                         item.ProveedorId);
                    }

                    dgv_insumo.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Producto");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Unidad de Medida");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("ID Proveedor");

                    foreach (Inventario item in filtrado)
                    {
                        dt.Rows.Add(item.IDInventario,
                         item.I_Nombre,
                         item.Cantidad,
                         item.UnidadMedida,
                         item.Descripcion,
                         item.ProveedorId);
                    }

                    dgv_insumo.DataSource = dt;
                }
                dgv_insumo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_IXS_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                List<ServicioInventario> filtrado = listaConsultarIXS;

                if (filtrado != null && filtrado.Count() > 0 && txt_IXS.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.IDServicio.ToString().Contains(txt_IXS.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID");
                    dt.Columns.Add("ID Servicio");
                    dt.Columns.Add("ID Insumo");
                    dt.Columns.Add("Cantidad Utilizada");


                    foreach (ServicioInventario item in filtrado)
                    {
                        dt.Rows.Add(item.IDServicioInventario,
                         item.IDServicio,
                         item.IDInventario,
                         item.CantidadUsada);
                    }

                    dgv_IXS.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID");
                    dt.Columns.Add("ID Servicio");
                    dt.Columns.Add("ID Insumo");
                    dt.Columns.Add("Cantidad Utilizada");


                    foreach (ServicioInventario item in filtrado)
                    {
                        dt.Rows.Add(item.IDServicioInventario,
                         item.IDServicio,
                         item.IDInventario,
                         item.CantidadUsada);
                    }

                    dgv_IXS.DataSource = dt;
                }
                dgv_IXS.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_servicio_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_N_Servicio.Text = dgv_servicio.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgv_insumo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_N_Insumo.Text = dgv_servicio.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgv_IXS_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_IXS.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        #region Eventos
        private void btn_limpiarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            ServicioInventario u = new ServicioInventario
            {

                IDServicio = Convert.ToInt32(txt_N_Servicio.Text.Trim()),
                IDInventario = Convert.ToInt32(txt_N_Insumo.Text.Trim()),
                CantidadUsada = Convert.ToInt32(txt_Cantidad.Text.Trim()),

            };
            Logica.AgregarSXI(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado2();
        }

        private void btn_ModificarProveedor_Click(object sender, EventArgs e)
        {
            ServicioInventario u = new ServicioInventario
            {
                IDServicioInventario = Convert.ToInt32(txt_id.Text.Trim()),
                IDServicio = Convert.ToInt32(txt_N_Servicio.Text.Trim()),
                IDInventario = Convert.ToInt32(txt_N_Insumo.Text.Trim()),
                CantidadUsada = Convert.ToInt32(txt_Cantidad.Text.Trim()),

            };
            Logica.ModificarSXI(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado2();
        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            ServicioInventario u = new ServicioInventario
            {
                IDServicioInventario = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarSXI(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado2();
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
