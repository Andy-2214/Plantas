using Microsoft.EntityFrameworkCore;
using Plantas.Models;

namespace Plantas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Plant> Plantas => Set<Plant>();
    }
}