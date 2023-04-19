using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using workshop;

namespace BSBD
{
    internal static class main
    {
        public static DataBase dataBase;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dataBase = new DataBase("84.201.188.60", "HRdbuser", "Da7awe7EPAna", 3306, "workshop");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindowForm());
        }
    }
}
