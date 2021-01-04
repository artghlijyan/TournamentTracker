using Dapper;
using System.Data;
using System.Data.SqlClient;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {
            using (IDbConnection con = new SqlConnection(GlobalConfig.ConString("TournamentTracker")))
            {
                var p = new DynamicParameters();

                p.Add("@PlaceNumber", prizeModel.PlaceNumber);
                p.Add("@PlaceName", prizeModel.PlaceName);
                p.Add("@PrizeAmount", prizeModel.PrizeAmount);
                p.Add("@PrizePercentage", prizeModel.PrizePercentage);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                con.Execute("sp_InsertIntoPrizes", param: p, commandType: CommandType.StoredProcedure);

                prizeModel.Id = p.Get<int>("@Id");

                return prizeModel;
            }
        }
    }
}
