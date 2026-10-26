using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace TryToLearnNetCore.LearnOn30Days.Day2
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsDay2Controller : ControllerBase
    {

        private static readonly List<Cars2> _cars2 = new() {
            new Cars2 { carID  = "car01", carName = "Dodge Challenger", carPrice = 300000, carTopSpeed = 287, carType = "Muscle" },
            new Cars2 { carID  = "car02", carName = "Dodge Challenger", carPrice = 300000, carTopSpeed = 287, carType = "Muscle" }
        };

        [HttpGet("{id}")]
        public IActionResult GetCarByID([FromRoute] string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                var result = ApiResponse<object>.ReponseFailed(400, "ERROR_CARS", "ID car cannot have space in ID");
                return Ok(result);
            }
            var findCar = _cars2.FirstOrDefault(c => c.carID.Equals(id, StringComparison.OrdinalIgnoreCase));
            if (findCar == null) {
                var result = ApiResponse<object>.ReponseFailed(404, "ERROR_CARS", "Cannot find this ID car in database");
                return Ok(result);
            }
            var success = ApiResponse<Cars2>.ReponseSuccess(200, findCar);
            return Ok(success);
        }




        [HttpPut("{id}")]
        public IActionResult UpdateCar([FromRoute] string id, [FromQuery] bool notify, [FromBody] Cars2 car) {
            //return Ok(new
            //{
            //    Message = "Cập nhật thành công.",
            //    CarID = id,
            //    SendNotification = notify,
            //    Data = car
            //});
            var response = ApiResponse<Cars2>.ReponseSuccess(200, car, "Get info car successful");
            return Ok(response);
        }
    }
}
