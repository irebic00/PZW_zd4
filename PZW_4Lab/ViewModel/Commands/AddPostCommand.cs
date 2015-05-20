using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PZW_4Lab.ViewModel.Commands
{
    public class AddPostCommand: ICommand
    {
        public AddPostCommand(PostCollectionViewModel owner)
        {
            this.owner = owner;
        }

        private PostCollectionViewModel owner;

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
