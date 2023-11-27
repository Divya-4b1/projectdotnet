using System.Collections.Generic;
using HotelBooking.Interfaces;
using HotelBooking.Models;

namespace HotelBooking.Services
{
    public class HotelService : IHotelService
    {
        private List<Hotel> hotels; // Assuming you have a list to store hotels

        public HotelService()
        {
            // Initialize the list of hotels in the constructor
            hotels = new List<Hotel>();
        }

        public List<Hotel> GetProducts()
        {
            // Return the list of hotels
            return hotels;
        }

        public Hotel Add(Hotel hotel)
        {
            // Add the hotel to the list and return the added hotel
            hotels.Add(hotel);
            return hotel;
        }
    }
}