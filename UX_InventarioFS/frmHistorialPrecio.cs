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
    public partial class frmHistorialPrecio : Form
    {
        public List<HistorialPrecioFS> listaConsultarHxP { get; set; }
        public frmHistorialPrecio()
        {
            InitializeComponent();
            CargarListado();
        }

        private void CargarListado()
        {
            try
            {
                List<HistorialPrecioFS> lstaresultado = Logica.ConsultarHistorialPrecioFS(new HistorialPrecioFS());
                listaConsultarHxP = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID del Historial");
                dt.Columns.Add("ID Producto");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("Precio Antiguo");
                dt.Columns.Add("Precio Nuevo");



                foreach (HistorialPrecioFS item in lstaresultado)
                {
                    dt.Rows.Add(item.HistorialID,
                        item.ProductoID,
                        item.FechaCambio,
                        item.PrecioAntiguo,
                        item.PrecioNuevo);
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
                List<HistorialPrecioFS> filtrado = listaConsultarHxP;

                if (filtrado != null && filtrado.Count() > 0 && txt_Buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.HistorialID.ToString().Contains(txt_Buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Historial");
                    dt.Columns.Add("ID Producto");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("Precio Antiguo");
                    dt.Columns.Add("Precio Nuevo");

                    foreach (HistorialPrecioFS item in filtrado)
                    {
                        dt.Rows.Add(item.HistorialID,
                        item.ProductoID,
                        item.FechaCambio,
                        item.PrecioAntiguo,
                        item.PrecioNuevo);
                    }

                    Dgv_RegistroUsuario.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID del Historial");
                    dt.Columns.Add("ID Producto");
                    dt.Columns.Add("Fecha");
                    dt.Columns.Add("Precio Antiguo");
                    dt.Columns.Add("Precio Nuevo");

                    foreach (HistorialPrecioFS item in filtrado)
                    {
                        dt.Rows.Add(item.HistorialID,
                        item.ProductoID,
                        item.FechaCambio,
                        item.PrecioAntiguo,
                        item.PrecioNuevo);
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
