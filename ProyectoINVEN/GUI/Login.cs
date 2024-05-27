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
            string query = @"SELECT IDUsuario, Usuario, IDEmpleado, IDRol FROM usuarios WHERE Usuario = '" + txbUsuario.Text + "' AND Clave = '" + claveHasheada + "'";
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
                lblMensaje.Text = "USUARIO O CLAVE ERRONEOS.";
            }
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

