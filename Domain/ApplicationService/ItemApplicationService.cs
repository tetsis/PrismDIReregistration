using AutoMapper;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ApplicationService
{
    public class ItemApplicationService : IItemApplicationService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public ItemApplicationService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Item, ItemDto>());
            _mapper = config.CreateMapper();
        }

        public List<ItemDto> GetAll()
        {
            var items = _itemRepository.FindAll().Select(x => _mapper.Map<ItemDto>(x)).ToList();
            return items;
        }
    }
}
