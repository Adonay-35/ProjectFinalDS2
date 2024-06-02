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

        private bool Validar()
        {
            bool Valido = true;
            try
            {
                if (txbUsuario.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbUsuario, "Este campo no puede quedar vacio");
                    Valido = false;
                }

                if (cbEmpleados.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbEmpleados, "Este campo no puede quedar vacio");
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

        public void MostrarEstados(ComboBox cbEstados)
        {
            List<Estados> datos = metodosUsuarios.ObtenerEstados();
            cbEstados.Items.Add("Selecciona una opción");
            foreach (Estados dato in datos)
            {
                cbEstados.Items.Add(dato.Descripcion);
            }
        }

        public void MostrarRoles(ComboBox cbRoles)
        {
            List<Roles> datos = metodosUsuarios.ObtenerRoles();
            cbRoles.Items.Add("Selecciona una opción");
            foreach (Roles dato in datos)
            {
                cbRoles.Items.Add(dato.Rol);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (string.IsNullOrEmpty(txbID_Usuario.Text))
                    {
                        // Crear nuevo usuario
                        CLS.Usuarios nuevoUsuario = new CLS.Usuarios(0, txbUsuario.Text); // Usa 0 para ID_Usuario si es un nuevo usuario
                        nuevoUsuario.Usuario = txbUsuario.Text;
                        nuevoUsuario.Clave = txbClave.Text;
                        nuevoUsuario.ID_Rol = Convert.ToInt32(cbRoles.SelectedIndex);
                        nuevoUsuario.ID_Empleado = Convert.ToInt32(cbEmpleados.SelectedIndex);
                        nuevoUsuario.ID_Estado = Convert.ToInt32(cbEstados.SelectedIndex);


                        if (nuevoUsuario.Insertar())
                        {
                            MessageBox.Show("Usuario creado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear usuario");
                        }
                    }
                    else
                    {
                        // Actualizar usuario existente
                        CLS.Usuarios usuarioExistente = new CLS.Usuarios(Convert.ToInt32(txbID_Usuario.Text), txbUsuario.Text);
                        usuarioExistente.Usuario = txbUsuario.Text;
                        usuarioExistente.Clave = txbClave.Text;
                        usuarioExistente.ID_Rol = Convert.ToInt32(cbRoles.SelectedIndex);
                        usuarioExistente.ID_Empleado = Convert.ToInt32(cbEmpleados.SelectedIndex);
                        usuarioExistente.ID_Estado = Convert.ToInt32(cbEstados.SelectedIndex);

                        if (usuarioExistente.Actualizar())
                        {
                            MessageBox.Show("Usuario actualizado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar usuario");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarEmpleados(ComboBox cbEmpleados)
        {
            List<Empleados> datos = metodosUsuarios.ObtenerEmpleados();
            cbEmpleados.Items.Add("Selecciona una opción");
            foreach (Empleados dato in datos)
            {
                cbEmpleados.Items.Add(dato.Nombres + " " + dato.Apellidos);
            }
        }

        private void UsuariosEdicion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbID_Usuario.Text))
            {
                this.MostrarEstados(cbEstados);
                this.MostrarRoles(cbRoles);
                this.MostrarEmpleados(cbEmpleados);
                cbEmpleados.SelectedIndex = 0;
                cbEstados.SelectedIndex = 0;
                cbRoles.SelectedIndex = 0;
            }
        }

        private void btnCancealr_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
