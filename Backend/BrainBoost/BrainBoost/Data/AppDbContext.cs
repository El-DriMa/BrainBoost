using Microsoft.EntityFrameworkCore;
using BrainBoost.Models.Domain;

namespace BrainBoost.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
           
        }
        public DbSet<User> User { get; set; }
    }
}
