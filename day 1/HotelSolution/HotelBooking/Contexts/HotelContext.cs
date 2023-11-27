using HotelBooking.Models;

using Microsoft.EntityFrameworkCore;
namespace HotelBooking.Contexts
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<User> Users { get; set; }
        
        public DbSet<Hotel> Hotels { get; set; }
        
        public DbSet<Room> Rooms { get; set; }

        
        public DbSet<Facilities> Facilitiess { get; set; }
        
      //  public DbSet<Review> Reviews { get; set; }
        
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configure the relationship between Hotels and Reviews
           // modelBuilder.Entity<Review>()
           // .HasOne(e => e.user)
            //.WithMany()
            //.OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Booking>()
           .HasOne(e => e.room)
           .WithMany()
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}