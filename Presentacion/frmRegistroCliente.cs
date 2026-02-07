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
    public partial class frmRegistroCliente : Form
    {
        public List<Cliente> listaConsultarCliente { get; set; }
        public frmRegistroCliente()
        {
            InitializeComponent();
            CargarListado();
        }

        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_Ncliente.Text = string.Empty;
            txt_Apellido1.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_email.Text = string.Empty;
            cb_Tcedula.Text = " ";
            txt_cedula.Text = string.Empty;
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

                Dgv_RegistroClientes.DataSource = dt;
                Dgv_RegistroClientes.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_BuscarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> filtrado = listaConsultarCliente;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarCliente.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.NumeroCedula.ToString().Contains(txt_BuscarCliente.Text.ToUpper().Trim())).ToList();

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

                    Dgv_RegistroClientes.DataSource = dt;

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

                    Dgv_RegistroClientes.DataSource = dt;
                }
                Dgv_RegistroClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_RegistroClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Dgv_RegistroClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Ncliente.Text = Dgv_RegistroClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Apellido1.Text= Dgv_RegistroClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_telefono.Text= Dgv_RegistroClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_email.Text= Dgv_RegistroClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            cb_Tcedula.Text= Dgv_RegistroClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cedula.Text= Dgv_RegistroClientes.Rows[e.RowIndex].Cells[6].Value.ToString();

        }


        #region eventos
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente u = new Cliente
            {

                C_Nombre = txt_Ncliente.Text.Trim(),
                C_Apellidos = txt_Apellido1.Text.Trim(),
                C_Telefono = txt_telefono.Text.Trim(),
                Email = txt_email.Text.Trim(),
                TipoCedula = cb_Tcedula.Text.Trim(),
                NumeroCedula = txt_cedula.Text.Trim()
            };
            Logica.AgregarCliente(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente u = new Cliente
            {
                IDCliente = Convert.ToInt32(txt_id.Text.Trim()),
                C_Nombre = txt_Ncliente.Text.Trim(),
                C_Apellidos = txt_Apellido1.Text.Trim(),
                C_Telefono = txt_telefono.Text.Trim(),
                Email = txt_email.Text.Trim(),
                TipoCedula = cb_Tcedula.Text.Trim(),
                NumeroCedula = txt_cedula.Text.Trim()
            };
            Logica.ModificarCliente(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente u = new Cliente
            {
                IDCliente = Convert.ToInt32(txt_id.Text.Trim())

            };
            Logica.EliminarCliente(u);
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

