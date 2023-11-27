using HotelBooking.Models.DTOs;

namespace HotelBooking.Interfaces
{
    public interface IUserService
    {
        UserDTO Login(UserDTO userDTO);
        UserDTO Register(UserRegisterDTO userRegisterDTO);
    }
}
