using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopLibrary.Models;
using System.Configuration;
using ShopLibrary.DataAccess;

namespace ShopLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static IFileConnection FileConnection { get; private set; }

        public static void InitializeConnection(DatabaseType db, DatabaseType f)
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;

            FileConnector file = new FileConnector();
            FileConnection = file;
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
