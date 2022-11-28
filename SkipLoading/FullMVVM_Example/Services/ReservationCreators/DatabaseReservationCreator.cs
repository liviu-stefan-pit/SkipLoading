using FullMVVM_Example.DbContexts;
using FullMVVM_Example.DTOs;
using FullMVVM_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVVM_Example.Services.ReservationCreators
{
    public class DatabaseReservationCreator : IReservationCreator
    {
        private readonly ReservoomDbContextFactory _dbContextFactory;

        public DatabaseReservationCreator(ReservoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public Task CreateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        //public Task CreateReservation(Reservation reservation)
        //{
        //    using(ReservroomDbContext context = _dbContextFactory.CreateDbContext())
        //    {
        //        ReservationDTO reservationDTO = ToReservationDTO(reservation);
        //    }
        //}

        private ReservationDTO ToReservationDTO(Reservation reservation)
        {
            throw new NotImplementedException(); //continua de acii 12:02 #6
        }
    }
}
