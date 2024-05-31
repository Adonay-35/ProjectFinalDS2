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
                if (txbCantidad.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbCantidad, "Este campo no puede quedar vacío");
                    Valido = false;
                }
                if (txbPrecio.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbPrecio, "Este campo no puede quedar vacío");
                    Valido = false;
                }

                if (txbTotal.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txbTotal, "Este campo no puede quedar vacío");
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
            List<Productos> datos = metodosventas.ObtenerProductos();
            cbProductos.Items.Add("Selecciona una opción");
            foreach (Productos dato in datos)
            {
                cbProductos.Items.Add(dato.Producto);
            }
        }

        public VentasEdicion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (string.IsNullOrEmpty(txbIDVenta.Text.Trim()))
                    {

                        Ventas oVenta = new Ventas();

                        //oVenta.FechaVenta = Convert.ToDateTime(txbFechaVenta.Text);
                        oVenta.IDUsuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                        oVenta.IDCliente = Convert.ToInt32(cbClientes.SelectedIndex);
                        oVenta.IDProducto = Convert.ToInt32(cbProductos.SelectedIndex);
                        oVenta.Precio = Convert.ToDouble(txbPrecio.Text);
                        oVenta.Cantidad = Convert.ToInt32(txbPrecio.Text);
                        oVenta.Total = Convert.ToDouble(txbTotal.Text);

                        // GUARDAR NUEVO REGISTRO
                        if (oVenta.Insertar())
                        {
                            MessageBox.Show("Registro Guardado");
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser almacenado");
                        }
                    }
                    else
                    {
                        Ventas oVenta = new Ventas();

                        //oVenta.FechaVenta = Convert.ToDateTime(txbFechaVenta.Text);
                        oVenta.IDUsuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                        oVenta.IDCliente = Convert.ToInt32(cbClientes.SelectedIndex);
                        oVenta.IDProducto = Convert.ToInt32(cbProductos.SelectedIndex);
                        oVenta.Precio = Convert.ToDouble(txbPrecio.Text);
                        oVenta.Cantidad = Convert.ToInt32(txbCantidad.Text);
                        oVenta.Total = Convert.ToDouble(txbTotal.Text);
                        oVenta.IDVenta = Convert.ToInt32(txbIDVenta.Text);

                        // ACTUALIZAR REGISTRO
                        if (oVenta.Actualizar())
                        {
                            MessageBox.Show("Registro Actualizado");
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser actualizado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VentasEdicion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbIDVenta.Text))
            {
                this.MostrarUsuarios(cbUsuarios);
                this.MostrarClientes(cbClientes);
                this.MostrarProductos(cbProductos);
                cbUsuarios.SelectedIndex = 0;
                cbClientes.SelectedIndex = 0;
                cbProductos.SelectedIndex = 0;
            }
 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }   
}
