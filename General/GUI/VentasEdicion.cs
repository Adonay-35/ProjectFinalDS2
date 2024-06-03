using General.CLS;
using MySql.Data.MySqlClient;
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
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

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
                    // Ajustar el índice porque el primer elemento es "Selecciona una opción"
                    int indice = cbProductos.SelectedIndex - 1;

                    if (indice >= 0 && indice < listaProductos.Count)
                    {
                        // Obtener el producto seleccionado
                        Productos productoSeleccionado = listaProductos[indice];

                        // Intentar obtener la cantidad saliente
                        if (int.TryParse(txbCantidadSaliente.Text, out int cantidadSaliente))
                        {
                            // Verificar el stock actual
                            int stockActual = ObtenerStockActual(productoSeleccionado.ID_Producto);

                            if (stockActual == 0)
                            {
                                MessageBox.Show("Ya no hay stock disponible.",
                                "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (stockActual < cantidadSaliente)
                            {
                                MessageBox.Show($"No hay suficiente stock disponible. Stock actual: {stockActual}",
                                "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                Ventas oVenta = new Ventas();

                                oVenta.FechaVenta = Convert.ToDateTime(txbFechaVenta.Text);
                                oVenta.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                                oVenta.ID_Cliente = Convert.ToInt32(cbClientes.SelectedIndex);
                                oVenta.ID_Producto = productoSeleccionado.ID_Producto;  // Usar el ID_Producto del producto seleccionado
                                oVenta.PrecioVenta = Convert.ToDecimal(txbPrecioVenta.Text);
                                oVenta.CantidadSaliente = cantidadSaliente;
                                oVenta.TotalCobrar = Convert.ToDecimal(txbTotalCobrar.Text);

                                // Guardar nuevo registro
                                if (string.IsNullOrEmpty(txbID_Venta.Text.Trim()))
                                {
                                    if (oVenta.Insertar())
                                    {
                                        // Actualizar el stock en la base de datos
                                        ActualizarStockSaliente(productoSeleccionado.ID_Producto, cantidadSaliente);
                                        MessageBox.Show("Venta creada exitosamente",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La venta no pudo ser almacenada",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    oVenta.ID_Venta = Convert.ToInt32(txbID_Venta.Text);

                                    if (oVenta.Actualizar())
                                    {
                                        // Actualizar el stock en la base de datos
                                        ActualizarStockSaliente(productoSeleccionado.ID_Producto, cantidadSaliente);
                                        MessageBox.Show("Registro actualizado exitosamente",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La venta no pudo ser actualizada",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private List<Productos> listaProductos; // Declarar la variable de clase

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

        public void ActualizarStockSaliente(int idProducto, int cantidadSaliente)
        {
            try
            {
                // Configuración de la conexión
                using (MySqlConnection sqlConexion = new MySqlConnection("Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;"))
                {
                    // Consulta para actualizar el stock en la tabla Productos
                    string query = @"UPDATE Productos 
                             SET Stock = Stock - @CantidadSaliente 
                             WHERE ID_Producto = @ID_Producto";

                    // Configuración del comando
                    MySqlCommand comando = new MySqlCommand(query, sqlConexion);
                    comando.Parameters.AddWithValue("@CantidadSaliente", cantidadSaliente);
                    comando.Parameters.AddWithValue("@ID_Producto", idProducto);

                    // Abrir la conexión y ejecutar la consulta
                    sqlConexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verificar si se actualizó alguna fila
                    if (filasAfectadas == 0)
                    {
                        MessageBox.Show("No se encontró ningún registro para actualizar.",
                                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el stock: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // Verificar el stock actual
                    int stockActual = ObtenerStockActual(productoSeleccionado.ID_Producto);

                    if (stockActual == 0)
                    {
                        MessageBox.Show("Producto agotado actualmente.",
                        "Sin existencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbTotalCobrar.Text = "0";
                    }
                    else if (stockActual < cantidadSaliente)
                    {
                        MessageBox.Show($"No hay suficiente stock disponible. Stock actual: {stockActual}",
                        "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbTotalCobrar.Text = "0";
                    }
                    else
                    {
                        // Calcular el total a cobrar
                        decimal totalCobrar = (decimal)productoSeleccionado.PrecioCompra * cantidadSaliente;
                        txbTotalCobrar.Text = totalCobrar.ToString();
                    }
                }
                else
                {
                    txbTotalCobrar.Text = "0"; // Reiniciar si la cantidad no es válida
                }
            }
        }

        private int ObtenerStockActual(int idProducto)
        {
            int stockActual = 0;

            try
            {
                // Configuración de la conexión
                using (MySqlConnection sqlConexion = new MySqlConnection("Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;"))
                {
                    // Consulta para obtener el stock actual de la tabla Productos
                    string checkStockQuery = @"SELECT Stock FROM Productos WHERE ID_Producto = @ID_Producto";

                    // Configuración del comando para verificar el stock
                    MySqlCommand checkStockCommand = new MySqlCommand(checkStockQuery, sqlConexion);
                    checkStockCommand.Parameters.AddWithValue("@ID_Producto", idProducto);

                    // Abrir la conexión
                    sqlConexion.Open();

                    // Ejecutar la consulta de verificación del stock
                    object result = checkStockCommand.ExecuteScalar();

                    // Verificar si el resultado es nulo o DBNull
                    if (result != null && result != DBNull.Value)
                    {
                        stockActual = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al verificar el stock: " + ex.Message);
            }

            return stockActual;
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

    }
}
