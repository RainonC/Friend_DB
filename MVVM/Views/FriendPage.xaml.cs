﻿using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendPage : ContentPage
    {
        public FriendViewModel ViewModel { get; set; }
        public FriendPage(FriendViewModel viewModel)
        {
            
            InitializeComponent();
            ViewModel=viewModel;
            this.BindingContext = ViewModel;
        }
    }
}