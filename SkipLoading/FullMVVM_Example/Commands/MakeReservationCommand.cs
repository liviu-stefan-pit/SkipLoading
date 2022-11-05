using FullMVVM_Example.Exceptions;
using FullMVVM_Example.Models;
using FullMVVM_Example.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FullMVVM_Example.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _makeReservationViewModel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _hotel = hotel;
            _makeReservationViewModel = makeReservationViewModel;

            _makeReservationViewModel.PropertyChanged += _makeReservationViewModel_PropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate
                );

            try
            {
                _hotel.MakeReservation(reservation);
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("Room is already taken!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void _makeReservationViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeReservationViewModel.Username))
            {
                OnCanExecuteChanged();
            }
        }
    }
}
