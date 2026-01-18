using Microsoft.EntityFrameworkCore;
using TH17012026.Domain.Entities;

namespace TH17012026.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
    }
}
