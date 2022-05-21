using PremiumCalculatorAPI.RepoLayer;
using PremiumCalculatorAPI.Model;
namespace PremiumCalculatorAPI.ServiceLayer
{
    public class APIServices : iService
    {
        private readonly iRepo _iRepo;
        public APIServices(iRepo Repo)
        {
            _iRepo = Repo;
        }
        public List<OccupationMaster> GetOccupation()
        {
            return _iRepo.GetOccupation();
        }
    }
}
