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
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txbIDCategoria.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbIDCategoria, "Este campo no puede quedar vacío");
                    Valido = false;
                }

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
                if (string.IsNullOrEmpty(txbIDCategoria.Text))
                {
                    CLS.Categorias nuevaCategoria = new CLS.Categorias(0, txbCategoria.Text);
                    nuevaCategoria.Categoria = txbCategoria.Text;

                    if (nuevaCategoria.InsertarCategoria())
                    {
                        MessageBox.Show("Categoría creada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la categoría");
                    }
                }
                else
                {
                    CLS.Categorias categoriaExistente = new CLS.Categorias(Convert.ToInt32(txbIDCategoria.Text), txbCategoria.Text);
                    categoriaExistente.Categoria = txbCategoria.Text;

                    if (categoriaExistente.ActualizarCategoria())
                    {
                        MessageBox.Show("Categoría actualizada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la categoría");
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
