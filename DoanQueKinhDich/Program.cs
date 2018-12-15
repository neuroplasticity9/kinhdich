using System;
using System.Windows.Forms;
using KinhDichCommon;

namespace DoanQueKinhDich
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Sqlite.LoadQueInfoFromDb();
            //Sqlite.UpdateAllQueToDb(Que.All);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormQueThoiGian());
        }
    }
}
