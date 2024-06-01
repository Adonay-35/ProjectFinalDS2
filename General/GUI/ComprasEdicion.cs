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
    public partial class ComprasEdicion : Form
    {
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

        public void MostrarProductos(ComboBox cbProductos)
        {
            List<Productos> datos = metodosCompras.ObtenerProductos();
            cbProductos.Items.Add("Selecciona una opción");
            foreach (Productos dato in datos)
            {
                cbProductos.Items.Add(dato.Producto);
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
