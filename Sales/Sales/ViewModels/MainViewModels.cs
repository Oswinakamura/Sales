namespace Sales.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Views;
    using Xamarin.Forms;

    public class MainViewModels
    {
        public ProductsViewModel Products { get; set; }

        public AddProductViewModel AddProduct { get; set; }

        public MainViewModels()
        {
            this.Products = new ProductsViewModel();
        }

        public ICommand AddProductCommand
        {
            get
            {
                return new RelayCommand(GotoAddProduct);
            }
        }

        private async void GotoAddProduct()
        {
            AddProduct = new AddProductViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AddProductPage());
        }
    }
}
