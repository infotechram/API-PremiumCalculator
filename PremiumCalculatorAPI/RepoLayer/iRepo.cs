using PremiumCalculatorAPI.Model;
namespace PremiumCalculatorAPI.RepoLayer
{
    public interface iRepo
    {
        List<OccupationMaster> GetOccupation();
        List<OccupationRating> GetOccupationRatings();
    }
}
