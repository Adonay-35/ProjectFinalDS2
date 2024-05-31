using General.CLS;
using MySql.Data.MySqlClient.Memcached;
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
    public partial class EmpleadosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.EMPLEADOS();
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
                    _DATOS.Filter = "Nombres like '%" + txbFiltro.Text + "%'";
                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }

        public EmpleadosGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadosEdicion f = new EmpleadosEdicion();
                f.ShowDialog();
                Cargar();
                lblRegistros.Text = _DATOS.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EmpleadosEdicion oEmpleadoEdicion = new EmpleadosEdicion();
                    oEmpleadoEdicion.MostrarDepartamentos(oEmpleadoEdicion.cbDepartamentos);
                    oEmpleadoEdicion.MostrarMunicipios(oEmpleadoEdicion.cbMunicipios);
                    oEmpleadoEdicion.MostrarDistritos(oEmpleadoEdicion.cbDistritos);
                    oEmpleadoEdicion.txbIDEmpleado.Text = dataGridView1.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    oEmpleadoEdicion.txbNombre.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                    oEmpleadoEdicion.txbApellido.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                    oEmpleadoEdicion.txbDui.Text = dataGridView1.CurrentRow.Cells["DUI"].Value.ToString();
                    oEmpleadoEdicion.txbTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                    oEmpleadoEdicion.txbCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                    oEmpleadoEdicion.txbLinea1.Text = dataGridView1.CurrentRow.Cells["Linea1"].Value.ToString();
                    oEmpleadoEdicion.txbLinea2.Text = dataGridView1.CurrentRow.Cells["Linea2"].Value.ToString();
                    oEmpleadoEdicion.txbCodigoPostal.Text = dataGridView1.CurrentRow.Cells["CodigoPostal"].Value.ToString();
                    oEmpleadoEdicion.cbDepartamentos.SelectedItem = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
                    oEmpleadoEdicion.cbMunicipios.SelectedItem = dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString();
                    oEmpleadoEdicion.cbDistritos.SelectedItem = dataGridView1.CurrentRow.Cells["Distrito"].Value.ToString();
                    oEmpleadoEdicion.ShowDialog();
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Empleados oEmpleado = new Empleados();
                        oEmpleado.IDEmpleado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDEmpleado"].Value.ToString());

                        if (oEmpleado.Eliminar())
                        {
                            MessageBox.Show("Registro eliminado");
                        }
                        else
                        {
                            MessageBox.Show("El registro no ha sido eliminado");
                        }

                        Cargar();
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        private void EmpleadosGestion_Load(object sender, EventArgs e)
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
