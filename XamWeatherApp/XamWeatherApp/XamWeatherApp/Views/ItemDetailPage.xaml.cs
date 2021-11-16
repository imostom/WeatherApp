using System.ComponentModel;
using Xamarin.Forms;
using XamWeatherApp.ViewModels;

namespace XamWeatherApp.Views
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