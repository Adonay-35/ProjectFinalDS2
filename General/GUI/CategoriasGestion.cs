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
    public partial class CategoriasGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.CATEGORIAS();
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
                    _DATOS.Filter = "Categoria like '%" + txbFiltro.Text + "%'";
                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public CategoriasGestion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriasEdicion f = new CategoriasEdicion();
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
                if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CategoriasEdicion oCategoriasEdicion = new CategoriasEdicion();
                    oCategoriasEdicion.txbID_Categoria.Text = dataGridView1.CurrentRow.Cells["ID_Categoria"].Value.ToString();
                    oCategoriasEdicion.txbCategoria.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                    oCategoriasEdicion.ShowDialog();
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
                    CLS.Categorias oCategoria = new CLS.Categorias((Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Categoria"].Value.ToString())), "dummyCategoria");
                    oCategoria.ID_Categoria = (Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Categoria"].Value.ToString()));
                    if (oCategoria.EliminarCategoria())
                    {
                        MessageBox.Show("Registro eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("El Registro no ha sido eliminado");
                    }
                    Cargar();
                    lblRegistros.Text = _DATOS.Count.ToString();
                }
            }
            catch (Exception)
            {

            }
        }


        private void CategoriasGestion_Load(object sender, EventArgs e)
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
