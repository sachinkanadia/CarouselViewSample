using System.ComponentModel;
using Xamarin.Forms;
using CarouselViewSample.ViewModels;

namespace CarouselViewSample.Views
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