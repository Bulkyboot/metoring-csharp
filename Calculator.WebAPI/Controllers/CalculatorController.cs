using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Calculator.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                decimal first = ConvertToDouble(firstNumber);
                decimal second = ConvertToDouble(secondNumber);
                var sum = first + second;
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber) {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(firstNumber);
                decimal second = ConvertToDouble(secondNumber);
                var subtraction = fist - second;
                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid input");
        }
        [HttpGet("mutiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Mutiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(firstNumber);
                decimal second = ConvertToDouble(secondNumber);
                var mutiplication = fist * second;
                return Ok(mutiplication.ToString());
            }
            return BadRequest("Invalid input");
        }
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(firstNumber);
                decimal second = ConvertToDouble(secondNumber);
                var division = fist / second;
                return Ok(division.ToString());
            }
            return BadRequest("Invalid input");
        }
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                decimal fist = ConvertToDouble(firstNumber);
                decimal second = ConvertToDouble(secondNumber);
                var division = (fist + second)/2;
                return Ok(division.ToString());
            }
            return BadRequest("Invalid input");
        }
        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number)
        {
            if (IsNumeric(number))
            {
                double square = double.Parse(number);
                var squareRoot = Math.Sqrt(square);
                return Ok(squareRoot.ToString());
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