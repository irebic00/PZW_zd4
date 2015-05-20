using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PZW_4Lab.ViewModel.Commands
{
    public class GoRightCommand: ICommand
    {
        public GoRightCommand(UserCollectionViewModel owner)
        {
            this.Owner = owner;
        }

        private UserCollectionViewModel Owner;

        public bool CanExecute(object parameter)
        {
            return this.Owner.CanExecuteGoRight();
        }

        public event EventHandler CanExecuteChanged;

        public void UpdateCanExecuteState()
        {
            if (CanExecuteChanged != null && this.Owner.UserViewModels.Count != 0)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            this.Owner.ExecuteGoRight();
        }
    }
}
