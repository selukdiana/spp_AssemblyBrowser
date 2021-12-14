using Assembly_Browser.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ButtonViewModel = Assembly_Browser.ViewModel.ButtonViewModel;

namespace Assembly_Browser
{
    class ButtonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        ButtonViewModel _buttonViewModel;

        public ButtonCommand(ButtonViewModel viewModel)
        {
            _buttonViewModel = viewModel;
        }
        //can it complete
        public bool CanExecute(object parameter)
        {
            return true;
        }
        //complete 
        public void Execute(object parameter)
        {
            _buttonViewModel.OnExecute();
        }
    }
}