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
    public partial class dataGridView1 : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = DataLayer.Consultas.DIRECCIONES();
            }
            catch (Exception)
            {

            }
        }

        public dataGridView1()
        {
            InitializeComponent();
        }




        private void GestionarDirecciones_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
