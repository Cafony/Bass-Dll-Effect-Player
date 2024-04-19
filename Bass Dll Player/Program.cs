using Bass_Dll_Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bass_Dll_PitchShift
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new pitchshift());
            Application.Run(new Main());
            //Application.Run(new monoStereo());
            //Application.Run(new equalizer());
            //Application.Run(new speed());
            //Application.Run(new notepad());
            //Application.Run(new PlayPauseStop());
            //Application.Run(new filtros_eq());

        }
    }
}
