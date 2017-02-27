using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 根据数据库生成实体
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form fm = new frmMain();
            fm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(fm);
        }
    }
}
