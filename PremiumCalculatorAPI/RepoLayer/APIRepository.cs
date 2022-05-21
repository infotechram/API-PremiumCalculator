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
            List<OccupationMaster> lstOccupation = new List<OccupationMaster>
            {
                new OccupationMaster{ occupationName = "Cleaner", occupationValue = "Light Manual" },
                new OccupationMaster{ occupationName = "Doctor", occupationValue = "Professional" },
                new OccupationMaster{ occupationName = "Author", occupationValue = "White Collar" },
                new OccupationMaster{ occupationName = "Author", occupationValue = "White Collar" },
                new OccupationMaster{ occupationName = "Farmer", occupationValue = "Heavy Manual" },
                new OccupationMaster{ occupationName = "Mechanic", occupationValue = "Heavy Manual" },
                new OccupationMaster{ occupationName = "Florist", occupationValue = "Light Manual" },
             };
            return lstOccupation;
        }
        public List<OccupationRating> GetOccupationRatings()
        {
            List<OccupationRating> lstOccupationRating = new List<OccupationRating>
            {
                new OccupationRating{ occupationRating = "Professional", occupationFactor = "1.0" },
                new OccupationRating{ occupationRating = "White Collar", occupationFactor = "1.25" },
                new OccupationRating{ occupationRating = "Light Manual", occupationFactor = "1.50" },
                new OccupationRating{ occupationRating = "Heavy Manual", occupationFactor = "1.75" },
             };
            return lstOccupationRating;

        }
    }

}
