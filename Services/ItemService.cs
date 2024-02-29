using BoutiqueManagement.IRepositories;
using BoutiqueManagement.IServices;
using BoutiqueManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Services
{
    public class ItemService:IItemService
    {
        private IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public List<Item> GetItems()
        {
            List<Item> result = null;
            try
            {
                result= _itemRepository.GetItems();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}