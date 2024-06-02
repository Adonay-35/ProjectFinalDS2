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
    public partial class ComprasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.COMPRAS(); // <---- PONER NOMBRE DE CONSULTA
                FiltrarLocalmente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
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
                    _DATOS.Filter = "Usuario like '%" + txbFiltro.Text + "%'";

                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }

        public ComprasGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ComprasEdicion f = new ComprasEdicion();
                f.ShowDialog();
                Cargar();
                lblRegistros.Text = _DATOS.Count.ToString();
            }
            catch (Exception)
            {

            } 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ComprasEdicion oCompra = new ComprasEdicion();
                        oCompra.MostrarUsuarios(oCompra.cbUsuarios);
                        oCompra.MostrarProveedores(oCompra.cbProveedores);
                        oCompra.MostrarProductos(oCompra.cbProductos);
                        oCompra.txbID_Compra.Text = dataGridView1.CurrentRow.Cells["ID_Compra"].Value.ToString();
                        oCompra.txbFechaCompra.Text = dataGridView1.CurrentRow.Cells["FechaCompra"].Value.ToString();
                        oCompra.cbUsuarios.SelectedItem = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                        oCompra.cbProveedores.SelectedItem = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();
                        oCompra.cbProductos.SelectedItem = dataGridView1.CurrentRow.Cells["Producto"].Value.ToString();
                        oCompra.txbCantidadEntrante.Text = dataGridView1.CurrentRow.Cells["CantidadEntrante"].Value.ToString();
                        oCompra.txbTotalPagar.Text = dataGridView1.CurrentRow.Cells["TotalPagar"].Value.ToString();
                        oCompra.ShowDialog();

                        Cargar();
                    }
                }
            }
            catch (Exception )
            {
               
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
                        Compras oCompra = new Compras();
                        oCompra.ID_Compra = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Compra"].Value.ToString());

                        if (oCompra.Eliminar())
                        {
                            MessageBox.Show("Compra eliminada exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("La compra no pudo ser eliminada");
                        }

                        Cargar();
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionarCompras_Load(object sender, EventArgs e)
        {
            Cargar();
            lblRegistros.Text = dataGridView1.Rows.Count.ToString();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
