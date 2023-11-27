using Microsoft.AspNetCore.Mvc;
using HotelBooking.Interfaces;
using HotelBooking.Models;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        // GET: api/Hotel
        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> Get()
        {
            var hotels = _hotelService.GetProducts();
            return Ok(hotels);
        }

        // POST: api/Hotel
        [HttpPost]
        public ActionResult<Hotel> Post([FromBody] Hotel hotel)
        {
            if (hotel == null)
            {
                return BadRequest("Hotel data is null.");
            }

            var addedHotel = _hotelService.Add(hotel);

            return CreatedAtAction("Get", new { id = addedHotel.hotelId }, addedHotel);
        }
    }
}
