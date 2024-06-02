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
    public partial class CategoriasEdicion : Form
    {
        private bool Validar()
        {
            bool Valido = true;
            try
            {
                if (txbCategoria.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCategoria, "Este campo no puede quedar vacío");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {

                    if (string.IsNullOrEmpty(txbID_Categoria.Text))
                    {
                        CLS.Categorias nuevaCategoria = new CLS.Categorias(0, txbCategoria.Text);
                        nuevaCategoria.Categoria = txbCategoria.Text;

                        if (nuevaCategoria.InsertarCategoria())
                        {
                            MessageBox.Show("Registro creado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear la categoría");
                        }
                    }
                    else
                    {
                        CLS.Categorias categoriaExistente = new CLS.Categorias(Convert.ToInt32(txbID_Categoria.Text), txbCategoria.Text);
                        categoriaExistente.Categoria = txbCategoria.Text;

                        if (categoriaExistente.ActualizarCategoria())
                        {
                            MessageBox.Show("Registro actualizado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la categoría");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public CategoriasEdicion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
