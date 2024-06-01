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
    public partial class ProveedoresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.PROVEEDORES();
                FiltrarLocalmente();
            }
            catch (Exception)
            {

            }
        }

        private void FiltrarLocalmente()
        {
            try
            {
                if (txbFiltro.Text.Trim().Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    _DATOS.Filter = "Proveedor like '%" + txbFiltro.Text + "%'";
                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }

        public ProveedoresGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedoresEdicion f = new ProveedoresEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProveedoresEdicion oProveedor = new ProveedoresEdicion();

                    oProveedor.MostrarDepartamentos(oProveedor.cbDepartamentos);
                    oProveedor.MostrarMunicipios(oProveedor.cbMunicipios);
                    oProveedor.MostrarDistritos(oProveedor.cbDistritos);
                    oProveedor.txbID_Proveedor.Text = dataGridView1.CurrentRow.Cells["ID_Proveedor"].Value.ToString();
                    oProveedor.txbProveedor.Text = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();
                    oProveedor.txbContacto.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Contacto"].Value).ToString();
                    oProveedor.txbCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                    oProveedor.txbLinea1.Text = dataGridView1.CurrentRow.Cells["Linea1"].Value.ToString();
                    oProveedor.txbLinea2.Text = dataGridView1.CurrentRow.Cells["Linea2"].Value.ToString();
                    oProveedor.txbCodigoPostal.Text = dataGridView1.CurrentRow.Cells["CodigoPostal"].Value.ToString();
                    oProveedor.cbDepartamentos.SelectedItem = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
                    oProveedor.cbMunicipios.SelectedItem = dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString();
                    oProveedor.cbDistritos.SelectedItem = dataGridView1.CurrentRow.Cells["Distrito"].Value.ToString();
                    oProveedor.ShowDialog();
                    Cargar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Proveedores oProveedor = new CLS.Proveedores();
                    oProveedor.ID_Proveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Proveedor"].Value.ToString());

                    if (oProveedor.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("El registro no ha sido eliminado");
                    }
                    Cargar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ProveedoresGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            lblRegistros.Text = _DATOS.Count.ToString();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
