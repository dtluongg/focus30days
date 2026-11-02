using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TryToLearnNetCore.LearnOn30Days.Day1_BasicOfNetCore
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsDay1Controller : ControllerBase
    {

        [HttpPut("{id}")]
        public IActionResult UpdateCar([FromRoute] string id, [FromQuery] bool notify, [FromBody] Cars2 car) {
            return Ok(new
            {
                Message = "Cập nhật thành công.",
                CarID = id,
                SendNotification = notify,
                Data = car
            });
        }
    }
}
