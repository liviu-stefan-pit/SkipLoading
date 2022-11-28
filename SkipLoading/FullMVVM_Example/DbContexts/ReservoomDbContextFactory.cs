using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVVM_Example.DbContexts
{
    public class ReservoomDbContextFactory
    {
        private Action<SqliteDbContextOptionsBuilder>? _connectionString;

        public ReservoomDbContextFactory(Action<SqliteDbContextOptionsBuilder>? connectionString)
        {
            _connectionString = connectionString;
        }

        public ReservroomDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new ReservroomDbContext(options);
        }
    }
}
