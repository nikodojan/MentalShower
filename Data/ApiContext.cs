using MentalShower.Models;
using Microsoft.EntityFrameworkCore;

namespace MentalShower.Data
{
    public class ApiContext :DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Measurement> Measurements { get; set; }

  
    }
}
