using System.Configuration;
using TrackerLib.DataAccess;

namespace TrackerLib
{
    public enum DataStorage
    {
        Sql,
        LocalFile
    }

    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DataStorage storage)
        {
            switch (storage)
            {
                case DataStorage.Sql: Connection = new SqlConnector();
                    break;
                case DataStorage.LocalFile: Connection = new TextConnector();
                    break;
            }
        }

        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
