using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using abp-test.Authorization.Roles;
using abp-test.Authorization.Users;
using abp-test.MultiTenancy;

namespace abp-test.EntityFrameworkCore
{
    public class abp-testDbContext : AbpZeroDbContext<Tenant, Role, User, abp-testDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public abp-testDbContext(DbContextOptions<abp-testDbContext> options)
            : base(options)
        {
        }
    }
}
