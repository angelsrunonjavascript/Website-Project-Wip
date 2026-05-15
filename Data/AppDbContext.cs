using Microsoft.EntityFrameworkCore;
using WebsiteProject.Models;

namespace WebsiteProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EnergyDrink> EnergyDrinks { get; set; }
    }
}