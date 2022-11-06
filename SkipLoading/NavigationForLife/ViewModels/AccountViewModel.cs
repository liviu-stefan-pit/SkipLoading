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
    public class AccountViewModel : BaseViewModel 
    {
        public ICommand NavigateHomeCommand { get; set; }

        public ICommand NavigateLoginCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(new NavigationService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore)));
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(new NavigationService<LoginViewModel>(navigationStore, () => new LoginViewModel(navigationStore)));
        }
    }
}
