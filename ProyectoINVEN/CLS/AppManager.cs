using ProyectoCRUD.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.CLS
{
    internal class AppManager : ApplicationContext
    {
        private void SplashScreen()
        {
            try
            {
                Splash f = new Splash();
                f.ShowDialog();
            }
            catch (Exception)
            {

            }

        }

        private Boolean LoginScreen()
        {
            Boolean Resultado = false;
            try
            {
                GUI.Login f = new GUI.Login();
                f.ShowDialog();
                Resultado = f.Autorizado;
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public AppManager()
        {
            SplashScreen();
            if (LoginScreen())
            {
                FPrincipal f = new FPrincipal();
                f.ShowDialog();
            }
        }
    }
}
