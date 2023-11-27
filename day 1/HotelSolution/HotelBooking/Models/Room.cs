using HotelBooking.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class Room
    {
        public int roomId { get; set; }
        public int hotelId { get; set; }
        [ForeignKey("hotelId")]
        public Hotel hotel { get; set; }
        public int totalRoom { get; set; }
        public int availableRoom { get; set; }
        public string roomType { get; set; }
        public float price { get; set; }

    }
}
