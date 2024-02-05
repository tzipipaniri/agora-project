using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;

namespace DataContext2
{
    public class Db : DbContext, IContext
    {
        public DbSet<User> Users { get ;set ; }
        public DbSet<Item> Items { get; set ; }
        public DbSet<Category> Categories { get ; set ; }
        public async Task save()
        {
           await SaveChangesAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=myDatabase;trusted_connection=true;");
        }
    }
}
