using System;
using System.Windows.Forms;
using TreasureHuntApp;

namespace TreasureHuntApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainGameForm());
        }
    }
}
