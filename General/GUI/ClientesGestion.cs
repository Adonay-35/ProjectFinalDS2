﻿using System;
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
    public partial class ClientesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.CLIENTES();
                FiltrarLocalmente();
            }
            catch (Exception)
            {

            }
        }
        public ClientesGestion()
        {
            InitializeComponent();
        }

        private void ClientesGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            lblRegistros.Text = _DATOS.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Clientes oCliente = new CLS.Clientes();
                    oCliente.IDCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDCliente"].Value.ToString());
                    oCliente.Nombres = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                    oCliente.Apellidos = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                    oCliente.Correo = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();

                    if (oCliente.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("Lo siento, pero no puedes eliminar los clientes que tienen registros de ventas asociados");
                    }
                    Cargar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesEdicion f = new ClientesEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClientesEdicion oCliente = new ClientesEdicion();

                    oCliente.txbIDCliente.Text = dataGridView1.CurrentRow.Cells["IDCliente"].Value.ToString();
                    oCliente.txbNombres.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                    oCliente.txbApellidos.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                    oCliente.txbCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                    oCliente.ShowDialog();
                    Cargar();
                }
            }
            catch (Exception)
            {
                throw;

            }
        }


        private void FiltrarLocalmente()
        {
            try
            {
                if (txbFiltro.Text.Trim().Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    _DATOS.Filter = "Nombres like '%" + txbFiltro.Text + "%'";
                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}
