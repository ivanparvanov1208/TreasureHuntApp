using System;
using System.Windows.Forms;
using GoldenQuest;

namespace GoldenQuest
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
