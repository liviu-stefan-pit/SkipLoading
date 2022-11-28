using FullMVVM_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVVM_Example.Services.ReservationCreators
{
    internal interface IReservationCreator
    {
        Task CreateReservation(Reservation reservation);
    }
}
