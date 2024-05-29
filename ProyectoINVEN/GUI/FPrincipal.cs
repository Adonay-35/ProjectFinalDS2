using General.GUI;
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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
            Personalizar();
        }

        private void Personalizar()
        {
            panelControlAcceso.Visible = false;
            panelInventarioSumin.Visible = false;
            panelPersonalClientes.Visible = false;
            panelRegistros.Visible = false;
        }

        private void OcultarSubmenu()
        {
            if (panelControlAcceso.Visible == true)
            {
                panelControlAcceso.Visible = false;
            }
            if (panelInventarioSumin.Visible == true)
            {
                panelInventarioSumin.Visible = false;
            }
            if (panelPersonalClientes.Visible == true)
            {
                panelPersonalClientes.Visible = false;
            }
            if (panelRegistros.Visible == true)
            {
                panelRegistros.Visible = false;
            }
        }

        private void MostrarSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else 
            {
                submenu.Visible = false;
            }
        }

        private void btnControlAcceso_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelControlAcceso);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirPanelContenedor(new General.GUI.UsuariosGestion());
                
                // Código de invocación de formularios

                OcultarSubmenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}");
            }
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            //Codigode invocacion de formularios

            OcultarSubmenu();
        }

        private void btnPersonalClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelPersonalClientes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirPanelContenedor(new General.GUI.ClientesGestion());

            OcultarSubmenu();
           
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirPanelContenedor(new General.GUI.EmpleadosGestion());

            OcultarSubmenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirPanelContenedor(new General.GUI.ProductosGestion());

            OcultarSubmenu();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirPanelContenedor(new General.GUI.ProductosGestion());

            OcultarSubmenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirPanelContenedor(new General.GUI.VentasGestion());

            OcultarSubmenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //Codigode invocacion de formularios

            OcultarSubmenu();
        }

        private void btnInventarioSumin_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelInventarioSumin);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelRegistros);
        }
        private Form FormActivo = null;
        private void AbrirPanelContenedor(Form FormularioHijo)
        {
                if (FormActivo != null)
              
                    FormActivo.Close();
                    FormActivo = FormularioHijo;
                    FormularioHijo.TopLevel = false;
                    FormularioHijo.FormBorderStyle = FormBorderStyle.None;
                    FormularioHijo.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(FormularioHijo);
                    panelContenedor.Tag = FormularioHijo;
                    FormularioHijo.BringToFront();
                    FormularioHijo.Show();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightSlateGray;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.LightSlateGray;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnControlAcceso_MouseEnter(object sender, EventArgs e)
        {
            btnControlAcceso.BackColor = Color.LightSlateGray;
        }

        private void btnControlAcceso_MouseLeave(object sender, EventArgs e)
        {
            btnControlAcceso.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnPersonalClientes_MouseEnter(object sender, EventArgs e)
        {
            btnPersonalClientes.BackColor = Color.LightSlateGray;
        }

        private void btnPersonalClientes_MouseLeave(object sender, EventArgs e)
        {
            btnPersonalClientes.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnInventarioSumin_MouseEnter(object sender, EventArgs e)
        {
            btnInventarioSumin.BackColor = Color.LightSlateGray;
        }

        private void btnInventarioSumin_MouseLeave(object sender, EventArgs e)
        {
            btnInventarioSumin.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnRegistros_MouseEnter(object sender, EventArgs e)
        {
            btnRegistros.BackColor = Color.LightSlateGray;
        }

        private void btnRegistros_MouseLeave(object sender, EventArgs e)
        {
            btnRegistros.BackColor = Color.FromArgb(11, 7, 17);
        }
    }
}
