using Microsoft.EntityFrameworkCore;
using BrainBoost.Models.Domain;

namespace BrainBoost.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
           
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
    }
}
