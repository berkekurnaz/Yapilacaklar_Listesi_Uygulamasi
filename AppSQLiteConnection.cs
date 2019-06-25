using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp
{
    public class AppSQLiteConnection
    {
        public SQLiteConnection Connection()
        {
            SQLiteConnection connect = new SQLiteConnection(@"Data Source = DbToDoApp.db;Version=3;");
            connect.Open();
            return connect;
        }
    }
}
