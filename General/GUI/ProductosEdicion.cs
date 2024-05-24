using DataLayer;
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
    public partial class ProductosEdicion : Form
    {
        Productos metodosProveedores = new Productos();

        private Boolean Validar()
        {
            Boolean valido = true;
            try
            {
                if (txbProducto.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbProducto, "El campo 'Nombre Producto' no puede quedar vacío");
                    valido = false;
                }
                if (txbStock.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbStock, "El campo 'Stock' debe ser un valor mayor que cero");
                    valido = false;
                }
                if (txbPrecio.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbPrecio, "El campo 'Precio' debe ser un valor mayor que cero");
                    valido = false;
                }
                if (txbDescripcion.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbDescripcion, "El campo 'Descripción' no puede quedar vacío");
                    valido = false;
                }
                if (txbFechaFabricacion.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbFechaFabricacion, "El campo 'Fecha de Creación' no puede quedar vacío y debe ser una fecha válida");
                    valido = false;
                }
                if (txbFechaVencimiento.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbFechaVencimiento, "El campo 'Fecha de Vencimiento' no puede quedar vacío y debe ser una fecha válida");
                    valido = false;
                }
                if (cbProveedor.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbProveedor, "El campo 'ID Proveedor' debe ser un valor mayor que cero");
                    valido = false;
                }
                if (cbCategoria.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbCategoria, "El campo 'ID Categoría' debe ser un valor mayor que cero");
                    valido = false;
                }
            }
            catch (Exception)
            {
                valido = false;
            }
            return valido;
        }

        public ProductosEdicion()
        {
            InitializeComponent();
        }


        private void MostrarProveedores(ComboBox cbProveedor)
        {
            List<Proveedores> datos = metodosProveedores.ObtenerProveedores();
            cbProveedor.Items.Add("Selecciona una opción");
            foreach (Proveedores dato in datos)
            {
                cbProveedor.Items.Add(dato.Proveedor);
            }
            cbProveedor.SelectedIndex = 0;
        }

        private void MostrarCategorias(ComboBox cbCategoria)
        {

            List<Categorias> datos = metodosProveedores.ObtenerCategorias();
            cbCategoria.Items.Add("Selecciona una opción");
            foreach (Categorias dato in datos)
            {
                cbCategoria.Items.Add(dato.Categoria);
            }
            cbCategoria.SelectedIndex = 0;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    // Crear un nuevo producto
                    CLS.Productos oProducto = new CLS.Productos();

                    oProducto.Producto = txbProducto.Text;
                    oProducto.Stock = Convert.ToInt32(txbStock.Text);
                    oProducto.Precio = Convert.ToDouble(txbPrecio.Text);
                    oProducto.Descripcion = txbDescripcion.Text;
                    oProducto.IDProveedor = Convert.ToInt32(cbProveedor.SelectedIndex);
                    oProducto.FechaFabricacion = Convert.ToDateTime(txbFechaFabricacion.Text);
                    oProducto.FechaVencimiento = Convert.ToDateTime(txbFechaVencimiento.Text);
                    oProducto.IDCategoria = Convert.ToInt32(cbCategoria.SelectedIndex);

                    if (string.IsNullOrEmpty(txbIDProducto.Text.Trim()))
                    {
                        // Crear un nuevo producto
                        if (oProducto.Insertar())
                        {
                            MessageBox.Show("Producto creado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al crear producto");
                        }
                    }
                    else
                    {
                        oProducto.IDProducto = Convert.ToInt32(txbIDProducto.Text);
                        // Actualizar un producto existente
                        if (oProducto.Actualizar())
                        {
                            MessageBox.Show("Producto actualizado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar producto");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductosEdicion_Load(object sender, EventArgs e)
        {
            this.MostrarProveedores(cbProveedor);
            this.MostrarCategorias(cbCategoria); 
        }
    }
}
