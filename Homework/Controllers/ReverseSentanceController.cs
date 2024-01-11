using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Homework.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReverseSentanceController : ControllerBase
    {
        private readonly IReverseSentanceService _ReverseSentanceService;

        public ReverseSentanceController(IReverseSentanceService ReverseSentanceService)
        {
            _ReverseSentanceService = ReverseSentanceService;
        }

        [HttpGet]
        public string GenerateReverseString(string sentance)
        {
            return _ReverseSentanceService.GenerateReverseString(sentance);
        }
    }
}
