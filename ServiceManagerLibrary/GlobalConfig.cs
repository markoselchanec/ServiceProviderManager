using ServiceManagerLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// SQL Connection.
        /// </summary>
        public static IDataConnection Connection { get; private set; }
        /// <summary>
        /// Initializes SQL database connection.
        /// </summary>
        public static void InitializeConnection()
        {
            SqlConnector sql = new();
            Connection = sql;
        }
        /// <summary>
        /// Extracts connectionString value from app.config
        /// Uses System.Configuration NUGET package
        /// </summary>
        /// <param name="name">Name attribute value in connectionStrings</param>
        /// <returns>connectionString value</returns>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
