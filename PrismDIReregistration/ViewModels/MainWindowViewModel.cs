using Prism.Mvvm;
using Prism.Regions;
using PrismDIReregistration.Views;

namespace PrismDIReregistration.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            _regionManager.RegisterViewWithRegion("ContentRegion", nameof(MainUserControl));
        }

        private string _title = "Prism DI Reregistration";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
