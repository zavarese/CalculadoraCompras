using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraCompras
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCompras : ContentPage
    {
        public PageCompras()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            ItemCompra p = BindingContext as ItemCompra;

            if(p.ID == 0)
            {
                btnExcluir.IsEnabled = false;
            }
            
        }

            private void OnSaveCompra(object sender, EventArgs args)
        {
            ItemCompra p = BindingContext as ItemCompra;
            App.Database.SaveItemAsync(p);
            Navigation.PushAsync(new MainPage());

        }

        private void OnExcluirCompra(object sender, EventArgs args)
        {
            ItemCompra p = BindingContext as ItemCompra;
            App.Database.DeleteItemAsync(p);
            Navigation.PushAsync(new MainPage());
        }
    }

}