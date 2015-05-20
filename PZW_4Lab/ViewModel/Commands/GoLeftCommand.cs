using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PZW_4Lab.ViewModel.Commands
{
    public class GoLeftCommand: ICommand
    {
        public GoLeftCommand(UserCollectionViewModel owner)
        {
            this.Owner = owner;
        }

        private UserCollectionViewModel Owner;

        public bool CanExecute(object parameter)
        {
            return this.Owner.CanExecuteGoLeft();
        }

        public event EventHandler CanExecuteChanged;

        public void UpdateCanExecuteState()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            this.Owner.ExecuteGoLeft();
        }
    }
}
