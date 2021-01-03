using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLib
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnection(bool dataBase, bool textFile)
        {
            if (dataBase)
            {

            }

            if (textFile)
            {

            }
        }
    }
}
