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
    public partial class RolesEdicion : Form
    {
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txbIDRol.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbIDRol, "Este campo no puede quedar vacio");
                    Valido = false;
                }

                if (txbRol.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbRol, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }

        public RolesEdicion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txbIDRol.Text))
                {
                    CLS.Roles nuevoRol = new CLS.Roles(0,txbRol.Text);
                    nuevoRol.Rol = txbRol.Text;

                    if (nuevoRol.Insertar())
                    {
                        MessageBox.Show("Rol creado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al crear rol");
                    }
                }
                else
                {
                    CLS.Roles rolExistente = new CLS.Roles(Convert.ToInt32(txbIDRol.Text), txbRol.Text);
                    rolExistente.Rol = txbRol.Text;

                    if (rolExistente.Actualizar())
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
