using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PokedexWPF
{
    class Command : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        public event EventHandler CanExecuteChanged;

        //"= null" means that it sets the default to null
        public Command(Action execute, Func<bool> canExecute = null)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
            //set _canExecute to canExecute (and whatever was passed through in the constructor), if it cannot then set to True
            _canExecute = canExecute ?? (() => true);
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            try
            {
                return _canExecute();
            }
            catch
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            if (!CanExecute(parameter))
            {
                return;
            }

            try
            {
                _execute();
            }
            catch
            {
                Debugger.Break();
            }
        }

        public void RaiseCanExecuteChange()
        {
            CanExecuteChanged.Invoke(this, EventArgs.Empty);
        }
    }
}
