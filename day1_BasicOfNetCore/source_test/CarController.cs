using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TryToLearnNetCore.Day1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        [HttpPut("{id}")]
        public IActionResult UpdateCar([FromRoute] string id, [FromQuery] Boolean notify, [FromBody] Cars car) {
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
