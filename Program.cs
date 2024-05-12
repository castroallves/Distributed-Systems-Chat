// Software By: Pedro Castro Alves
// GitHub: castroallves

//NON NOBIS DOMINE, NON NOBIS, SED NOMINI TUO DA GLORIAM ♰ IN HOC SIGNO VINCES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_SD
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new FormTelaPrincipal());
        }
    }
}
