using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExDepenServ
{
    public partial class App : Application
    {
        public static IDeviceSettings ServiceDeviceSettings { get; set; }

        public App()
        {
            InitializeComponent();          
        }

        protected override void OnStart()
        {
            ServiceDeviceSettings = DependencyService.Get<IDeviceSettings>();

            MainPage = new MainPage();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
