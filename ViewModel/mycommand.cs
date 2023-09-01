using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BwoodChess.ViewModel
{
    public class RelayCommand:ICommand
    {
        private readonly Action _execute;

        public RelayCommand(Action execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // You can implement logic here to determine if the command can be executed.
            return true;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }
    }
}
