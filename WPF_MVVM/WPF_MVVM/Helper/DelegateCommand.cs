using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.Common.Helper
{
    public class DelegateCommand : ICommand
    {
        private Func<object, bool> _canExecute;
        private Action<object> _execute;

        // Prüft ob CanExecute erfüllt wurde falls ja wird der Button aktiviert.
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            // Befehl zum überprüfen.
            if (_canExecute == null)
                return true;

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            // Befehl zum ausführen.
            _execute(parameter);
        }

        public DelegateCommand(Action<object> execute,
                               Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        { }

    }
}