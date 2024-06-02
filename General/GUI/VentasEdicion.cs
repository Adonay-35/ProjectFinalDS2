using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class VentasEdicion : Form
    {
        Ventas metodosventas = new Ventas();

        private bool Validar()
        {
            bool Valido = true;
            try
            {
                if (cbUsuarios.SelectedIndex == -1)
                {
                    Notificador.SetError(cbUsuarios, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (cbClientes.SelectedIndex == -1)
                {
                    Notificador.SetError(cbClientes, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (cbProductos.SelectedIndex == -1)
                {
                    Notificador.SetError(cbProductos, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (txbCantidadSaliente.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCantidadSaliente, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (txbPrecioVenta.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbPrecioVenta, "Este campo no puede quedar vacío");
                    Valido = false;
                }

                if (txbTotalCobrar.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbTotalCobrar, "Este campo no puede quedar vacío");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación: " + ex.Message);
                Valido = false;
            }
            return Valido;
        }

        public VentasEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (string.IsNullOrEmpty(txbID_Venta.Text.Trim()))
                    {

                        Ventas oVenta = new Ventas();


                        oVenta.FechaVenta = Convert.ToDateTime(txbFechaVenta.Text);
                        oVenta.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                        oVenta.ID_Cliente = Convert.ToInt32(cbClientes.SelectedIndex);
                        oVenta.ID_Producto = Convert.ToInt32(cbProductos.SelectedIndex);
                        oVenta.PrecioVenta = Convert.ToDecimal(txbPrecioVenta.Text);
                        oVenta.CantidadSaliente = Convert.ToInt32(txbCantidadSaliente.Text);
                        oVenta.TotalCobrar = Convert.ToDecimal(txbTotalCobrar.Text);

                        // GUARDAR NUEVO REGISTRO
                        if (oVenta.Insertar())
                        {
                            MessageBox.Show("Venta creada exitosamnete");
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("La venta no pudo ser almacenado");
                        }
                    }
                    else
                    {
                        Ventas oVenta = new Ventas();

                        oVenta.ID_Venta = Convert.ToInt32(txbID_Venta.Text);
                        oVenta.FechaVenta = Convert.ToDateTime(txbFechaVenta.Text);
                        oVenta.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                        oVenta.ID_Cliente = Convert.ToInt32(cbClientes.SelectedIndex);
                        oVenta.ID_Producto = Convert.ToInt32(cbProductos.SelectedIndex);
                        oVenta.PrecioVenta = Convert.ToDecimal(txbPrecioVenta.Text);
                        oVenta.CantidadSaliente = Convert.ToInt32(txbCantidadSaliente.Text);
                        oVenta.TotalCobrar = Convert.ToDecimal(txbTotalCobrar.Text);

                        // ACTUALIZAR REGISTRO
                        if (oVenta.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado exitosamente");
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("La venta no pudo ser actualizado");
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public void MostrarUsuarios(ComboBox cbUsarios)
        {
            List<Usuarios> datos = metodosventas.ObtenerUsuarios();
            cbUsuarios.Items.Add("Selecciona una opción");
            foreach (Usuarios dato in datos)
            {
                cbUsarios.Items.Add(dato.Usuario);
            }
        }

        public void MostrarClientes(ComboBox cbClientes)
        {

            List<Clientes> datos = metodosventas.ObtenerClientes();
            cbClientes.Items.Add("Selecciona una opción");
            foreach (Clientes dato in datos)
            {
                cbClientes.Items.Add(dato.Nombres + " " + dato.Apellidos);
            }
        }

        public void MostrarProductos(ComboBox cbProductos)
        {
            // Obtener la lista de productos y almacenarla en la variable de clase
            listaProductos = metodosventas.ObtenerProductos();

            // Limpiar el ComboBox antes de llenarlo
            cbProductos.Items.Clear();
            cbProductos.Items.Add("Selecciona una opción");

            // Agregar los nombres de los productos al ComboBox
            foreach (Productos producto in listaProductos)
            {
                cbProductos.Items.Add(producto.Producto);
            }

           cbProductos.SelectedIndex = 0; 
        }

        private void VentasEdicion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbID_Venta.Text))
            {
                this.MostrarUsuarios(cbUsuarios);
                this.MostrarClientes(cbClientes);
                this.MostrarProductos(cbProductos);
                cbUsuarios.SelectedIndex = 0;
                cbClientes.SelectedIndex = 0;
                cbProductos.SelectedIndex = 0;
            }
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    
        private List<Productos> listaProductos; // Declarar la variable de clase

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ajustar el índice porque el primer elemento es "Selecciona una opción"
            int indice = cbProductos.SelectedIndex - 1;

            if (indice >= 0 && indice < listaProductos.Count)
            {
                // Obtener el producto seleccionado
                Productos productoSeleccionado = listaProductos[indice];

                // Actualizar el precio de venta en el TextBox
                txbPrecioVenta.Text = productoSeleccionado.PrecioCompra.ToString();

                // Intentar obtener la cantidad saliente
                if (int.TryParse(txbCantidadSaliente.Text, out int cantidadSaliente))
                {
                    // Calcular el total a cobrar
                    decimal totalCobrar = (decimal)(productoSeleccionado.PrecioCompra * cantidadSaliente);
                    txbTotalCobrar.Text = totalCobrar.ToString();
                }
                else
                {
                    txbTotalCobrar.Text = "0"; // Reiniciar si la cantidad no es válida
                }
            }
        }

        private void txbCantidadSaliente_TextChanged(object sender, EventArgs e)
        {
            // Ajustar el índice porque el primer elemento es "Selecciona una opción"
            int indice = cbProductos.SelectedIndex - 1;

            if (indice >= 0 && indice < listaProductos.Count)
            {
                // Obtener el producto seleccionado
                Productos productoSeleccionado = listaProductos[indice];

                // Intentar obtener la cantidad saliente
                if (int.TryParse(txbCantidadSaliente.Text, out int cantidadSaliente))
                {
                    // Calcular el total a cobrar
                    decimal totalCobrar = (decimal)(productoSeleccionado.PrecioCompra * cantidadSaliente);
                    txbTotalCobrar.Text = totalCobrar.ToString();
                }
                else
                {
                    txbTotalCobrar.Text = "0"; // Reiniciar si la cantidad no es válida
                }
            }
        }
    }   
}
