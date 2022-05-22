﻿using PremiumCalculatorAPI.RepoLayer;
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
        public string CalculatePremium(CustomerDetails customerDetails)
        {
            string result = "0";
            List<OccupationRating> lstoccRating = _iRepo.GetOccupationRatings();
            lstoccRating = lstoccRating.Where(x => x.occupationRating == customerDetails.occupationValue).Select(y => new OccupationRating { 
                occupationFactor = y.occupationFactor, 
                occupationRating = y.occupationRating }).ToList();
            if(lstoccRating.Count > 0  && )
            {
                 result =  ( (Convert.ToDecimal(customerDetails.insuredAmount) * Convert.ToDecimal(lstoccRating[0].occupationFactor) * customerDetails.age) / 1000 * 12).ToString();
          
            }
            return result;
        }
    }
}
