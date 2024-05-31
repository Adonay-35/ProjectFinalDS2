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
        Productos metodosProductos = new Productos();

        private bool Validar()
        {
            bool valido = true;
            try
            {
                if (txbProducto.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbProducto, "Este campo' no puede quedar vacío");
                    valido = false;
                }
                if (txbStock.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbStock, "Este campo debe ser un valor mayor que cero");
                    valido = false;
                }
                if (txbPrecio.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbPrecio, "Este campo debe ser un valor mayor que cero");
                    valido = false;
                }
                if (txbDescripcion.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbDescripcion, "Este campo no puede quedar vacío");
                    valido = false;
                }
                if (txbFechaVencimiento.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbFechaVencimiento, "Este campo no puede quedar vacío");
                    valido = false;
                }
                if (txbFechaFabricacion.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbFechaFabricacion, "Este campo no puede quedar vacío");
                    valido = false;
                }
                if (cbProveedor.Text.Trim().Length == 0)
                {
                    Notificador.SetError(cbProveedor, "Este campo no puede quedar vacío");
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


        public void MostrarProveedores(ComboBox cbProveedor)
        {
            List<Proveedores> datos = metodosProductos.ObtenerProveedores();
            cbProveedor.Items.Add("Selecciona una opción");
            foreach (Proveedores dato in datos)
            {
                cbProveedor.Items.Add(dato.Proveedor);
            };
        }

        public void MostrarCategorias(ComboBox cbCategoria)
        {

            List<Categorias> datos = metodosProductos.ObtenerCategorias();
            cbCategoria.Items.Add("Selecciona una opción");
            foreach (Categorias dato in datos)
            {
                cbCategoria.Items.Add(dato.Categoria);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                   
                    if (string.IsNullOrEmpty(txbIDProducto.Text.Trim()))
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
                       
                        // Crear un nuevo producto
                        CLS.Productos oProducto = new CLS.Productos();
                        oProducto.IDProducto = Convert.ToInt32(txbIDProducto.Text);
                        oProducto.Producto = txbProducto.Text;
                        oProducto.Stock = Convert.ToInt32(txbStock.Text);
                        oProducto.Precio = Convert.ToDouble(txbPrecio.Text);
                        oProducto.Descripcion = txbDescripcion.Text;
                        oProducto.IDProveedor = Convert.ToInt32(cbProveedor.SelectedIndex);
                        oProducto.FechaFabricacion = Convert.ToDateTime(txbFechaFabricacion.Text);
                        oProducto.FechaVencimiento = Convert.ToDateTime(txbFechaVencimiento.Text);
                        oProducto.IDCategoria = Convert.ToInt32(cbCategoria.SelectedIndex);
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

            if (string.IsNullOrEmpty(txbIDProducto.Text))
            {
                this.MostrarProveedores(cbProveedor);
                this.MostrarCategorias(cbCategoria);
                cbProveedor.SelectedIndex = 0;
                cbCategoria.SelectedIndex = 0;
            }    
        }
    }
}
