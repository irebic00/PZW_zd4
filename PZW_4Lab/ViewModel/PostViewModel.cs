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
    public class PostViewModel
    {
        public PostViewModel(Post post)
        {
            this.CurrentPost = post;

            this.CurrentPostUser = new ObservableCollection<UserViewModel>();
            this.CurrentPostUser.Add(new UserViewModel(CurrentPost.user));

            this.EditCommand = new EditPostCommand(this);

            if (this.CurrentPost.isPostOwner == false)
                this.CurrentPost.optionsVisibility = Visibility.Collapsed;
        }

        public ObservableCollection<UserViewModel> CurrentPostUser { get; set; }
        public Post CurrentPost { get; set; }

        public EditPostCommand EditCommand { get; set; }
        public void ExecuteEditCommand()
        {
            var window = new PostEditView(this);

            window.ShowDialog();
        }
    }
}
