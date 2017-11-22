using Microsoft.EntityFrameworkCore;

namespace Birthday.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BirthdayDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BirthdayDbContext */
            dbContextOptions.UseMySql(connectionString,d=>d.MigrationsAssembly("Birthday.EntityFrameworkCore"));
        }
    }
}
