﻿using DataLayer;
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
            DBOperacion oOperacion = new DBOperacion();
            string query = @"SELECT ID_Usuario, Usuario, ID_Empleado, ID_Rol, ID_Estado FROM usuarios WHERE Usuario = '" + txbUsuario.Text + "' AND Clave = '" + claveHasheada + "'";
            dt = oOperacion.Consultar(query);

            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                int estado = Convert.ToInt32(row["ID_Estado"]);

                if (estado == 2) // 2 es activo
                {
                    Sesion oSesion = Sesion.ObtenerInstancia();
                    oSesion.Usuario = txbUsuario.Text;
                    _Autorizado = true;
                    Close();
                }
                else // 1 es inactivo
                {
                    MessageBox.Show("El usuario está inactivo. Por favor, contacte al administrador.",
                    "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }
            }
            else
            {
                MessageBox.Show("Las credenciales ingresadas no son válidas o el usuario no existe. Por favor, inténtelo nuevamente.",
                "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Application.Exit();
        }

        private void txbClave_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

