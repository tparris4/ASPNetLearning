

using Microsoft.EntityFrameworkCore;
using RunGroupApplicatiom.Models;

namespace RunGroupApplicatiom.Data
{
    public class AppliuationDBContext :DbContext
    {
        public AppliuationDBContext(DbContextOptions<AppliuationDBContext> options) : base(options)
        {

        }

        public DbSet<Races> Racess { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}

// Entity Framework
// SQL Server