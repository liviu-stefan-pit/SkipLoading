using FullMVVM_Example.Commands;
using FullMVVM_Example.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FullMVVM_Example.ViewModels
{
    public class ReservationListingViewModel : BaseViewModel
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "Charlie", DateTime.Now, new DateTime(2023,1,2))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 3), "Pit", DateTime.Now, new DateTime(2023, 1, 2))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 4), "John", DateTime.Now, new DateTime(2023, 1, 2))));
        }
    }
}
