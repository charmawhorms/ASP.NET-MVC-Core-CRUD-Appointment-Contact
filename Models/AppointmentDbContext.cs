using Microsoft.EntityFrameworkCore;

namespace AppointmentContact.Models
{
    public class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) : base(options)
        {
            
        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
