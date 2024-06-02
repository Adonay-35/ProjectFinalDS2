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
    public partial class ProveedoresEdicion : Form
    {
        Proveedores metodosProveedores = new Proveedores();

        private bool Validar()
        {
            bool Valido = true;
            try
            {
                if (txbProveedor.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbProveedor, "Este campo no puede estar vacío");
                    Valido = false;
                }
                if (txbContacto.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbContacto, "Este campo no puede estar vacío");
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
                if (cbDepartamentos.SelectedIndex == -1)
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

        public ProveedoresEdicion()
        {
            InitializeComponent();
        }

        public void MostrarMunicipios(ComboBox cbMunicipios)
        {
            List<Municipios> datos = metodosProveedores.ObtenerMunicipios();
            cbMunicipios.Items.Add("Selecciona una opción");
            foreach (Municipios dato in datos)
            {
                cbMunicipios.Items.Add(dato.Municipio);
            };
        }

        public void MostrarDistritos(ComboBox cbDistritos)
        {

            List<Distritos> datos = metodosProveedores.ObtenerDistritos();
            cbDistritos.Items.Add("Selecciona una opción");
            foreach (Distritos dato in datos)
            {
                cbDistritos.Items.Add(dato.Distrito);
            }
        }

        public void MostrarDepartamentos(ComboBox cbDepartamentos)
        {

            List<Departamentos> datos = metodosProveedores.ObtenerDepartamentos();
            cbDepartamentos.Items.Add("Selecciona una opción");
            foreach (Departamentos dato in datos)
            {
                cbDepartamentos.Items.Add(dato.Departamento);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    CLS.Proveedores oProveedor = new CLS.Proveedores();

                    oProveedor.Proveedor = txbProveedor.Text;
                    oProveedor.Contacto = txbContacto.Text;
                    oProveedor.Correo = txbCorreo.Text;
                    oProveedor.Linea1 = txbLinea1.Text;
                    oProveedor.Linea2 = txbLinea2.Text;
                    oProveedor.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                    oProveedor.ID_Departamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);
                    oProveedor.ID_Municipio = Convert.ToInt32(cbMunicipios.SelectedIndex);
                    oProveedor.ID_Distrito = Convert.ToInt32(cbDistritos.SelectedIndex);

                    if (txbID_Proveedor.Text.Trim().Length == 0)
                    {
                        if (oProveedor.Insertar())
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
                        oProveedor.ID_Proveedor = Convert.ToInt32(txbID_Proveedor.Text);

                        oProveedor.Proveedor = txbProveedor.Text;
                        oProveedor.Contacto = txbContacto.Text;
                        oProveedor.Correo = txbCorreo.Text;
                        oProveedor.Linea1 = txbLinea1.Text;
                        oProveedor.Linea2 = txbLinea2.Text;
                        oProveedor.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                        oProveedor.ID_Departamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);
                        oProveedor.ID_Municipio = Convert.ToInt32(cbMunicipios.SelectedIndex);
                        oProveedor.ID_Distrito = Convert.ToInt32(cbDistritos.SelectedIndex);

                        if (oProveedor.Actualizar())
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
            catch (Exception)
            {
                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProveedoresEdicion_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbProveedor.Text))
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
