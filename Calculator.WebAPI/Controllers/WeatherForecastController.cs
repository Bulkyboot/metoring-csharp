using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Calculator.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculertorController : ControllerBase
    {

        private readonly ILogger<CalculertorController> _logger;

        public CalculertorController(ILogger<CalculertorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult Sum( string fistNumber, string secondNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber)) 
            {
                decimal fist = ConvertToDouble(fistNumber);
                decimal second = ConvertToDouble(secondNumber);
                var sum = fist + second;
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }
        public ActionResult subtraction(string fistNumber, string secondNumber) {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(fistNumber);
                decimal second = ConvertToDouble(secondNumber);
                var subtraction = fist - second;
                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid input");
        }
        public ActionResult Mutiplication(string fistNumber, string secondNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(fistNumber);
                decimal second = ConvertToDouble(secondNumber);
                var mutiplication = fist * second;
                return Ok(mutiplication.ToString());
            }
            return BadRequest("Invalid input");
        }
        public ActionResult Division(string fistNumber, string secondNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(fistNumber);
                decimal second = ConvertToDouble(secondNumber);
                var division = fist / second;
                return Ok(division.ToString());
            }
            return BadRequest("Invalid input");
        }
        public ActionResult Mean(string fistNumber, string secondNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(fistNumber);
                decimal second = ConvertToDouble(secondNumber);
                var division = fist / second/2;
                return Ok(division.ToString());
            }
            return BadRequest("Invalid input");
        }
        public ActionResult Square(string fistNumber, string secondNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
            {
                double fist = double.Parse(fistNumber);
                double second = double.Parse(secondNumber);
                var fistScare = Math.Sqrt(fist);
                var secondScare = Math.Sqrt(second);
                return Ok(fistScare.ToString());
                return Ok(secondScare.ToString());
            }
            return BadRequest("Invalid input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                NumberStyles.Any,
                NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
                }

        private decimal ConvertToDouble(string strNumber)
        {
            return Convert.ToDecimal(strNumber);
        }
    }
}