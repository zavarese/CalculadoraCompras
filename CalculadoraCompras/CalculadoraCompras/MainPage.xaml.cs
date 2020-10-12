using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraCompras
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasBackButton(this, false);
            listView.ItemsSource = await App.Database.GetItemsAsync();
            Total.Text = await App.Database.GetTotal();
            TotalComprado.Text = await App.Database.GetTotalComprado();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new PageCompras()
                {
                    BindingContext = args.SelectedItem as ItemCompra
                });
            }
        }

            private void OnClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new PageCompras()
            {
                BindingContext = new ItemCompra()
            });
        }
    }
}
