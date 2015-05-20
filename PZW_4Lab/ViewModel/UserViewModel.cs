using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PZW_4Lab.Model;
using PZW_4Lab.View;
using PZW_4Lab.ViewModel.Commands;

namespace PZW_4Lab.ViewModel
{
    public class UserViewModel: ViewModelBase
    {
        public UserViewModel(User user) 
        {
            this.User = user;
            this.EditCommand = new EditUserCommand(this);
        }

        public EditUserCommand EditCommand { get; private set; }

        public User User { get; set; }

        public void ExecuteEditCommand()
        {
            var window = new UserEditView(this);

            window.ShowDialog();
        }
    }
}
