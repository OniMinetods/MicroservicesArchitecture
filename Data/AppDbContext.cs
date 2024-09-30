using MicroservicesArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesArchitecture.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
