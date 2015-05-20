﻿using System;
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
using PZW_4Lab.ViewModel;

namespace PZW_4Lab.View
{
    /// <summary>
    /// Interaction logic for UserItemCollectionView.xaml
    /// </summary>
    public partial class UserCollectionView : UserControl
    {
        public UserCollectionView()
        {
            this.DataContext = new UserCollectionViewModel();
            InitializeComponent();
        }
    }
}