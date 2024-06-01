using DataLayer;
using General.CLS;
using SesionManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.GUI
{
    public partial class Login : Form
    {
        private Boolean _Autorizado = false;

        public bool Autorizado { get => _Autorizado; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string claveHasheada = Encryptar.GetSHA256(txbClave.Text.Trim());

            DataTable dt = new DataTable();
            DataLayer.DBOperacion oOperacion = new DataLayer.DBOperacion();
            string query = @"SELECT ID_Usuario, Usuario, ID_Empleado, IDRol FROM usuarios WHERE Usuario = '" + txbUsuario.Text + "' AND Clave = '" + claveHasheada + "'";
            dt = oOperacion.Consultar(query);

            if (dt.Rows.Count == 1)
            {
                SesionManager.Sesion oSesion = SesionManager.Sesion.ObtenerInstancia();
                oSesion.Usuario = txbUsuario.Text;
                _Autorizado = true;
                Close();
            }
            else
            {
                MessageBox.Show("Las credenciales ingresadas no son válidas. Por favor, inténtelo nuevamente.", 
                "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //lblMensaje.ForeColor = Color.Red;
                //lblMensaje.Text = "USUARIO O CLAVE ERRONEOS";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "USUARIO")
            {
                txbUsuario.Text = "";
                txbUsuario.ForeColor = Color.LightGray;

            }

        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "")
            {
                txbUsuario.Text = "USUARIO";
                txbUsuario.ForeColor = Color.DimGray;
            }

        }

        private void txbClave_Enter(object sender, EventArgs e)
        {
            if (txbClave.Text == "CONTRASEÑA")
            {
                txbClave.Text = "";
                txbClave.ForeColor = Color.LightGray;
                txbClave.UseSystemPasswordChar = true;
            }
            
        }

        private void txbClave_Leave(object sender, EventArgs e)
        {
            if (txbClave.Text == "")
            {
                txbClave.Text = "CONTRASEÑA";
                txbClave.ForeColor = Color.DimGray;
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Deseas salir?", "SIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

    }
    }

