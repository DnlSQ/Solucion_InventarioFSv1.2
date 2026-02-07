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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario U = new Usuario
                {
                    NUsuario = txtUsuario.Text.Trim(),
                    Pass = txtPass.Text.Trim(),
                };

               Usuario resultado = Logica.Autenticacion(U);
                if (resultado != null && resultado?.NUsuario.Length > 0)
                {
                    frmMenu frm = new frmMenu();
                    frm.UsuarioConectado = new Usuario { NUsuario=txtUsuario.Text.Trim() }; //Aqui se translada el usuario a frmMenu
                    frm.CargarOpcionesMenu(); //Aqui se validan las opciones que se muestran sugun el usuario
                    frm.Show();


                }
                else MessageBox.Show("Usuario y/o Contraseña incorrectos", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
