using _11_MVC_FulboolOrnek.Models;
using Microsoft.EntityFrameworkCore;

namespace _11_MVC_FulboolOrnek.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Futbolcu> Futbolcu { get; set;}
        public DbSet<Mevki> Mevki { get; set;}
        public DbSet<Takim> Takim { get; set;}      

    }
    
}
