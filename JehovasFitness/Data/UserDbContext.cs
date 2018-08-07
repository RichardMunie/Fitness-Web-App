using JehovasFitness.Models;
using Microsoft.EntityFrameworkCore;

namespace JehovasFitness.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<UserClass> Users { get; set; }
        

        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        { }

    }
}
