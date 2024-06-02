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
    public partial class ClientesEdicion : Form
    {
        Clientes metodosClientes = new Clientes();

        private bool Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txbNombres.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbNombres, "El campo Proveedor no puede estar vacío");
                    Valido = false;
                }
                if (txbApellidos.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbApellidos, "El campo Contacto no puede estar vacío");
                    Valido = false;
                }
                if (txbCorreo.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCorreo, "El campo Email no puede estar vacío");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }

        public void MostrarMunicipios(ComboBox cbMunicipios)
        {
            List<Municipios> datos = metodosClientes.ObtenerMunicipios();
            cbMunicipios.Items.Add("Selecciona una opción");
            foreach (Municipios dato in datos)
            {
                cbMunicipios.Items.Add(dato.Municipio);
            };
        }

        public void MostrarDistritos(ComboBox cbDistritos)
        {

            List<Distritos> datos = metodosClientes.ObtenerDistritos();
            cbDistritos.Items.Add("Selecciona una opción");
            foreach (Distritos dato in datos)
            {
                cbDistritos.Items.Add(dato.Distrito);
            }
        }

        public void MostrarDepartamentos(ComboBox cbDepartamentos)
        {

            List<Departamentos> datos = metodosClientes.ObtenerDepartamentos();
            cbDepartamentos.Items.Add("Selecciona una opción");
            foreach (Departamentos dato in datos)
            {
                cbDepartamentos.Items.Add(dato.Departamento);
            }
        }

        public ClientesEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    CLS.Clientes oCliente = new CLS.Clientes();

                    oCliente.Nombres = txbNombres.Text;
                    oCliente.Apellidos = txbApellidos.Text;
                    oCliente.Correo = txbCorreo.Text;
                    oCliente.Linea1 = txbLinea1.Text;
                    oCliente.Linea2 = txbLinea2.Text;
                    oCliente.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                    oCliente.IDDepartamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);
                    oCliente.IDMunicipio = Convert.ToInt32(cbMunicipios.SelectedIndex);
                    oCliente.IDDistrito = Convert.ToInt32(cbDistritos.SelectedIndex);

                    if (txbID_Cliente.Text.Trim().Length == 0)
                    {
                        if (oCliente.Insertar())
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
                        oCliente.ID_Cliente = Convert.ToInt32(txbID_Cliente.Text);

                        oCliente.Nombres = txbNombres.Text;
                        oCliente.Apellidos = txbApellidos.Text;
                        oCliente.Correo = txbCorreo.Text;
                        oCliente.Linea1 = txbLinea1.Text;
                        oCliente.Linea2 = txbLinea2.Text;
                        oCliente.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                        oCliente.IDDepartamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);
                        oCliente.IDMunicipio = Convert.ToInt32(cbMunicipios.SelectedIndex);
                        oCliente.IDDistrito = Convert.ToInt32(cbDistritos.SelectedIndex);

                        if (oCliente.Actualizar())
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
            catch (Exception)
            {
                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientesEdicion_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbID_Cliente.Text))
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

