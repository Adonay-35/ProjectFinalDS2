using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class VisorClientesFrecuentes : Form
    {
        public VisorClientesFrecuentes()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                REP.ClientesFrecuentes rClientesFrecuentes = new REP.ClientesFrecuentes();
                rClientesFrecuentes.SetDataSource(DataLayer.Consultas.CLIENTES_FRECUENTES(nudMinima.Text, nudMaxima.Text));
                crvVisorClientesF.ReportSource = rClientesFrecuentes;
            }
            catch (Exception)
            {

            }
        }
    }
}
