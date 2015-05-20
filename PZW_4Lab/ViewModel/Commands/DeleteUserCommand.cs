using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PZW_4Lab.ViewModel.Commands
{
    public class DeleteUserCommand: ICommand
    {
        public DeleteUserCommand(UserCollectionViewModel userCollectionViewModel)
        {
            this.Owner = userCollectionViewModel;
        }

        public UserCollectionViewModel Owner { get; private set; }

        public bool CanExecute(object parameter) { return true; }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter) 
        {
            if (parameter is UserViewModel)
            {
                this.Owner.ExecuteDeleteCommand(parameter as UserViewModel);
            }
        }
    }
}
