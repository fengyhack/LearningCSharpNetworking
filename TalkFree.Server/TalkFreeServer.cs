using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SharpSocket.TalkFree.Server
{
    static class TalkFreeServer
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
