using System.Configuration;
using TrackerLib.DataAccess;

namespace TrackerLib
{
    public static class DataConfig
    {
        public static IDbAgent Agent { get; private set; }

        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
