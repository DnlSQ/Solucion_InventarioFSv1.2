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
    public partial class frmConsultaClientes : Form
    {
        public List<Cliente> listaConsultarCliente { get; set; }
        public frmConsultaClientes()
        {
            InitializeComponent();
            CargarListado();

        }

        private void CargarListado()
        {
            try
            {
                List<Cliente> lstaresultado = Logica.ConsultarCliente(new Cliente());
                listaConsultarCliente = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Cliente");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Apellido");
                dt.Columns.Add("Télefono");
                dt.Columns.Add("Email");
                dt.Columns.Add("Tipo de Cédula");
                dt.Columns.Add("Numero de cédula");


                foreach (Cliente item in lstaresultado)
                {
                    dt.Rows.Add(item.IDCliente,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.Email,
                        item.TipoCedula,
                        item.NumeroCedula);
                }

                dgv_consultaCliente.DataSource = dt;
                dgv_consultaCliente.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_C_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> filtrado = listaConsultarCliente;

                if (filtrado != null && filtrado.Count() > 0 && txt_C_buscar.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.NumeroCedula.ToString().Contains(txt_C_buscar.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Cliente");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Télefono");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Tipo de Cédula");
                    dt.Columns.Add("Numero de cédula");

                    foreach (Cliente item in filtrado)
                    {
                        dt.Rows.Add(item.IDCliente,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.Email,
                        item.TipoCedula,
                        item.NumeroCedula);
                    }

                    dgv_consultaCliente.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Cliente");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Télefono");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Tipo de Cédula");
                    dt.Columns.Add("Numero de cédula");

                    foreach (Cliente item in filtrado)
                    {
                        dt.Rows.Add(item.IDCliente,
                        item.C_Nombre,
                        item.C_Apellidos,
                        item.C_Telefono,
                        item.Email,
                        item.TipoCedula,
                        item.NumeroCedula);
                    }

                    dgv_consultaCliente.DataSource = dt;
                }
                dgv_consultaCliente.Refresh();
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
