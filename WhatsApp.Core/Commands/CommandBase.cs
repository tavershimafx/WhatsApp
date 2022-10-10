using System.Windows.Input;

namespace WhatsApp.Core.Commands
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged = delegate { };

        public bool CanExecute(object parameter) => true;

        public virtual void Execute(object parameter) { Action.Invoke(parameter); }

        private readonly Action<object> Action = delegate { };

        public CommandBase(Action<object> action)
        {
            Action = action;
        }
    }
}
