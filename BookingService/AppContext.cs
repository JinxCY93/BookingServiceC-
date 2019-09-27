using Microsoft.EntityFrameworkCore;

namespace BookingService
{
    public class AppContext : DbContext
    {
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Flight> Flight { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "" +
                "Server=W10CF1KGH2;" +
                "Database=bookingservice_db;" +
                "User Id=testing123;" +
                "Password = @Jehovah113;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
