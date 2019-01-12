
using Xamarin.Forms;

namespace Sales
{

    using Views;
    using ViewModels;
    using Sales.Helpers;

    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            if (Settings.IsRemembered && string.IsNullOrEmpty(Settings.AccessToken))
            {
                MainViewModels.GetInstance().Products = new ProductsViewModel();
                MainPage = new NavigationPage(new ProductsPage());
            }
            else
            {
                MainViewModels.GetInstance().Login = new LoginViewModel();
                MainPage = new NavigationPage(new LoginPage());
            }  
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
