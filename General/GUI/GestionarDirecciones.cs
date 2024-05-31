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
    public partial class GestionarDirecciones : Form
    {
        Direcciones metodosDirecciones = new Direcciones();

        BindingSource _DATOS = new BindingSource();


        public GestionarDirecciones()
        {
            InitializeComponent();
        }


        public void MostrarMunicipios(ComboBox cbMunicipios)
        {
            List<Municipios> datos = metodosDirecciones.ObtenerMunicipios();
            cbMunicipios.Items.Add("Selecciona una opción");
            foreach (Municipios dato in datos)
            {
                cbMunicipios.Items.Add(dato.Municipio);
            };
        }

        public void MostrarDistritos(ComboBox cbDistritos)
        {

            List<Distritos> datos = metodosDirecciones.ObtenerDistritos();
            cbDistritos.Items.Add("Selecciona una opción");
            foreach (Distritos dato in datos)
            {
                cbDistritos.Items.Add(dato.Distrito);
            }
        }

        public void MostrarDepartamentos(ComboBox cbDepartamentos)
        {

            List<Departamentos> datos = metodosDirecciones.ObtenerDepartamentos();
            cbDepartamentos.Items.Add("Selecciona una opción");
            foreach (Departamentos dato in datos)
            {
                cbDepartamentos.Items.Add(dato.Departamento);
            }
        }

        private void GestionarDirecciones_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbLinea1.Text))
            {
                this.MostrarMunicipios(cbMunicipios);
                this.MostrarDistritos(cbDistritos);
                this.MostrarDepartamentos(cbDepartamentos);
                cbMunicipios.SelectedIndex = 0;
                cbDistritos.SelectedIndex = 0;
                cbDepartamentos.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txbID_Direccion.Text.Trim()))
            {
                // Crear una nueva dirección
                CLS.Direcciones oDireccion = new CLS.Direcciones();

                oDireccion.Linea1 = txbLinea1.Text;
                oDireccion.Linea2 = txbLinea2.Text;
                oDireccion.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                oDireccion.ID_Municipio= Convert.ToInt32(cbMunicipios.SelectedIndex);
                oDireccion.ID_Distrito = Convert.ToInt32(cbDistritos.SelectedIndex);
                oDireccion.ID_Departamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);

                // Crear una nueva dirección
                if (oDireccion.Insertar())
                {
                    MessageBox.Show("Dirección creada exitosamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al crear dirección");
                }
            }
            else
            {
                // Actualizar una dirección existente
                CLS.Direcciones oDireccion = new CLS.Direcciones();

                oDireccion.ID_Direccion = Convert.ToInt32(txbID_Direccion.Text);
                oDireccion.Linea1 = txbLinea1.Text;
                oDireccion.Linea2 = txbLinea2.Text;
                oDireccion.CodigoPostal = Convert.ToInt32(txbCodigoPostal.Text);
                oDireccion.ID_Municipio = Convert.ToInt32(cbMunicipios.SelectedIndex);
                oDireccion.ID_Distrito = Convert.ToInt32(cbDistritos.SelectedIndex);
                oDireccion.ID_Departamento = Convert.ToInt32(cbDepartamentos.SelectedIndex);

                // Actualizar una dirección existente
                if (oDireccion.Actualizar())
                {
                    MessageBox.Show("Dirección actualizada exitosamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar dirección");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
