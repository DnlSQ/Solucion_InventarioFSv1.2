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
    public partial class frmConsultaClientesFS : Form
    {
        public List<ClienteFS> listaConsultarClienteFS { get; set; }
        public frmConsultaClientesFS()
        {
            InitializeComponent();
            CargarListado();
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
    }
}
