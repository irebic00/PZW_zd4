using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using PZW_4Lab.Model;
using PZW_4Lab.ViewModel.Commands;

namespace PZW_4Lab.ViewModel
{
    public class UserCollectionViewModel: ViewModelBase
    {
        public UserCollectionViewModel()
        {
            this.UserViewModels = new ObservableCollection<UserViewModel>();

            this.UserViewModels.Add(new UserViewModel(new User("Ante Antic", new Uri("/Resources/user.png", UriKind.Relative), false)));
            this.UserViewModels.Add(new UserViewModel(new User("Ivana Ivic", new Uri("/Resources/user.png", UriKind.Relative), false)));
            this.UserViewModels.Add(new UserViewModel(new User("Josip Josipovic", new Uri("/Resources/user.png", UriKind.Relative), false)));
            this.UserViewModels.Add(new UserViewModel(new User("Matea Matic", new Uri("/Resources/user.png", UriKind.Relative), false)));

            this.AddCommand = new AddUserCommand(this);
            this.DeleteCommand = new DeleteUserCommand(this);
            this.GoLeftCommand = new GoLeftCommand(this);
            this.GoRightCommand = new GoRightCommand(this);

            this.SelectedUser = this.UserViewModels.First();
        }

        public ObservableCollection<UserViewModel> UserViewModels { get; set; }

        private UserViewModel selectedUser;
        public UserViewModel SelectedUser 
        { 
            get  { return this.selectedUser; }
            set 
            {
                this.selectedUser = value;
                
                this.RaisePropertyChanged("SelectedUser");
                
                UpdateCommands();
            } 
        }

        private void UpdateCommands()
        {
            this.GoLeftCommand.UpdateCanExecuteState();
            this.GoRightCommand.UpdateCanExecuteState();
        }

        public DeleteUserCommand DeleteCommand { get; private set; }
        public AddUserCommand AddCommand { get; private set; }
        
        public GoLeftCommand GoLeftCommand { get; private set; }
        public GoRightCommand GoRightCommand { get; private set; }

        public void ExecuteDeleteCommand(UserViewModel viewModelToDelete)
        {
            if (this.UserViewModels.Contains(viewModelToDelete))
            {
                this.UserViewModels.Remove(viewModelToDelete);
                this.UpdateCommands();
            }            
        }

        public bool CanExecuteGoLeft()
        {
            if (this.SelectedUser == null) { return false; }
            
            return this.UserViewModels.IndexOf(this.SelectedUser) > 0;
        }

        public void ExecuteGoLeft()
        {
            if (this.SelectedUser == null) { return; }

            var currentIndex = this.UserViewModels.IndexOf(this.SelectedUser);

            if (currentIndex <= 0) { return; }

            currentIndex--;

            this.SelectedUser = this.UserViewModels[currentIndex];
        }

        public bool CanExecuteGoRight()
        {
            if (this.SelectedUser == null) { return false; }

            return this.UserViewModels.IndexOf(this.SelectedUser) < this.UserViewModels.Count - 1;
        }

        public void ExecuteGoRight()
        {
            if (this.SelectedUser == null) { return; }

            var currentIndex = this.UserViewModels.IndexOf(this.SelectedUser);

            if (currentIndex >= this.UserViewModels.Count - 1) { return; }

            currentIndex++;

            this.SelectedUser = this.UserViewModels[currentIndex];
        }

        public void ExecuteAddCommand()
        {
            this.UserViewModels.Add(new UserViewModel(new User("unknown", new Uri("/Resources/user.png", UriKind.Relative), false)));
            this.UpdateCommands();
        }
    }
}
