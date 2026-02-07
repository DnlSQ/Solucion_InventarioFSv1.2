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
    public partial class frmMenu : Form
    {
        public Usuario UsuarioConectado { get; set; }

        public frmMenu()
        {
            InitializeComponent();
        }

        public void CargarOpcionesMenu()
        {
            tssl_UsuarioLogin.Text = UsuarioConectado.NUsuario;

            serviciosToolStripMenuItem.Visible = false;
            citasToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = false;
            consultasToolStripMenuItem.Visible = false;
            cerrarSesionToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem2.Visible = false;
            asignacionDeRolToolStripMenuItem.Visible = false;
            registrosDeInsumosPorServicioToolStripMenuItem.Visible = false;

            List<Perfil> lstresultados = Logica.Autorizacion(UsuarioConectado);
            foreach (Perfil item in lstresultados)
            {
                switch (item.ID_Codigo) 
                {
                    //Administrador
                    case 1:  
                        {
                            serviciosToolStripMenuItem.Visible = true;
                            citasToolStripMenuItem.Visible = true;
                            inventarioToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem.Visible = true;
                            consultasToolStripMenuItem.Visible = true;
                            cerrarSesionToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem2.Visible = true;
                            asignacionDeRolToolStripMenuItem.Visible = true;
                            registrosDeInsumosPorServicioToolStripMenuItem.Visible = true;
                        } break;
                    //Estilista
                    case 2:  
                        {
                            consultasToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem1.Visible = false;
                            cerrarSesionToolStripMenuItem.Visible = true;
                        } break;
                    //Recepcionista
                    case 3:  
                        {
                            serviciosToolStripMenuItem.Visible = true;
                            citasToolStripMenuItem.Visible = true;
                            inventarioToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem.Visible = true;
                            consultasToolStripMenuItem.Visible = true;
                            cerrarSesionToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem2.Visible = true;
                            asignacionDeRolToolStripMenuItem.Visible = true;
                            registrosDeInsumosPorServicioToolStripMenuItem.Visible = true;


                        } break;
                    //Manicurista
                    case 4:
                        {
                            consultasToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem1.Visible = false;
                            cerrarSesionToolStripMenuItem.Visible = true;
                        }
                        break;
                    //Barbero
                    case 5:
                        {
                            consultasToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem1.Visible = false;
                            cerrarSesionToolStripMenuItem.Visible = true;
                        }
                        break;
                    //Pedicurista
                    case 6:
                        {
                            consultasToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem1.Visible = false;
                            cerrarSesionToolStripMenuItem.Visible = true;
                        }
                        break;
                    //Asistente
                    case 10:
                        {
                            consultasToolStripMenuItem.Visible = true;
                            clientesToolStripMenuItem1.Visible = false;
                            cerrarSesionToolStripMenuItem.Visible = true;

                        }
                        break;
                }
            }

            if (lstresultados.Count == 0)
                MessageBox.Show("Usuario conectado no cuenta con permisos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                frm.Show();

                serviciosToolStripMenuItem.Visible = false;
                citasToolStripMenuItem.Visible = false;
                inventarioToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;
                consultasToolStripMenuItem.Visible = false;
                cerrarSesionToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem2.Visible = false;
                asignacionDeRolToolStripMenuItem.Visible = false;
                registrosDeInsumosPorServicioToolStripMenuItem.Visible = false;


            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClientes frm = new frmConsultaClientes();
            frm.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaInventario frm = new frmConsultaInventario();
            frm.Show();
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCitas frm = new frmConsultaCitas();
            frm.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario frm = new frmInventario();
            frm.Show();
        }


        private void registroDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitas frm = new frmCitas();
            frm.Show();

        }


        private void colaboradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frm = new frmRegistroUsuario();
            frm.Show();
        }

       

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaServicios frm = new frmConsultaServicios();
            frm.Show();
        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCliente frm = new frmRegistroCliente();
            frm.Show();
        }

        private void registroDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicios frm = new frmServicios();
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProveedor frm = new frmConsultarProveedor();
            frm.Show();
        }

        private void registrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.Show();
        }

        private void asignacionDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarRol frm = new frmAsignarRol();
            frm.Show();
        }

        private void registrosDeInsumosPorServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsumoXServicio frm = new frmInsumoXServicio();
            frm.Show();
        }
    }
}
