using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismFlyoutPage.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            OnTapCommand = new DelegateCommand<string>(async (view) =>
            {
                await NavigationService.NavigateAsync($"NavigationPage/{view}");
            });
        }

        public DelegateCommand<string> OnTapCommand { get; private set; }
    }
}
