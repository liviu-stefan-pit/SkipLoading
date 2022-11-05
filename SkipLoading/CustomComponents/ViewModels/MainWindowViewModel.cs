using CustomComponents.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomComponents.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        public MainWindowViewModel()
        {
            TestBinding = new TestBindingCommand(this);
        }

        public ICommand TestBinding { get; set; }
    }
}
