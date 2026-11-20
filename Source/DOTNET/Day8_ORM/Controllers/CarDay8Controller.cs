using Microsoft.AspNetCore.Mvc;
using TryToLearnNetCore.LearnOn30Days.Day2_RESTFulAPIs;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Entity;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Services.Interface;

namespace TryToLearnNetCore.LearnOn30Days.Day8_ORM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDay8Controller : ControllerBase
    {
        // 1. Initial Services:
        private readonly CarInterfaceDay8 _carSerices;
        
        // 2. Inject Services to controller
        public CarDay8Controller(CarInterfaceDay8 carService)
        {
            _carSerices = carService;
        }

        // 3. Action async 
        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var cars = await _carSerices.GetAllCar();
            var response = ApiResponse<List<CarDay8>>.ReponseSuccess(statusCode: 200, data: cars, message: "Get list car of server successful");
            return Ok(response);
        }
    }
}
