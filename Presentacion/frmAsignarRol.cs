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
    public partial class frmAsignarRol : Form
    {
        public List<UsuarioporPerfil> listaConsultarUXP { get; set; }
        public frmAsignarRol()
        {
            InitializeComponent();
            CargarListado();
        }


        private void Limpiar()
        {
            txt_id.Text = string.Empty;
            txt_usuario.Text = string.Empty;
            cb_rol.Text = " ";
            
        }



        private void CargarListado()
        {
            try
            {
                List<UsuarioporPerfil> lstaresultado = Logica.ConsultarUsuarioXPerfil(new UsuarioporPerfil());
                listaConsultarUXP = lstaresultado;

                DataTable dt = new DataTable();

                dt.Columns.Add("ID Usuario");
                dt.Columns.Add("Usuario");
                dt.Columns.Add("Rol");
                dt.Columns.Add("Fecha");

                foreach (UsuarioporPerfil item in lstaresultado)
                {
                    dt.Rows.Add(item.UsuarioId,
                        item.Usuario,
                        item.CodPerfil,
                        item.FechaAsociacion);
                }

                dgv_ARol.DataSource = dt;
                dgv_ARol.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txt_BuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<UsuarioporPerfil> filtrado = listaConsultarUXP;

                if (filtrado != null && filtrado.Count() > 0 && txt_BuscarProveedor.Text.Trim().Length > 0)
                {
                    filtrado = filtrado.FindAll(Item => Item.Usuario.ToString().Contains(txt_BuscarProveedor.Text.ToUpper().Trim())).ToList();

                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Usuario");
                    dt.Columns.Add("Nombre de Usuario");
                    dt.Columns.Add("Codigo del Perfil");
                    dt.Columns.Add("Fecha de Asignación");

                    foreach (UsuarioporPerfil item in filtrado)
                    {
                        dt.Rows.Add(item.UsuarioId,
                        item.Usuario,
                        item.CodPerfil,
                        item.FechaAsociacion);
                    }

                    dgv_ARol.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ID Usuario");
                    dt.Columns.Add("Nombre de Usuario");
                    dt.Columns.Add("Codigo del Perfil");
                    dt.Columns.Add("Fecha de Asignación");

                    foreach (UsuarioporPerfil item in filtrado)
                    {
                        dt.Rows.Add(item.UsuarioId,
                        item.Usuario,
                        item.CodPerfil,
                        item.FechaAsociacion);
                    }

                    dgv_ARol.DataSource = dt;
                }
                dgv_ARol.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_ARol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_ARol.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_usuario.Text = dgv_ARol.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_rol.Text = dgv_ARol.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        #region Eventos

        private void btn_limpiarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            UsuarioporPerfil u = new UsuarioporPerfil
            {
                UsuarioId = Convert.ToInt32(txt_id.Text.Trim()),
                Usuario = txt_usuario.Text.Trim(),
                CodPerfil = Convert.ToInt32(cb_rol.Text.Trim()),
                FechaAsociacion = Convert.ToString(dtpFechaRegistro.Value),

            };
            Logica.AgregarUsuarioXPerfil(u);
            MessageBox.Show("Registro Completo");
            Limpiar();
            CargarListado();
        }

        private void btn_ModificarProveedor_Click(object sender, EventArgs e)
        {
            UsuarioporPerfil u = new UsuarioporPerfil
            {
                UsuarioId = Convert.ToInt32(txt_id.Text.Trim()),
                Usuario = txt_usuario.Text.Trim(),
                CodPerfil = Convert.ToInt32(cb_rol.Text.Trim()),
                FechaAsociacion = Convert.ToString(dtpFechaRegistro.Value),

            };
            Logica.ModificarUsuarioXPerfil(u);
            MessageBox.Show("Informacion Actualizada");
            Limpiar();
            CargarListado();
        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            UsuarioporPerfil u = new UsuarioporPerfil
            {
                UsuarioId = Convert.ToInt32(txt_id.Text.Trim()),

            };
            Logica.EliminarUsuarioXPerfil(u);
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

       
    







