using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DailyLogAndTracker.Helper
{
    public static class DBHelper
    {
        private static readonly string dbPath = $"{Application.StartupPath}\\App_Data\\dldt.db";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }

    }
}
