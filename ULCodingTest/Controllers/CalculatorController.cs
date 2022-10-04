using Microsoft.AspNetCore.Mvc;
using ULCodingTest.ExtensionMethods;
using ULCodingTest.Objects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ULCodingTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {


        // GET api/<CalculatorController>/5
        [HttpGet("{expression}")]
        public string Calculate(string expression)
        {
            var val = expression.Parse();
            if(val.Count  == 0)
            {
                return "invalid format";
            }
            var sum = Calculator.Calculate(val);
            return sum.ToString();
        }
    }
}
