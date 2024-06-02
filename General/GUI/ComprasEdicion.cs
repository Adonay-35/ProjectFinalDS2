using General.CLS;
using MySql.Data.MySqlClient;
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
    public partial class ComprasEdicion : Form
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();


        Compras metodosCompras = new Compras();

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
                if (cbProveedores.SelectedIndex == -1)
                {
                    Notificador.SetError(cbProveedores, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (cbProductos.SelectedIndex == -1)
                {
                    Notificador.SetError(cbProductos, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (txbCantidadEntrante.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCantidadEntrante, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (txbTotalPagar.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbTotalPagar, "Este campo no puede quedar vacío");
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


        public ComprasEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (string.IsNullOrEmpty(txbID_Compra.Text.Trim()))
                    {
                        Compras oCompra = new Compras();

                        oCompra.FechaCompra = Convert.ToDateTime(txbFechaCompra.Text);
                        oCompra.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                        oCompra.ID_Proveedor = Convert.ToInt32(cbProveedores.SelectedIndex);
                        oCompra.ID_Producto = Convert.ToInt32(cbProductos.SelectedIndex);
                        oCompra.CantidadEntrante = Convert.ToInt32(txbCantidadEntrante.Text);
                        oCompra.TotalPagar = Convert.ToDecimal(txbTotalPagar.Text);

                        // GUARDAR NUEVO REGISTRO
                        if (oCompra.Insertar())
                        {
                            MessageBox.Show("Compra creada exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("La compra no pudo ser almacenada");
                        }
                    }
                    else
                    {
                        Compras oCompra = new Compras();

                        oCompra.ID_Compra = Convert.ToInt32(txbID_Compra.Text);
                        oCompra.FechaCompra = Convert.ToDateTime(txbFechaCompra.Text);
                        oCompra.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                        oCompra.ID_Proveedor = Convert.ToInt32(cbProveedores.SelectedIndex);
                        oCompra.ID_Producto = Convert.ToInt32(cbProductos.SelectedIndex);
                        oCompra.CantidadEntrante = Convert.ToInt32(txbCantidadEntrante.Text);
                        oCompra.TotalPagar = Convert.ToDecimal(txbTotalPagar.Text);

                        // ACTUALIZAR REGISTRO
                        if (oCompra.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado exitosamente");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("La compra no pudo ser actualizada");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarUsuarios(ComboBox cbUsarios)
        {
            List<Usuarios> datos = metodosCompras.ObtenerUsuarios();
            cbUsuarios.Items.Add("Selecciona una opción");
            foreach (Usuarios dato in datos)
            {
                cbUsarios.Items.Add(dato.Usuario);
            }
        }

        public void MostrarProveedores(ComboBox cbProveedores)
        {
            List<Proveedores> datos = metodosCompras.ObtenerProveedores();
            cbProveedores.Items.Add("Selecciona una opción");
            foreach (Proveedores dato in datos)
            {
                cbProveedores.Items.Add(dato.Proveedor);
            }
        }

        private List<Productos> listaProductos; // Declarar la variable de clase

        public void MostrarProductos(ComboBox cbProductos)
        {
            // Obtener la lista de productos y almacenarla en la variable de clase
            listaProductos = metodosCompras.ObtenerProductos();

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
            int indice = cbProductos.SelectedIndex - 1;

            if (indice >= 0 && indice < listaProductos.Count)
            {
                // Obtener el producto seleccionado
                Productos productoSeleccionado = listaProductos[indice];

                // Intentar obtener la cantidad entrante
                if (int.TryParse(txbCantidadEntrante.Text, out int cantidadEntrante))
                {
                    // Calcular el total a pagar
                    decimal totalPagar = (decimal)(productoSeleccionado.PrecioCompra * cantidadEntrante);
                    txbTotalPagar.Text = totalPagar.ToString();
                }
                else
                {
                    txbTotalPagar.Text = "0"; // Reiniciar si la cantidad no es válida
                }
            }
        }

        public void ActualizarStock(int idProducto, int cantidadEntrante)
        {
            try
            {
                // Configuración de la conexión
                sqlConexion.ConnectionString = "Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;";

                    // Consulta para actualizar el stock en la tabla Kardex
                    string query = @"UPDATE Kardex SET Stock = Stock + @CantidadEntrante WHERE ID_Kardex = (SELECT ID_Kardex
                                     FROM Compras WHERE ID_Producto = @ID_Producto LIMIT 1)";

                // Configuración del comando
                MySqlCommand comando = new MySqlCommand(query, sqlConexion);
                comando.Parameters.AddWithValue("@CantidadEntrante", cantidadEntrante);
                comando.Parameters.AddWithValue("@ID_Producto", idProducto);

                // Abrir la conexión y ejecutar la consulta
                sqlConexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Asegurarse de que la conexión se cierre
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        private void txbCantidadEntrante_TextChanged(object sender, EventArgs e)
        {

            int indice = cbProductos.SelectedIndex - 1;

            if (indice >= 0 && indice < listaProductos.Count)
            {
                // Obtener el producto seleccionado
                Productos productoSeleccionado = listaProductos[indice];

                // Intentar obtener la cantidad entrante
                if (int.TryParse(txbCantidadEntrante.Text, out int cantidadEntrante))
                {
                    // Calcular el total a pagar
                    decimal totalPagar = (decimal)(productoSeleccionado.PrecioCompra * cantidadEntrante);
                    txbTotalPagar.Text = totalPagar.ToString();

                    // Actualizar el stock en la base de datos
                    ActualizarStock(productoSeleccionado.ID_Producto, cantidadEntrante);
                }
                else
                {
                    txbTotalPagar.Text = "0"; // Reiniciar si la cantidad no es válida
                }
            }
        }

        private void ComprasEdicion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbID_Compra.Text))
            {
                this.MostrarUsuarios(cbUsuarios);
                this.MostrarProveedores(cbProveedores);
                this.MostrarProductos(cbProductos);
                cbUsuarios.SelectedIndex = 0;
                cbProveedores.SelectedIndex = 0;
                cbProductos.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
