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
    public partial class VisorFacturas : Form
    {
        public VisorFacturas()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                REP.Facturas rFacturas = new REP.Facturas();
                rFacturas.SetDataSource(DataLayer.Consultas.FACTURAS(dtpInicio.Text, dtpFinal.Text));
                crvVisorFacturas.ReportSource = rFacturas;
            }
            catch (Exception)
            {

            }
        }
    }
}
