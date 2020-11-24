using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMigrationsForMySql.Server.Data
{
    public class SqliteDbContext : ApplicationDbContext
    {
        public SqliteDbContext(
            DbContextOptions<SqliteDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
#if DEBUG_EF
            options.UseSqlite("DataSource=");
#endif
        }
    }
}
