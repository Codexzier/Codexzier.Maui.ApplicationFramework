using System.Windows.Input;

namespace Codexzier.Maui.ApplicationFramework.Views.Base
{
    public abstract class BaseCommand : ICommand
    {
        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public virtual void Execute(object parameter)
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
