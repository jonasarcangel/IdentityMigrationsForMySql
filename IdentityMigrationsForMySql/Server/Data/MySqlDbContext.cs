using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IdentityMigrationsForMySql.Server.Data
{
    public class MySqlDbContext : ApplicationDbContext
    {
        public MySqlDbContext(
            DbContextOptions<MySqlDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
#if DEBUG_EF
            options.UseMYSql("Server=");
#endif
        }
    }
}