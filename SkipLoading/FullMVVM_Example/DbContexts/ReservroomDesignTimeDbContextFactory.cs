using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVVM_Example.DbContexts
{
    public class ReservroomDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ReservroomDbContext>
    {
        public ReservroomDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=reservoom.db").Options;

            return new ReservroomDbContext(options);
        }
    }
}
