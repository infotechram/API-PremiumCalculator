using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculatorAPI.ServiceLayer;
using PremiumCalculatorAPI.Model;

namespace PremiumCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumCalculatorController : ControllerBase
    {
        private readonly iService _iService;

        public PremiumCalculatorController(iService service)
        {
            _iService = service;
        }

        [HttpGet(Name = "GetOccupation")]
        public IActionResult GetOccupation()
        {
            return Ok(_iService.GetOccupation().ToList());
        }

        [HttpPost(Name = "CalculatePremium")]
        public IActionResult CalculatePremium(CustomerDetails CustomerDetails)
        {
            return Ok(_iService.CalculatePremium(CustomerDetails));
        }
    }
}
