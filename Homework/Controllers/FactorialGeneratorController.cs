using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Services.Interfaces;

namespace Homework.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactorialGeneratorController : ControllerBase
    {
        private readonly IFactorialService _factorialService;

        public FactorialGeneratorController(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }

        [HttpGet]
        public int GenerateFactorialValue(int value)
        {
            return _factorialService.GenerateFactorial(value);
        }
    }
}
