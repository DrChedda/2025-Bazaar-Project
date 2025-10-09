using System;
using System.Windows.Forms;

namespace GCHS_2025_Bazaar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameMenu());
        }
    }
}
