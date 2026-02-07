using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UX_InventarioFS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarEmpleadoFS frm = new frmRegistrarEmpleadoFS();
            frm.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioFS frm = new frmUsuarioFS();
            frm.Show();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroClienteFS frm = new frmRegistroClienteFS();
            frm.Show();

        }

        private void registroDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProductoFS frm = new frmRegistroProductoFS();
            frm.Show();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarProveedorFS frm = new frmRegistrarProveedorFS();
            frm.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenesCompra frm = new frmOrdenesCompra();
            frm.Show();

        }

        private void detalleDeOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleCompraFS frm = new frmDetalleCompraFS();
            frm.Show();
        }

        private void ordenDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenesVentaFS frm = new frmOrdenesVentaFS();
            frm.Show();
        }

        private void detalleDeOrdenDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleVentaFS frm = new frmDetalleVentaFS();
            frm.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAuditoriaEmpleados frm = new frmAuditoriaEmpleados();
            frm.Show();
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoriaCompras frm = new frmAuditoriaCompras();
            frm.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void historialDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialPrecio frm = new frmHistorialPrecio();
            frm.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClientesFS frm = new frmConsultaClientesFS();
            frm.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmconsultaInventarioFS frm = new frmconsultaInventarioFS();
            frm.Show();
        }

        private void ventaPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCOV_FS frm = new frmReporteCOV_FS();
            frm.Show();
        }

        private void stockExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteStock_FS frm = new frmReporteStock_FS();
            frm.Show();
        }
    }
}
