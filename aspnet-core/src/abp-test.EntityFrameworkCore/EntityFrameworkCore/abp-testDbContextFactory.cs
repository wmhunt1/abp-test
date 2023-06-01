using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using abp-test.Configuration;
using abp-test.Web;

namespace abp-test.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class abp-testDbContextFactory : IDesignTimeDbContextFactory<abp-testDbContext>
    {
        public abp-testDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<abp-testDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            abp-testDbContextConfigurer.Configure(builder, configuration.GetConnectionString(abp-testConsts.ConnectionStringName));

            return new abp-testDbContext(builder.Options);
        }
    }
}
