using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TryToLearnNetCore.LearnOn30Days.Day2_RESTFulAPIs;
using TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Entities;
using TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Services.Implements;

namespace TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDay4Controller : ControllerBase
    {
        // in this lesson, we don't need initial (new ImplCars) variance for service, we will injection to Controller

        // old
        // private readonly ImplCars _CarServices = new ImplCars();

        // new
        private readonly ImplCars _CarServices;
        public CarDay4Controller(ImplCars carServices)
        {
            carServices = _CarServices;
        }
        // If we no heve this function, we will meet error:
        /*
            System.NullReferenceException: 'Object reference not set to an instance of an object.'
         */

        [HttpGet("{id}")]
        public IActionResult GetCarByID([FromRoute] string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                var result = ApiResponse<object>.ReponseFailed(400, "ERROR_CARS", "ID car cannot have space in ID");
                return Ok(result);
            }
            var findCar = _CarServices.GetCarDay4ByID(id);
            if (findCar == null)
            {
                var result = ApiResponse<object>.ReponseFailed(404, "ERROR_CARS", "Cannot find this ID car in database");
                return Ok(result);
            }
            var success = ApiResponse<CarDay4>.ReponseSuccess(200, findCar);
            return Ok(success);
        }




        [HttpPut("{id}")]
        public IActionResult UpdateCar([FromRoute] string id, [FromQuery] bool notify, [FromBody] CarDay4 car)
        {
            //return Ok(new
            //{
            //    Message = "Cập nhật thành công.",
            //    CarID = id,
            //    SendNotification = notify,
            //    Data = car
            //});
            var response = ApiResponse<CarDay4>.ReponseSuccess(200, car, "Get info car successful");
            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateCar([FromBody] CarDay4 newCar)
        {
            if (_CarServices.CheckExists(newCar.carID))
            {
                var resonse = ApiResponse<CarDay4>.ReponseFailed(400, "Car is Exists");
                return Ok(resonse);
            }
            _CarServices.CreateCarDay4(newCar);
            var response = ApiResponse<CarDay4>.ReponseSuccess(201, newCar, "Create Car SuccessFul");
            return Ok(response);
        }
    }
}
