using TrackerLib.Models;

namespace TrackerLib.DataAccess
{
    public interface IDbAgent
    {
        PrizeModel CreatePrize(PrizeModel prize);
        PersonModel CreatePerson(PersonModel personModel);
    }
}
