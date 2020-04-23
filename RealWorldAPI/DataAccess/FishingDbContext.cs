using Microsoft.EntityFrameworkCore;
using RealWorldAPI.Models.Fishing;

namespace RealWorldAPI.DataAccess
{
    public class FishingDbContext : DbContext
    {
        public DbSet<Fishing> Fishing { get; set; }
        public DbSet<Lure> Lure { get; set; }
        public FishingDbContext(DbContextOptions<FishingDbContext> options)
            : base(options)
        {
        }
    }
}