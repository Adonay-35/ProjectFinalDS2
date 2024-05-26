﻿using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace General.GUI
{
    public partial class UsuariosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.USUARIOS();
                FiltrarLocalmente();
            }
            catch (Exception)
            {

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
                    _DATOS.Filter = "Usuario like '%" + txbFiltro.Text + "%'";
                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }

        public UsuariosGestion()
        {
            InitializeComponent();
        }

        private void UsuariosGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            lblRegistros.Text = _DATOS.Count.ToString();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea ELIMINAR el registro seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Usuarios oUsuario = new CLS.Usuarios((Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDUsuario"].Value.ToString())), "dummyUser");
                    oUsuario.IDUsuario = (Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDUsuario"].Value.ToString()));
                    if (oUsuario.Elminar())
                    {
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("El Registro no ha sido eliminado");
                    }
                    Cargar();
                    lblRegistros.Text = _DATOS.Count.ToString();

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuariosEdicion oUsuarioEdicion = new UsuariosEdicion();
                    oUsuarioEdicion.MostrarRoles(oUsuarioEdicion.cbRoles);
                    oUsuarioEdicion.MostrarEmpleados(oUsuarioEdicion.cbEmpleados);
                    oUsuarioEdicion.MostrarEstados(oUsuarioEdicion.cbEstados);
                    oUsuarioEdicion.txbIDUsuario.Text = dataGridView1.CurrentRow.Cells["IDUsuario"].Value.ToString();
                    oUsuarioEdicion.txbUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();

                    //oUsuarioEdicion.txbClave.Text = dataGridView1.CurrentRow.Cells.["Clave"].Value.ToString();
                    oUsuarioEdicion.cbRoles.SelectedItem = dataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
                    oUsuarioEdicion.cbEmpleados.SelectedItem = dataGridView1.CurrentRow.Cells["Empleado"].Value.ToString();
                    oUsuarioEdicion.cbEstados.SelectedItem = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                    oUsuarioEdicion.ShowDialog();
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
                UsuariosEdicion f = new UsuariosEdicion();
                f.ShowDialog();
                Cargar();
                lblRegistros.Text = _DATOS.Count.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
