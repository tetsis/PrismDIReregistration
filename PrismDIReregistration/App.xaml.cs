using Domain.ApplicationService;
using Domain.Model;
using Infra1;
using Prism.Ioc;
using PrismDIReregistration.Models;
using PrismDIReregistration.Views;
using System.Windows;

namespace PrismDIReregistration
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(containerRegistry);

            containerRegistry.Register<IItemRepository, Infra1ItemRepository>();
            containerRegistry.Register<IItemApplicationService, ItemApplicationService>();

            containerRegistry.Register<IMainUserControlModel, MainUserControlModel>();

            containerRegistry.RegisterForNavigation<MainUserControl>();
        }
    }
}
