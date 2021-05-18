using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQRT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        private readonly ILogger<CalculateController> _logger;

        public CalculateController(ILogger<CalculateController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{number}/{accuracy}/{type}")]
        public ActionResult Get(string number, int accuracy, string type)
        {
            try
            {
                var result = (string)null;
                if (type.Equals("number", StringComparison.OrdinalIgnoreCase))
                {
                    result = Calculator.Calculate(double.Parse(number), accuracy);
                }
                else if (type.Equals("analytic", StringComparison.OrdinalIgnoreCase))
                {
                    result = "it still doesn't work";
                }

                return Ok(new
                {
                    status = "success",
                    data = result
                });
            }
            catch(Exception ex)
            {
                return BadRequest(new
                {
                    status = "error",
                    message = ex.Message + ":" + ex.StackTrace
                });
            }
            
        }
    }
}
