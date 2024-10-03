using Microsoft.EntityFrameworkCore;
using Temp.Models;

namespace Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel { Id = 1, Name = "Test1", DisplayOrder = 1 },
                new CategoryModel { Id = 2, Name = "Test2", DisplayOrder = 2 }
    );
        }
    }
}
