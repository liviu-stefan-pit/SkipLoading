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
    public class LoginViewModel : BaseViewModel
    {
        public string Username { get; set; } = "Charlie";

        public ICommand LoginCommand { get; }

        public LoginViewModel(NavigationStore navigationStore)
        {
            LoginCommand = new LoginCommand(this, new NavigationService<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore)));
        }
    }
}
