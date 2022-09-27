using Domain.ApplicationService;
using Domain.Model;
using Infra1;
using Infra2;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDIReregistration.Models
{
    public class MainUserControlModel : IMainUserControlModel
    {
#pragma warning disable 0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 0067

        private readonly IItemApplicationService _itemApplicationService;
        private readonly IContainerRegistry _containerRegistry;

        public MainUserControlModel(
                IItemApplicationService itemApplicationService,
                IContainerRegistry containerRegistry)
        {
            _itemApplicationService = itemApplicationService;
            _containerRegistry = containerRegistry;

            Items = _itemApplicationService.GetAll();
        }

        public List<ItemDto> Items { get; }

        public void SwitchToInfra1()
        {
            _containerRegistry.Register<IItemRepository, Infra1ItemRepository>();
            _containerRegistry.Register<IItemApplicationService, ItemApplicationService>();

            _containerRegistry.Register<IMainUserControlModel, MainUserControlModel>();
        }

        public void SwitchToInfra2()
        {
            _containerRegistry.Register<IItemRepository, Infra2ItemRepository>();
            _containerRegistry.Register<IItemApplicationService, ItemApplicationService>();

            _containerRegistry.Register<IMainUserControlModel, MainUserControlModel>();
        }
    }
}
