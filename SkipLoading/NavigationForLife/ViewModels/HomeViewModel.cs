using NavigationForLife.Commands;
using NavigationForLife.Services;
using NavigationForLife.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationForLife.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(new NavigationService<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore)));
        }
    }
}
