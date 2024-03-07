using BoutiqueManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManagement.IRepositories
{
    public interface IItemRepository
    {
        List<Item> GetItems();
        List<Category> CategoryList();
        List<Brand> BrandList(); 
    }
}
