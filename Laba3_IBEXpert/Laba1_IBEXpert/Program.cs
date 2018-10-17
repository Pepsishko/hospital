using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Laba1_IBEXpert
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            //FbConnection fbConn = new FbConnection();

            //cs.DataSource = "localhost"; // имя компьютера, на котором находится база данных
            //cs.UserID = "SYSDBA"; // имя пользователя, который может производить манипуляции с базой
            //cs.Password = "masterkey"; // паоль пользователя, который может производить манипуляции с базой
            //cs.Database = "C:\\Аркадий\\AppData\\Roaming\\HK-Software\\IBExpert\\BAZA"; // путь к файлу базы данных
            //                                   cs.Port = 3050; // порт подключения к базе
            //cs.Charset = "win1251"; // кодировка символов
            //string ConnString = cs.ToString();

            //fbConn.ConnectionString = ConnString;
            //fbConn.Open();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
