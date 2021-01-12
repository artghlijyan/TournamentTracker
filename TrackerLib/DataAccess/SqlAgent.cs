using Dapper;
using System.Data;
using System.Data.SqlClient;
using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public class SqlAgent : IDbAgent
    {

        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {
            using (IDbConnection con = new SqlConnection(DataConfig.ConString("TournamentTracker")))
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
        public PersonModel CreatePerson(PersonModel personModel)
        {
            using (IDbConnection con = new SqlConnection(DataConfig.ConString("TournamentTracker")))
            {
                var p = new DynamicParameters();

                p.Add("@FirstName", personModel.FirstName);
                p.Add("@LastName", personModel.LastName);
                p.Add("@EmailAddress", personModel.EmailAddress);
                p.Add("@Mobile", personModel.Mobile);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                con.Execute("sp_InsertIntoPeople", param: p, commandType: CommandType.StoredProcedure);

                personModel.Id = p.Get<int>("@Id");

                return personModel;
            }
        }
    }
}
