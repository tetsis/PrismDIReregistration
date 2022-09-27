using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra2
{
    public class Infra2ItemRepository : IItemRepository
    {
        public List<Item> FindAll()
        {
            var items = new List<Item> {
                new Item(1, "🍰 of Infra2"),
                new Item(2, "🍩 of Infra2"),
            };
            return items;
        }
    }
}
