using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PokedexWPF
{
    public class Command : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        public event EventHandler CanExecuteChanged;

        public Command(Action _execute, Func<bool> _canExecute = null)
        {
            if (_execute == null)
            {
                throw new ArgumentException("execute");
            }

            this._execute = _execute;
            this._canExecute = _canExecute ?? (() => true);
        }

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

        [DebuggerStepThrough]
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

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged.Invoke(this, EventArgs.Empty);
        }
    }
}
