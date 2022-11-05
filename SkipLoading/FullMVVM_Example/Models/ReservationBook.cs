using FullMVVM_Example.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVVM_Example.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservations;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReservation in _reservations)
            {
                if(existingReservation.Conflict(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }

            _reservations.Add(reservation);
        }
    }
}
