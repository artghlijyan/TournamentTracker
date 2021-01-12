using System.Configuration;
using TrackerLib.DataAccess;

namespace TrackerLib
{
    public enum AgentType
    {
        Sql = 1,
        File // not implemented
    }

    public class DataConfig
    {
        public IDbAgent Agent { get; private set; }

        public DataConfig(AgentType agent)
        {
            switch (agent)
            {
                case AgentType.Sql:
                    Agent = new SqlAgent();
                    break;
                //Not Implemented
                case AgentType.File:
                    break;
            }
        }

        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
