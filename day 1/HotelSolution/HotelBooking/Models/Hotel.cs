using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;




namespace HotelBooking.Models
{
    public class Hotel
    {
        [Key]
        public int hotelId { get; set; }
        public string hotelName { get; set; }
        public string password { get; set; }
        public string location { get; set; }
        public int roomId { get; set; }
        [ForeignKey("roomId")]
        public Room room { get; set; }
        public int amenityId { get; set; }
        [ForeignKey("amenityId")]
        public Facilities facilities { get; set; }

        public string picture { get; set; }
    }
}
