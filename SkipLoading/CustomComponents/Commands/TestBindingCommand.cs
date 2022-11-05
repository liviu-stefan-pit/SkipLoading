using CustomComponents.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CustomComponents.Commands
{
    internal class TestBindingCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private MainWindowViewModel _viewModel;

        public TestBindingCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show(_viewModel.Password);
        }
    }
}
