using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnDotNet.Source.Day5_Custom_Exception_Middleware.ControllersDay5
{
    [Route("api/[controller]")]
    [ApiController]
    public class Day5Controller : ControllerBase
    {
        [HttpGet("test-exception-error")]
        public IActionResult TestError()
        {
            throw new InvalidOperationException("This is virtual for check middleware!");
        }
    }
}
