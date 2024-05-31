using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            //Application.Run(new CLS.AppManager());
           Application.Run(new GUI.FPrincipal());
=======
            Application.Run(new CLS.AppManager());
           //Application.Run(new GUI.FPrincipal());
>>>>>>> 2009d1e448be5357596773ea12ca16823d4aa77a
        }
    }
}
