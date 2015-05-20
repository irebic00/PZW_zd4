using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PZW_4Lab.Model
{
    public class User
    {
        public User(string userName, Uri imagePath, bool isCurrentUser)
        {
            this.Title = userName;
            this.ImagePath = imagePath;

            if (isCurrentUser == false)
                this.editOptionVisibility = Visibility.Collapsed;
            else if (isCurrentUser == true)
            {
                this.deleteOptionVisibility = Visibility.Collapsed;
                this.editOptionVisibility = Visibility.Visible;
            }
        }

        public Visibility editOptionVisibility { get; set; }
        public Visibility deleteOptionVisibility { get; set; }
        public string Title { get; set; }
        public Uri ImagePath { get; set; }
    }
}
