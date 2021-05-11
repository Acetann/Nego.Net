using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GestionInventaireWinForms
{
    static class Program
    {
                    /// <summary>
            /// Point d'entrée principal de l'application.
            /// </summary>
            [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new negoges());
        }
    }
}
