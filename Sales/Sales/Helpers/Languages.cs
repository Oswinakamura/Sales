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
    }

}
