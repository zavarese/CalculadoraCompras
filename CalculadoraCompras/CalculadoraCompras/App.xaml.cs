using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraCompras
{
    public partial class App : Application
    {
        private static ItemCompraDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        internal static ItemCompraDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemCompraDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("ComprasSQLite.db3"));
                }

                return database;
            }
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
