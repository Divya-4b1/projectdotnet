using HotelBooking.Models;

namespace HotelBooking.Interfaces
{
    public interface IHotelService
    {
        
        List<Hotel> GetProducts();
        Hotel Add(Hotel hotel);

    }
}
