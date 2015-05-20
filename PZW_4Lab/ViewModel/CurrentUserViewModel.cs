using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZW_4Lab.Model;
using System.Collections.ObjectModel;

namespace PZW_4Lab.ViewModel
{
    public class CurrentUserViewModel : ViewModelBase
    {
        public CurrentUserViewModel()
        {
            this.currentUserViewModel = new ObservableCollection<UserViewModel>();

            this.currentUserViewModel.Add(new UserViewModel(new User("Mate Matic", new Uri("/Resources/image.png", UriKind.Relative), true)));
            
        }
        public ObservableCollection<UserViewModel> currentUserViewModel { get; set; }
    }
}

