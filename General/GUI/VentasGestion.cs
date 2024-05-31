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
    
    public partial class VentasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.VENTAS(); // <---- PONER NOMBRE DE CONSULTA
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
                    _DATOS.Filter = "Cliente like '%" + txbFiltro.Text + "%'"; 

                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                VentasEdicion f = new VentasEdicion();
                f.ShowDialog();
                Cargar();
                lblRegistros.Text = _DATOS.Count.ToString();
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        VentasEdicion oVenta = new VentasEdicion();
                        oVenta.MostrarUsuarios(oVenta.cbUsuarios);
                        oVenta.MostrarClientes(oVenta.cbClientes);
                        oVenta.MostrarProductos(oVenta.cbProductos);
                        oVenta.txbIDVenta.Text = dataGridView1.CurrentRow.Cells["IDVenta"].Value.ToString();
                        //oVenta.txbFechaVenta.Text = dataGridView1.CurrentRow.Cells["FechaVenta"].Value.ToString();
                        oVenta.cbUsuarios.SelectedItem = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                        oVenta.cbClientes.SelectedItem = dataGridView1.CurrentRow.Cells["Cliente"].Value.ToString();
                        oVenta.cbProductos.SelectedItem = dataGridView1.CurrentRow.Cells["Producto"].Value.ToString();
                        oVenta.txbPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                        oVenta.txbCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                        oVenta.txbTotal.Text = dataGridView1.CurrentRow.Cells["Total"].Value.ToString();
                        oVenta.ShowDialog();

                        Cargar();
                    }
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Ventas oVenta = new Ventas();
                        oVenta.IDVenta = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDVenta"].Value.ToString());

                        if (oVenta.Eliminar())
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


        public VentasGestion()
        {
            InitializeComponent();
        }

        private void VentasGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            lblRegistros.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SELECCIONAR TODA LA FILA
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
