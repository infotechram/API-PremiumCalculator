using PremiumCalculatorAPI.Model;
namespace PremiumCalculatorAPI.RepoLayer
{
    public class APIRepository : iRepo
    {
        public APIRepository()
        {

        }

        public List<OccupationMaster> GetOccupation()
        {
            List<OccupationMaster> lstoccupation = new List<OccupationMaster>
            {
                new OccupationMaster{ occupationName = "Cleaner", occupationValue = "Light Manual" },
                new OccupationMaster{ occupationName = "Doctor", occupationValue = "Professional" },
                new OccupationMaster{ occupationName = "Author", occupationValue = "White Collar" },
                new OccupationMaster{ occupationName = "Author", occupationValue = "White Collar" },
                new OccupationMaster{ occupationName = "Farmer", occupationValue = "Heavy Manual" },
                new OccupationMaster{ occupationName = "Mechanic", occupationValue = "Heavy Manual" },
                new OccupationMaster{ occupationName = "Florist", occupationValue = "Light Manual" },
             };
            return lstoccupation;
        }
    }
}
