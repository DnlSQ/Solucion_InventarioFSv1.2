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
    public partial class frmRegistroProductoFS : Form
    {
        public List<ProductoFS> listaConsultarProductoFS { get; set; }
        public frmRegistroProductoFS()
        {
            InitializeComponent();
            CargarListado();
        }
        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_Descripcion.Text = string.Empty;
            txt_stock.Text = string.Empty;
            txt_precio.Text = string.Empty;
            txt_categoria.Text = string.Empty;

        }

        private void CargarListado()
        {
            try
            {
                List<ProductoFS> lstaresultado = Logica.ConsultarProductoFS(new ProductoFS());
                listaConsultarProductoFS = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Producto");
                dt.Columns.Add("Nombre ");
                dt.Columns.Add("Descripcion");
                dt.Columns.Add("Percio");
                dt.Columns.Add("Stock");
                dt.Columns.Add("Categoria");

                foreach (ProductoFS item in lstaresultado)
                {
                    dt.Rows.Add(item.ProductoID,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Precio,
                        item.Stock,
                        item.Categoria);
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
                List<ProductoFS> filtrado = listaConsultarProductoFS;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.P_Nombre.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Producto");
                    dt.Columns.Add("Nombre ");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Percio");
                    dt.Columns.Add("Stock");
                    dt.Columns.Add("Categoria");

                    foreach (ProductoFS item in filtrado)
                    {
                        dt.Rows.Add(item.ProductoID,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Precio,
                        item.Stock,
                        item.Categoria);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Producto");
                    dt.Columns.Add("Nombre ");
                    dt.Columns.Add("Descripcion");
                    dt.Columns.Add("Percio");
                    dt.Columns.Add("Stock");
                    dt.Columns.Add("Categoria");

                    foreach (ProductoFS item in filtrado)
                    {
                        dt.Rows.Add(item.ProductoID,
                        item.P_Nombre,
                        item.Descripcion,
                        item.Precio,
                        item.Stock,
                        item.Categoria);
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
            txt_Descripcion.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_stock.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_precio.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_categoria.Text = Dgv_RegistroUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        #region Eventos 
        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoFS u = new ProductoFS
            {
                //ProductoID = Convert.ToInt32(txt_id.Text.Trim()),
                P_Nombre = txt_nombre.Text.Trim(),
                Descripcion = txt_Descripcion.Text.Trim(),
                Precio = txt_precio.Text.Trim(),
                Stock = Convert.ToInt32(txt_stock.Text.Trim()),
                Categoria = txt_categoria.Text.Trim(),


            };
            Logica.AgregarProductoFS(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoFS u = new ProductoFS
            {
                ProductoID = Convert.ToInt32(txt_id.Text.Trim()),
                P_Nombre = txt_nombre.Text.Trim(),
                Descripcion = txt_Descripcion.Text.Trim(),
                Precio = txt_precio.Text.Trim(),
                Stock = Convert.ToInt32(txt_stock.Text.Trim()),
                Categoria = txt_categoria.Text.Trim(),


            };
            Logica.ModificarProductoFS(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoFS u = new ProductoFS
            {
                ProductoID = Convert.ToInt32(txt_id.Text.Trim()),
               
            };
            Logica.EliminarProductoFS(u);
            MessageBox.Show("Registro Eliminado");
            Limpiar();
            CargarListado();
        }
        #endregion
    }
}
