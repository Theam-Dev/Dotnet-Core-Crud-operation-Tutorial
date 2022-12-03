using Microsoft.EntityFrameworkCore;

namespace DotnetCoreCrudApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Post> Post { get; set; }

    }
}
