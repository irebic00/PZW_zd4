using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PZW_4Lab.Model;
using PZW_4Lab.View;
using PZW_4Lab.ViewModel.Commands;

namespace PZW_4Lab.ViewModel
{
    public class PostCollectionViewModel : ViewModelBase
    {
        public PostCollectionViewModel()
        {
            this.PostCollectionViewModels = new ObservableCollection<PostViewModel>();

            this.PostCollectionViewModels.Add(new PostViewModel(new Post("Hello World!!!", new User("Ante Antic", new Uri("/Resources/user.png", UriKind.Relative), false), false)));
            this.PostCollectionViewModels.Add(new PostViewModel(new Post("Ante makes no sense... -_-", new User("Matea Matic", new Uri("/Resources/user.png", UriKind.Relative), false), false)));

            for (int i = 0; i < PostCollectionViewModels.Count; i++ )
            {
                PostCollectionViewModels[i].CurrentPost.user.deleteOptionVisibility = Visibility.Collapsed;
                PostCollectionViewModels[i].CurrentPost.user.editOptionVisibility = Visibility.Collapsed;
            }

            this.addPostCommand = new AddPostCommand(this);
            this.DeleteCommand = new DeletePostCommand(this);
        }

        public ObservableCollection<PostViewModel> PostCollectionViewModels { get; set; }

        public AddPostCommand addPostCommand { get; set; }
        public DeletePostCommand DeleteCommand { get; private set; }


        public string thisUsersPost { get; set; }
        public void ExecuteAddCommand()
        {
            var currentUser = CurrentUserView.CurrentUser.currentUserViewModel[0].User;

            var tempPost = new PostViewModel(new Post(this.thisUsersPost, currentUser, true));
            tempPost.CurrentPost.user.editOptionVisibility = Visibility.Collapsed;

            if (tempPost.CurrentPost.post != null && tempPost.CurrentPost.post != "")
                this.PostCollectionViewModels.Insert(0, tempPost);
        }

        public void ExecuteDeleteCommand(PostViewModel viewModelToDelete)
        {
            if (this.PostCollectionViewModels.Contains(viewModelToDelete))
            {
                this.PostCollectionViewModels.Remove(viewModelToDelete);
            }
        }
    }
}
