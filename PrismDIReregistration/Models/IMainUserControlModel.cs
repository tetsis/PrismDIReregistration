using Domain.ApplicationService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDIReregistration.Models
{
    public interface IMainUserControlModel : INotifyPropertyChanged
    {
        List<ItemDto> Items { get; }

        void SwitchToInfra1();
        void SwitchToInfra2();
    }
}
