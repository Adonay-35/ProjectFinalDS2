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
    public partial class VisorVentasSegunCategoria : Form
    {
        public VisorVentasSegunCategoria()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                REP.VentasSegunCategoria rVentasCategorias = new REP.VentasSegunCategoria();
                rVentasCategorias.SetDataSource(DataLayer.Consultas.VENTAS_CATEGORIAS(nudMinima.Text, nudMaxima.Text));
                crvVisorVentasCategorias.ReportSource = rVentasCategorias;
            }
            catch (Exception)
            {

            }
        }
    }
}
