using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    /// <summary>
    /// The main interface definition. Here the user can change between sql and csv 
    /// </summary>
   public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }


        public static void InitializeConnections (DatabaseType db)
        {            
            if (db == DatabaseType.Sql)
            {
                //TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.Textfile)
            {
                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
