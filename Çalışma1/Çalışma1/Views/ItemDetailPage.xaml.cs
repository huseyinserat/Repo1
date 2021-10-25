using Çalışma1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Çalışma1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}