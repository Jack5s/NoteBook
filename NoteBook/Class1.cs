using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace NoteBook
{
    static class Class1
    {      
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Args.Length > 0)
            {
                Application.Run(new txt(Args[0].ToString()));
            }
            else
            {
                txt t = new txt();
                Application.Run(t);
            }
        }
    }
}
