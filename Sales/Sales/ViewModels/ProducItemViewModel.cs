namespace Sales.ViewModels
{
    using System;
    using System.Linq;
    using System.Windows.Input;
    using Common.Models;
    using GalaSoft.MvvmLight.Command;
    using Helpers;
    using Services;
    using Views;
    using Xamarin.Forms;

    public class ProducItemViewModel : Product
    {
        #region Attibutes
        private Apiservice apiservice;
        #endregion

        #region Constructor
        public ProducItemViewModel()
        {
            apiservice = new Apiservice();
        }
        #endregion

        #region Commands

        public ICommand EditProductCommand
        {
            get
            {
                return new RelayCommand(EditProduct);
            }
        }

        private async void EditProduct()
        {
            MainViewModels.GetInstance().EditProduct = new EditProductViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new EditProductPage());
        }

        public ICommand DeleteProductCommand
        {
            get
            {
                return new RelayCommand(DeleteProduct);
            }
           
        }

        private async void DeleteProduct()
        {
            var answer = await Application.Current.MainPage.DisplayAlert(
                Languages.Confirm,
                Languages.DeleteConfirmation,
                Languages.Yes, 
                Languages.No);

            if (!answer)
            {
                return;
              
            }

            var connection = await this.apiservice.CheckConnection();
            if (!connection.IsSuccess)
            {
                
                await Application.Current.MainPage.DisplayAlert(Languages.Error, connection.Message, Languages.Aceptar);
                return;
            }

            var url = Application.Current.Resources["UrlAPI"].ToString();
            var prefix = Application.Current.Resources["UrlPrefix"].ToString();
            var controller = Application.Current.Resources["UrlProductsController"].ToString();
            var response = await this.apiservice.Delete(url, prefix, controller,this.ProductId);
            if (!response.IsSuccess)
            {
                
                await Application.Current.MainPage.DisplayAlert(Languages.Error, response.Message, Languages.Aceptar);
                return;
            }

            var productsViewModel = ProductsViewModel.GetInstance();
            var deleteProduct = productsViewModel.MyProducts.Where(p => p.ProductId == this.ProductId).FirstOrDefault();
            if (deleteProduct !=null)
            {

                productsViewModel.MyProducts.Remove(deleteProduct);
            }

            productsViewModel.RefreshList();
        }
        #endregion
    }
}
