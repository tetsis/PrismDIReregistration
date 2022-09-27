using Domain.ApplicationService;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismDIReregistration.Models;
using PrismDIReregistration.Views;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDIReregistration.ViewModels
{
    public class MainUserControlViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager _regionManager;
        private readonly IMainUserControlModel _mainUserControlModel;

        public MainUserControlViewModel(
            IRegionManager regionManager,
            IMainUserControlModel mainUserControlModel)
        {
            _regionManager = regionManager;
            _mainUserControlModel = mainUserControlModel;

            Items = _mainUserControlModel.Items;

            SwitchToInfra1Command = new ReactiveCommand();
            SwitchToInfra1Command.Subscribe(() =>
            {
                _mainUserControlModel.SwitchToInfra1();

                _regionManager.RequestNavigate("ContentRegion", nameof(MainUserControl));
            });

            SwitchToInfra2Command = new ReactiveCommand();
            SwitchToInfra2Command.Subscribe(() =>
            {
                _mainUserControlModel.SwitchToInfra2();

                _regionManager.RequestNavigate("ContentRegion", nameof(MainUserControl));
            });
        }

        public List<ItemDto> Items { get; }

        public ReactiveCommand SwitchToInfra1Command { get; }
        public ReactiveCommand SwitchToInfra2Command { get; }

        #region NavigationAware
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
        #endregion
    }
}
