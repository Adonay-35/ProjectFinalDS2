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
                    // Ajustar el índice porque el primer elemento es "Selecciona una opción"
                    int indice = cbProductos.SelectedIndex - 1;

                    if (indice >= 0 && indice < listaProductos.Count)
                    {
                        // Obtener el producto seleccionado
                        Productos productoSeleccionado = listaProductos[indice];

                        // Intentar obtener la cantidad entrante
                        if (int.TryParse(txbCantidadEntrante.Text, out int cantidadEntrante))
                        {
                            Compras oCompra = new Compras();

                            // Si es una nueva compra
                            if (string.IsNullOrEmpty(txbID_Compra.Text.Trim()))
                            {
                                oCompra.FechaCompra = Convert.ToDateTime(txbFechaCompra.Text);
                                oCompra.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                                oCompra.ID_Proveedor = Convert.ToInt32(cbProveedores.SelectedIndex);
                                oCompra.ID_Producto = productoSeleccionado.ID_Producto;
                                oCompra.CantidadEntrante = cantidadEntrante;
                                oCompra.TotalPagar = Convert.ToDecimal(txbTotalPagar.Text);

                                // Guardar nuevo registro
                                if (oCompra.Insertar())
                                {
                                    // Actualizar el stock en la base de datos
                                    ActualizarStock(productoSeleccionado.ID_Producto, cantidadEntrante);

                                    MessageBox.Show("Compra creada exitosamente");
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("La compra no pudo ser almacenada");
                                }
                            }
                            else // Si es una compra existente que se está actualizando
                            {
                                oCompra.ID_Compra = Convert.ToInt32(txbID_Compra.Text);
                                oCompra.FechaCompra = Convert.ToDateTime(txbFechaCompra.Text);
                                oCompra.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                                oCompra.ID_Proveedor = Convert.ToInt32(cbProveedores.SelectedIndex);
                                oCompra.ID_Producto = productoSeleccionado.ID_Producto;
                                oCompra.CantidadEntrante = cantidadEntrante;
                                oCompra.TotalPagar = Convert.ToDecimal(txbTotalPagar.Text);

                                // Actualizar registro
                                if (oCompra.Actualizar())
                                {
                                    // Actualizar el stock en la base de datos
                                    ActualizarStock(productoSeleccionado.ID_Producto, cantidadEntrante);

                                    MessageBox.Show("Registro actualizado exitosamente");
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("La compra no pudo ser actualizada");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantidad entrante no es válida");
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
                using (MySqlConnection sqlConexion = new MySqlConnection("Server=localhost;Port=3306;Database=sistemaventas;Uid=sistema-user;Pwd=root;SslMode=None;"))
                {
                    // Consulta para actualizar el stock en la tabla Productos
                    string query = @"UPDATE Productos SET Stock = Stock + @CantidadEntrante WHERE ID_Producto = @ID_Producto";

                    // Configuración del comando
                    MySqlCommand comando = new MySqlCommand(query, sqlConexion);
                    comando.Parameters.AddWithValue("@CantidadEntrante", cantidadEntrante);
                    comando.Parameters.AddWithValue("@ID_Producto", idProducto);

                    // Abrir la conexión y ejecutar la consulta
                    sqlConexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
