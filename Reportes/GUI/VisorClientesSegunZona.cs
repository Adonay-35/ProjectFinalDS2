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
    public partial class VisorClientesSegunZona : Form
    {
        public VisorClientesSegunZona()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                REP.ClientesSegunZona rClientesZonas = new REP.ClientesSegunZona();
                rClientesZonas.SetDataSource(DataLayer.Consultas.CLIENTES_ZONAS(nudMinima.Text, nudMaxima.Text));
                crvVisorClientesZ.ReportSource = rClientesZonas;
            }
            catch (Exception)
            {

            }
        }
    }
}
