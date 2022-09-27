using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra1
{
    public class Infra1ItemRepository : IItemRepository
    {
        public List<Item> FindAll()
        {
            var items = new List<Item> {
                new Item(1, "🍇 of Infra1"),
                new Item(2, "🍈 of Infra1"),
            };
            return items;
        }
    }
}
