﻿using BoutiqueManagement.IRepositories;
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