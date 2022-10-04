using Microsoft.EntityFrameworkCore;
using OurPortfolio.Models;

namespace OurPortfolio.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}
