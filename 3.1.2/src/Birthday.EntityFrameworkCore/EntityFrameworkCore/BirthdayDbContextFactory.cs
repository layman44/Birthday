using Birthday.Configuration;
using Birthday.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Birthday.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class BirthdayDbContextFactory : IDesignTimeDbContextFactory<BirthdayDbContext>
    {
        public BirthdayDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BirthdayDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(BirthdayConsts.ConnectionStringName)
            );

            return new BirthdayDbContext(builder.Options);
        }
    }
}