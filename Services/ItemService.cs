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

        public int AddItem(Item item)
        {
            int result = 0;
            try
            {
                result = _itemRepository.AddItem(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<Brand> BrandList()
        {
            List<Brand> result = null;
            try
            {
                result = _itemRepository.BrandList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<Category> CategoryList()
        {
            List<Category> result = null;
            try
            {
                result = _itemRepository.CategoryList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public Item GetItemById(int id)
        {
            Item result = null;
            try
            {
                result = _itemRepository.GetItemById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
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

        public int UpdateItem(Item item)
        {
            int result = 0;
            try
            {
                result = _itemRepository.UpdateItem(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}