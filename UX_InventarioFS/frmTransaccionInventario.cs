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
    public partial class frmTransaccionInventario : Form
    {
        public List<TransaccionesInven> listaConsultarDetalleVentaFS { get; set; }
        public frmTransaccionInventario()
        {
            InitializeComponent();
            CargarListado();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_TT.Text = string.Empty;
            txt_idprod.Text = string.Empty;
            txt_cantidad.Text = string.Empty;
            txt_notas.Text = string.Empty;
        }

        private void CargarListado()
        {
            try
            {
                List<TransaccionesInven> lstaresultado = Logica.ConsultarTransaccionesInven(new TransaccionesInven());
                listaConsultarDetalleVentaFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID de la Transaccion ");
                dt.Columns.Add("Fecha de la Transaccion");
                dt.Columns.Add("Tipo de Transaccion");
                dt.Columns.Add("Producto");
                dt.Columns.Add("Cantidad");
                dt.Columns.Add("Notas");


                foreach (TransaccionesInven item in lstaresultado)
                {
                    dt.Rows.Add(item.TransaccionID,
                        item.FechaTransaccion,
                        item.TipoTransaccion,
                        item.ProductoID,
                        item.Cantidad,
                        item.Notas);
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
            txt_TT.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_idprod.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_cantidad.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_notas.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<TransaccionesInven> filtrado = listaConsultarDetalleVentaFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.TipoTransaccion.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la Transaccion ");
                    dt.Columns.Add("Fecha de la Transaccion");
                    dt.Columns.Add("Tipo de Transaccion");
                    dt.Columns.Add("Producto");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Notas");

                    foreach (TransaccionesInven item in filtrado)
                    {
                        dt.Rows.Add(item.TransaccionID,
                        item.FechaTransaccion,
                        item.TipoTransaccion,
                        item.ProductoID,
                        item.Cantidad,
                        item.Notas);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID de la Transaccion ");
                    dt.Columns.Add("Fecha de la Transaccion");
                    dt.Columns.Add("Tipo de Transaccion");
                    dt.Columns.Add("Producto");
                    dt.Columns.Add("Cantidad");
                    dt.Columns.Add("Notas");

                    foreach (TransaccionesInven item in filtrado)
                    {
                        dt.Rows.Add(item.TransaccionID,
                        item.FechaTransaccion,
                        item.TipoTransaccion,
                        item.ProductoID,
                        item.Cantidad,
                        item.Notas);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransaccionesInven u = new TransaccionesInven
            {
                //TransaccionID= Convert.ToInt32(txt_id.Text.Trim()),
                FechaTransaccion = Convert.ToString(dtpFechaRegistro.Value),
                TipoTransaccion = txt_TT.Text.Trim(),
                ProductoID = Convert.ToInt32(txt_idprod.Text.Trim()),
                Cantidad = Convert.ToInt32(txt_cantidad.Text.Trim()),
                Notas = txt_notas.Text.Trim(),


            };
            Logica.AgregarTransaccionesInven(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransaccionesInven u = new TransaccionesInven
            {
                TransaccionID= Convert.ToInt32(txt_id.Text.Trim()),
                FechaTransaccion = Convert.ToString(dtpFechaRegistro.Value),
                TipoTransaccion = txt_TT.Text.Trim(),
                ProductoID = Convert.ToInt32(txt_idprod.Text.Trim()),
                Cantidad = Convert.ToInt32(txt_cantidad.Text.Trim()),
                Notas = txt_notas.Text.Trim(),


            };
            Logica.ModificarTransaccionesInven(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransaccionesInven u = new TransaccionesInven
            {
                TransaccionID = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarTransaccionesInven(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }
    }
}
