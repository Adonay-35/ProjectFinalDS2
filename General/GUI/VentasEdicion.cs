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

                        //oVenta.ID_Venta = Convert.ToInt32(txbID_Venta.Text);
                        oVenta.FechaVenta = Convert.ToDateTime(txbFechaVenta.Text);
                        oVenta.ID_Usuario = Convert.ToInt32(cbUsuarios.SelectedIndex);
                        oVenta.ID_Cliente = Convert.ToInt32(cbClientes.SelectedIndex);
                        oVenta.ID_Producto = Convert.ToInt32(cbProductos.SelectedIndex);
                        oVenta.PrecioVenta = Convert.ToDecimal(txbPrecioVenta.Text);
                        oVenta.CantidadSaliente = Convert.ToInt32(txbPrecioVenta.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            List<Productos> datos = metodosventas.ObtenerProductos();
            cbProductos.Items.Add("Selecciona una opción");
            foreach (Productos dato in datos)
            {
                cbProductos.Items.Add(dato.Producto);
            }
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
