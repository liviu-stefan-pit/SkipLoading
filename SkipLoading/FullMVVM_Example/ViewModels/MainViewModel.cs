using FullMVVM_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVVM_Example.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public BaseViewModel CurrentViewModel { get; }

        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new MakeReservationViewModel(hotel);
        }
    }
}
