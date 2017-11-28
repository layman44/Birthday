using Abp.EntityFrameworkCore;
using Birthday.Persons;
using Birthday.Users;
using Microsoft.EntityFrameworkCore;

namespace Birthday.EntityFrameworkCore
{
    public class BirthdayDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Person> People { get; set; }

        public DbSet<User> User { get; set; }
        public BirthdayDbContext(DbContextOptions<BirthdayDbContext> options)
            : base(options)
        {
            //this.Database.EnsureCreated();
        }
    }
}
