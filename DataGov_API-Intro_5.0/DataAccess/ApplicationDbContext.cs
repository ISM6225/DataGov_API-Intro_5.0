using Microsoft.EntityFrameworkCore;
using DataGov_API_Intro_5._0.Models;

namespace DataGov_API_Intro_5._0.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) { }

        public DbSet<Parks> Parks { get; set; }
        public DbSet<Park> Park { get; set; }
    }
}