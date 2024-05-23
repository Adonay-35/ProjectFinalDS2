using SesionManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (oSesion.ValidarPermiso(1))
                //{
                    General.GUI.UsuariosGestion f = new General.GUI.UsuariosGestion();
                    f.MdiParent = this;
                    f.Show();
                //}
            }
            catch (Exception)
            {

            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ProductosGestion f = new General.GUI.ProductosGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {

            }
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.VentasGestion f = new General.GUI.VentasGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {

            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ClientesGestion f = new General.GUI.ClientesGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {

            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ProveedoresGestion f = new General.GUI.ProveedoresGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {

            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                f.MdiParent = this;
                f.Show();

            }
            catch (Exception)
            {

            }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Deseas salir del SIV?", "SIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Deseas cerrar sesión?", "SIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                this.Close();
                Login Login = new Login();
                Login.Show();
            }
        }
    }
}
