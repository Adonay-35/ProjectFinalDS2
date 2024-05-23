using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.GUI
{
    public partial class EncriptarPass : Form
    {
        public EncriptarPass()
        {
            InitializeComponent();
        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Encriptar(txtCon.Text);
        }

        public string Encriptar(string _CadenaEncriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_CadenaEncriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        
    }
}
