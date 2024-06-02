﻿using General.CLS;
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
        private bool Validar()
        {
            bool Valido = true;
            try
            {
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (string.IsNullOrEmpty(txbID_Rol.Text))
                    {
                        CLS.Roles nuevoRol = new CLS.Roles();

                        nuevoRol.Rol = txbRol.Text;

                        if (nuevoRol.Insertar())
                        {
                            MessageBox.Show("Registro creado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear rol");
                        }
                    }
                    else
                    {
                        CLS.Roles rolExistente = new CLS.Roles();

                        rolExistente.ID_Rol = Convert.ToInt32(txbID_Rol.Text);
                        rolExistente.Rol = txbRol.Text;

                        if (rolExistente.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado exitosamente");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
