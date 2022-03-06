using Leonov_PR12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Leonov_PR12.Views
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