using Çalışma1.ViewModels;
using Çalışma1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Çalışma1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
