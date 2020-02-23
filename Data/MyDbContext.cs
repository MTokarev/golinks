using golink.Models;
using Microsoft.EntityFrameworkCore;

namespace golink.Data {

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
        }

        public DbSet<Site> Sites {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Site>().HasData(
                new Site
                {
                    Id = 1,
                    Alias = "fb",
                    Url = "https://facebook.com"
                },
                new Site
                {
                    Id = 2,
                    Alias = "youtube",
                    Url = "https://youtube.com"
                },
                new Site
                {
                    Id = 3,
                    Alias = "randomcat",
                    Url = "https://random.cat/"
                }
            );
        }
    }   
}