using PremiumCalculatorAPI.Model;
namespace PremiumCalculatorAPI.ServiceLayer
{
    public interface iService
    {
        List<OccupationMaster> GetOccupation();
        string CalculatePremium(CustomerDetails customerDetails);
    }
}
