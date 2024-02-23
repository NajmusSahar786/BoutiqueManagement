using BoutiqueManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManagement.IServices
{
    public interface IShoppingCart
    {
        void AddToCart(Product product, int quantity);
        void RemoveFromCart(Product product, int quantity);
        decimal CalculateTotal();
    }
}
