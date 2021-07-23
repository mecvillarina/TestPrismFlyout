using Prism;
using Prism.Ioc;
using PrismFlyoutPage.ViewModels;
using PrismFlyoutPage.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace PrismFlyoutPage
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var result = await NavigationService.NavigateAsync("HomePage");
            if (result.Success)
            {

            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<View1, View1ViewModel>();
            containerRegistry.RegisterForNavigation<View2, View2ViewModel>();
            containerRegistry.RegisterForNavigation<View3, View3ViewModel>();
        }
    }
}
