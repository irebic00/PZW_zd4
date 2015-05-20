using System;
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
using System.Windows.Shapes;
using PZW_4Lab.ViewModel;

namespace PZW_4Lab.View
{
    public partial class UserEditView : Window
    {
        public UserEditView(UserViewModel currentUserViewModel)
        {
            this.DataContext = currentUserViewModel;
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
