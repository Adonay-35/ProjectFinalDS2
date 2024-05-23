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
    public partial class EmpleadosEdicion : Form
    {
        private bool Validar()
        {
            bool Valido = true;
            try
            {
                if (txbNombre.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbNombre, "El campo Nombres no puede estar vacío");
                    Valido = false;
                }
                if (txbApellido.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbApellido, "El campo Apellidos no puede estar vacío");
                    Valido = false;
                }
                if (txbDui.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbDui, "El campo DUI no puede estar vacío");
                    Valido = false;
                }
                if (txbDireccion.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbDireccion, "El campo Dirección no puede estar vacío");
                    Valido = false;
                }
                if (txbTelefono.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbTelefono, "El campo Teléfono no puede estar vacío");
                    Valido = false;
                }
                if (txbCorreo.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCorreo, "El campo Correo no puede estar vacío");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }



        public EmpleadosEdicion()
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
                if (Validar())
                {
                    CLS.Empleados oEmpleado = new CLS.Empleados();

                    oEmpleado.Nombres = txbNombre.Text;
                    oEmpleado.Apellidos = txbApellido.Text;
                    oEmpleado.Dui = txbDui.Text;
                    oEmpleado.Direccion = txbDireccion.Text;
                    oEmpleado.Telefono = txbTelefono.Text;
                    oEmpleado.Correo = txbCorreo.Text;

                    if (txbIDEmpleado.Text.Trim().Length == 0)
                    {
                        if (oEmpleado.Insertar())
                        {
                            MessageBox.Show("Registro guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser guardado");
                        }
                    }
                    else
                    {
                        oEmpleado.IDEmpleado = Convert.ToInt32(txbIDEmpleado.Text);
                        if (oEmpleado.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser actualizado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
