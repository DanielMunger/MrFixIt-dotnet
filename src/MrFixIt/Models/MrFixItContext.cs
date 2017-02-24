using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MrFixIt.Models
{
    public class MrFixItContext : IdentityDbContext<ApplicationUser>
    {
        public MrFixItContext()
        {
        }

        public virtual DbSet<Job> Jobs { get; set; }

        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=DESKTOP-GC3DC7B\SQLEXPRESS;Database=MrFixIt;integrated security=True");
        }
        

        public MrFixItContext(DbContextOptions<MrFixItContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}