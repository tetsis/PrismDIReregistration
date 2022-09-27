using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ApplicationService
{
    public interface IItemApplicationService
    {
        List<ItemDto> GetAll();
    }
}
