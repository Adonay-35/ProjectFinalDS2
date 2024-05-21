using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class UsuariosEdicion : Form
    {
        Usuarios metodosUsuarios = new Usuarios();
        //DataTable datos;
        //int idUsuario = 0;

        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txbUsuario.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbUsuario, "Este campo no puede quedar vacio");
                    Valido = false;
                }

                if (txbClave.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbClave, "Este campo no puede quedar vacio");
                    Valido = false;
                }

                if (txbIDEmpleado.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbIDEmpleado, "Este campo no puede quedar vacio");
                    Valido = false;
                }

                if (cbRoles.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbRoles, "Este campo no puede quedar vacio");
                    Valido = false;
                }

                if (cbEstados.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbEstados, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }
        public UsuariosEdicion()
        {
            InitializeComponent();
        }

        private void MostrarEstados(ComboBox cbEstados)
        {
            List<Estados> datos = metodosUsuarios.ObtenerEstados();
            cbEstados.Items.Add("Selecciona una opción");
            foreach (Estados dato in datos)
            {
                cbEstados.Items.Add(dato.Estado + 1 + "- " + dato.Descripcion);
            }
            cbEstados.SelectedIndex = 0;
        }

        private void UsuariosEdicion_Load(object sender, EventArgs e)
        {
            this.MostrarEstados(cbEstados);
            this.MostrarRoles(cbRoles);
        }

        private void MostrarRoles(ComboBox cbRoles)
        {
            List<Roles> datos = metodosUsuarios.ObtenerRoles();
            cbRoles.Items.Add("Selecciona una opción");
            foreach (Roles dato in datos)
            {
                cbRoles.Items.Add(dato.Rol);
            }
            cbRoles.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txbIDUsuario.Text))
                {
                    // Crear nuevo usuario
                    CLS.Usuarios nuevoUsuario = new CLS.Usuarios(0, txbUsuario.Text); // Usa 0 para IDUsuario si es un nuevo usuario
                    nuevoUsuario.Usuario = txbUsuario.Text;
                    nuevoUsuario.Clave = txbClave.Text;
                    nuevoUsuario.IDRol = Convert.ToInt32(cbRoles.SelectedValue);
                    nuevoUsuario.IDEmpleado = Convert.ToInt32(txbIDEmpleado.Text);
                    nuevoUsuario.IDEstado = Convert.ToInt32(cbEstados.SelectedValue);

                    if (nuevoUsuario.Insertar())
                    {
                        MessageBox.Show("Usuario creado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al crear usuario");
                    }
                }
                else
                {
                    // Actualizar usuario existente
                    CLS.Usuarios usuarioExistente = new CLS.Usuarios(Convert.ToInt32(txbIDUsuario.Text), txbUsuario.Text);
                    usuarioExistente.Usuario = txbUsuario.Text;
                    usuarioExistente.Clave = txbClave.Text;
                    usuarioExistente.IDRol = Convert.ToInt32(cbRoles.SelectedValue);
                    usuarioExistente.IDEmpleado = Convert.ToInt32(txbIDEmpleado.Text);
                    usuarioExistente.IDEstado = Convert.ToInt32(cbEstados.SelectedValue);

                    if (usuarioExistente.Actualizar())
                    {
                        MessageBox.Show("Usuario actualizado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar usuario");
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
