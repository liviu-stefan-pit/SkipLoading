using FullMVVM_Example.DTOs;
using FullMVVM_Example.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVVM_Example.DbContexts
{
    public class ReservroomDbContext : DbContext
    {
        public ReservroomDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ReservationDTO> Reservations { get; set; }
    }
}
