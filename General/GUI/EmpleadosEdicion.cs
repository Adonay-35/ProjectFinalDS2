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
    public partial class EmpleadosEdicion : Form
    {
        Empleados metodosEmpleados = new Empleados();

        private bool Validar()
        {
            bool Valido = true;
            try
            {
                if (txbNombre.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbNombre, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbApellido.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbApellido, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbDui.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbDui, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbTelefono.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbTelefono, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbCorreo.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCorreo, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbLinea1.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbLinea1, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbLinea2.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbLinea2, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbCodigoPostal.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCodigoPostal, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (cbDepartamentos.SelectedIndex == -1 || cbDepartamentos.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbDepartamentos, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (cbMunicipios.SelectedIndex == -1 || cbMunicipios.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbMunicipios, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (cbDistritos.SelectedIndex == -1 || cbDistritos.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbDistritos, "Este campo no puede estar vacío");
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
                    oEmpleado.FechaNacimiento = Convert.ToDateTime(txbFechaNacimiento.Text);
                    oEmpleado.Telefono = txbTelefono.Text;
                    oEmpleado.Correo = txbCorreo.Text;
                    oEmpleado.Linea1 = txbLinea1.Text;
                    oEmpleado.Linea2 = txbLinea2.Text;
                    oEmpleado.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                    oEmpleado.IDDepartamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);
                    oEmpleado.IDMunicipio = Convert.ToInt32(cbMunicipios.SelectedIndex);
                    oEmpleado.IDDistrito = Convert.ToInt32(cbDistritos.SelectedIndex);

                    if (txbID_Empleado.Text.Trim().Length == 0)
                    {
                        if (oEmpleado.Insertar())
                        {
                            MessageBox.Show("Registro creado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser guardado");
                        }
                    }
                    else
                    {
                        oEmpleado.ID_Empleado = Convert.ToInt32(txbID_Empleado.Text);

                        oEmpleado.Nombres = txbNombre.Text;
                        oEmpleado.Apellidos = txbApellido.Text;
                        oEmpleado.FechaNacimiento = Convert.ToDateTime(txbFechaNacimiento.Text);
                        oEmpleado.Dui = txbDui.Text;
                        oEmpleado.Telefono = txbTelefono.Text;
                        oEmpleado.Correo = txbCorreo.Text;
                        oEmpleado.Linea1 = txbLinea1.Text;
                        oEmpleado.Linea2 = txbLinea2.Text;
                        oEmpleado.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                        oEmpleado.IDDepartamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);
                        oEmpleado.IDMunicipio = Convert.ToInt32(cbMunicipios.SelectedIndex);
                        oEmpleado.IDDistrito = Convert.ToInt32(cbDistritos.SelectedIndex);

                        if (oEmpleado.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado exitosamente");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void MostrarMunicipios(ComboBox cbMunicipios)
        {
            List<Municipios> datos = metodosEmpleados.ObtenerMunicipios();
            cbMunicipios.Items.Add("Selecciona una opción");
            foreach (Municipios dato in datos)
            {
                cbMunicipios.Items.Add(dato.Municipio);
            };
        }

        public void MostrarDistritos(ComboBox cbDistritos)
        {

            List<Distritos> datos = metodosEmpleados.ObtenerDistritos();
            cbDistritos.Items.Add("Selecciona una opción");
            foreach (Distritos dato in datos)
            {
                cbDistritos.Items.Add(dato.Distrito);
            }
        }

        public void MostrarDepartamentos(ComboBox cbDepartamentos)
        {

            List<Departamentos> datos = metodosEmpleados.ObtenerDepartamentos();
            cbDepartamentos.Items.Add("Selecciona una opción");
            foreach (Departamentos dato in datos)
            {
                cbDepartamentos.Items.Add(dato.Departamento);
            }
        }

        private void EmpleadosEdicion_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbID_Empleado.Text))
            {
                this.MostrarMunicipios(cbMunicipios);
                this.MostrarDistritos(cbDistritos);
                this.MostrarDepartamentos(cbDepartamentos);
                cbMunicipios.SelectedIndex = 0;
                cbDistritos.SelectedIndex = 0;
                cbDepartamentos.SelectedIndex = 0;
            }
        }
    }
}
