using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PZW_4Lab.Model;

namespace PZW_4Lab.ViewModel.Commands
{
    public class AddUserCommand: ICommand
    {
        public AddUserCommand(UserCollectionViewModel owner)
        {
            this.owner = owner;
        }

        private UserCollectionViewModel owner;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.owner.ExecuteAddCommand();
        }
    }
}
