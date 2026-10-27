using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TryToLearnNetCore.LearnOn30Days.Day2_RESTFulAPIs;
using TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Entities;
using TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Services.Implements;

namespace TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDay3Controller : ControllerBase
    {
        private readonly ImplCars _CarServices = new ImplCars();
        [HttpGet("{id}")]
        public IActionResult GetCarByID([FromRoute] string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                var result = ApiResponse<object>.ReponseFailed(400, "ERROR_CARS", "ID car cannot have space in ID");
                return Ok(result);
            }
            var findCar = _CarServices.GetCarDay3ByID(id);
            if (findCar == null)
            {
                var result = ApiResponse<object>.ReponseFailed(404, "ERROR_CARS", "Cannot find this ID car in database");
                return Ok(result);
            }
            var success = ApiResponse<CarDay3>.ReponseSuccess(200, findCar);
            return Ok(success);
        }




        [HttpPut("{id}")]
        public IActionResult UpdateCar([FromRoute] string id, [FromQuery] bool notify, [FromBody] CarDay3 car)
        {
            //return Ok(new
            //{
            //    Message = "Cập nhật thành công.",
            //    CarID = id,
            //    SendNotification = notify,
            //    Data = car
            //});
            var response = ApiResponse<CarDay3>.ReponseSuccess(200, car, "Get info car successful");
            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateCar([FromBody] CarDay3 newCar)
        {
            if (_CarServices.CheckExists(newCar.carID))
            {
                var resonse = ApiResponse<CarDay3>.ReponseFailed(400, "Car is Exists");
                return Ok(resonse);
            }
            _CarServices.CreateCarDay3(newCar);
            var response = ApiResponse<CarDay3>.ReponseSuccess(201, newCar, "Create Car SuccessFul");
            return Ok(response);
        }
    }
}
