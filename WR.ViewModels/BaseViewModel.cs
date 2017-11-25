using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WR.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class DelegateCommand<T> : System.Windows.Input.ICommand where T : class
        {
            private readonly Predicate<T> _canExecute;
            private readonly Action<T> _execute;

            public DelegateCommand(Action<T> execute)
                : this(execute, null)
            {
            }

            public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
            {
                _execute = execute;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                if (_canExecute == null)
                    return true;

                return _canExecute((T)parameter);
            }

            public void Execute(object parameter)
            {
                _execute((T)parameter);
            }

            public event EventHandler CanExecuteChanged;
            public void RaiseCanExecuteChanged()
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
