using Microsoft.EntityFrameworkCore;
using Test.Data.Entities;

namespace Test.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Destination> Destination { get; set; }
    }
}
