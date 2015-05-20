using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PZW_4Lab.Model
{
    public class Post
    {
        public Post(string post, User user, bool isPostOwner)
        {
            this.post = post;
            this.user = user;
            this.isPostOwner = isPostOwner;
        }
        public bool isPostOwner { get; set; }
        public Visibility optionsVisibility { get; set; }
        public User user { get; set; }
        public string post { get; set; }
    }
}
