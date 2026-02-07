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
    public partial class frmReporteStock_FS : Form
    {
        public List<ProductoFS> listaConsultarProductoFS { get; set; }
        public frmReporteStock_FS()
        {
            InitializeComponent();
            CargarListado();
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
    }
}
