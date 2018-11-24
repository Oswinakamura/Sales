namespace Sales.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string Aceptar
        {
            get { return Resource.Aceptar; }
        }

        public static string Config
        {
            get { return Resource.Config; }
        }

        public static string Internet
        {
            get { return Resource.Internet; }
        }

        public static string Products
        {
            get { return Resource.Products; }
        }

        public static string AddProduct
        {
            get { return Resource.AddProduct; }
        }

        public static string Description
        {
            get { return Resource.Description; }
        }

        public static string DescriptionPlaceholder
        {
            get { return Resource.DescriptionPlaceholder; }
        }

        public static string Price
        {
            get { return Resource.Price; }
        }

        public static string PricePlaceholder
        {
            get { return Resource.PricePlaceholder; }
        }

        public static string Remarks
        {
            get { return Resource.Remarks; }
        }

        public static string Save
        {
            get { return Resource.Save; }
        }

        public static string ChangeImage
        {
            get { return Resource.ChangeImage; }
        }


    }

}
