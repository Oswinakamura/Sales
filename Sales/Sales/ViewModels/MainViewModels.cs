namespace Sales.ViewModels
{
    public class MainViewModels
    {
        public ProductsViewModel Products { get; set; }

        public MainViewModels()
        {
            this.Products = new ProductsViewModel();
        }
    }
}
