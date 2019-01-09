namespace Sales.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Views;
    using Xamarin.Forms;

    public class MainViewModels
    {
        #region Properties
        public EditProductViewModel EditProduct { get; set; }

        public ProductsViewModel Products { get; set; }

        public AddProductViewModel AddProduct { get; set; }
        #endregion

        #region Constructors
        public MainViewModels()
        {
            instance = this;
            this.Products = new ProductsViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModels instance;

        public static MainViewModels GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModels();
            }
            return instance;
        }

        #endregion

        #region Commands
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

        #endregion
    }

}
